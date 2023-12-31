﻿using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class UpdateFasilitas : Form
    {
        string idFasilitasTemp, idfstemp, namaFasilitasTemp, idBarang, idBrgTemp, namaBarang, jmlhTemp;
        string idBarangNew, jumlahBarangNew;
        string stokBarangDB = "";
        public UpdateFasilitas(string idFasilitas, string namaFasilitas)
        {
            InitializeComponent();
            idFasilitasTemp = idFasilitas;
            namaFasilitasTemp = namaFasilitas;
        }

        private void UpdateFasilitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.dSSpaceSolutions.Barang);

            txtNamaFasilitas.Text = namaFasilitasTemp;
            getDataDetailFasilitas();

        }

        private void getDataDetailFasilitas()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();

            SqlCommand command = new SqlCommand("sp_getDetailFasilitas", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdFasilitas", idFasilitasTemp);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["idFasilitas"].ToString());
                item.SubItems.Add(reader["idBarang"].ToString());
                item.SubItems.Add(reader["namBarang"].ToString());
                item.SubItems.Add(reader["jumlahBarang"].ToString());
                keranjangDetail.Items.Add(item);
            }
        }

        private void keranjangDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariBarang.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataTabelBarang();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT idBarang, namaBarang, kategoriBarang , stokBarang FROM Barang where namaBarang LIKE '%' + @CariBarang + '%' AND [status] = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CariBarang", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelBarang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariBarang.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            getDataTabelBarang();
            txtCariBarang.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            

            if (txtNamaFasilitas.Text == "" || txtJumlahBarang.Text == "")
            {
                MessageBox.Show("Tidak boleh ada data yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtIDBarang.Text == "" && txtJumlahBarang.Text == "")
            {
                updateTabelFasilitas();
                this.Close();
                return;  

            }else if (!string.IsNullOrEmpty(txtIDBarang.Text) && !string.IsNullOrEmpty(txtIDBarang.Text))
            {
                getStokBarang();

                string stokBarangDiUpdate = txtJumlahBarang.Text;
                int stok1 = 0;
                stok1 = int.Parse(stokBarangDiUpdate);
                int stok2 = 0;
                stok2 = int.Parse(stokBarangDB);

                if (stok1 > stok2)
                {
                    MessageBox.Show("Jumlah barang tidak Mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJumlahBarang.Text = "";
                    return;
                }

                updateTabelFasilitas();

                if (keranjangDetail.SelectedItems.Count > 0) // Pastikan ada item yang dipilih
                {
                    ListViewItem selectedRow = keranjangDetail.SelectedItems[0]; // Ambil item yang dipilih
                                                                                 // Update nilai kolom keempat (Jumlah Barang) dengan nilai dari txtJumlahBarang
                    selectedRow.SubItems[1].Text = txtIDBarang.Text;
                    selectedRow.SubItems[3].Text = txtJumlahBarang.Text;
                }
                updateTabelDetailFasilitas();
                this.Close();
            }
            
        }

        private void txtNamaFasilitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek apakah karakter yang dimasukkan adalah huruf, spasi, atau tombol kontrol
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika bukan, maka batalkan input dengan menandai event sebagai sudah ditangani (Handled)
                e.Handled = true;
            }
        }

        private void txtIDBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika bukan, maka batalkan input dengan menandai event sebagai sudah ditangani (Handled)
                e.Handled = true;
            }
        }

        private void txtJumlahBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika bukan, maka batalkan input dengan menandai event sebagai sudah ditangani (Handled)
                e.Handled = true;
            }
        }

        private void dgvTabelBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabelBarang.Rows[e.RowIndex];

                txtIDBarang.Text = row.Cells["Kolom1"].Value.ToString();

            }
        }

        private void keranjangDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keranjangDetail.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = keranjangDetail.SelectedItems[0]; // Ambil item yang dipilih (baris pertama
                idfstemp = selectedRow.SubItems[0].Text; // Ambil nilai kolom ke 0 atau id Fasilitasnya
                string valJumlahBarang = selectedRow.SubItems[3].Text; // Ambil nilai kolom ketiga
                string valIDBarang = selectedRow.SubItems[1].Text; // Ambil nilai kolom ketiga
                txtJumlahBarang.Text = valJumlahBarang;
                txtIDBarang.Text = valIDBarang;
                idBrgTemp = valIDBarang;
                jmlhTemp = valJumlahBarang;
            }

            
        }

        private void txtJumlahBarang_Leave(object sender, EventArgs e)
        {
            

        }

        private void txtTambahIDBarang_Leave(object sender, EventArgs e)
        {
            
        }

        private void updateTabelFasilitas() 
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_updateFasilitas", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                
                sqlcmd.Parameters.AddWithValue("@namaFasilitas", txtNamaFasilitas.Text);
                sqlcmd.Parameters.AddWithValue("@IdFasilitas", idFasilitasTemp);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Update Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Update Data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void updateTabelDetailFasilitas()
        {
            

            idBarangNew = txtIDBarang.Text;
            jumlahBarangNew = txtJumlahBarang.Text;
            
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_updateDetailFasilitas", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@IdFasilitas", idfstemp);
                sqlcmd.Parameters.AddWithValue("@IdBarang", idBarangNew);
                sqlcmd.Parameters.AddWithValue("@IdBarangTemp", idBrgTemp);
                sqlcmd.Parameters.AddWithValue("@jumlahBarang", jumlahBarangNew);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    /*MessageBox.Show("Update Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    idfstemp = "";
                    idBarangNew = "";
                    idBrgTemp = "";
                    jumlahBarangNew = "";
                }
                else
                {
                    MessageBox.Show("Update Data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error UpdateTabelDetailFasilitas : " + ex.Message);
            }

        }

        
        private void getDataTabelBarang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT idBarang, namaBarang, kategoriBarang, stokBarang FROM Barang WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelBarang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getStokBarang()
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE idBarang = @idBarang AND [status] = 1", connection);
                cmd.Parameters.AddWithValue("@idBarang", txtIDBarang.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    stokBarangDB = dt.Rows[0]["stokBarang"].ToString();
                }
                else
                {
                    MessageBox.Show("ID Barang tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDBarang.Text = "";
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error pada saat mengambil stok :" + ex.Message);
            }
        }
    }
}
