using Microsoft.VisualBasic.ApplicationServices;
using System;
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

namespace SpaceSolutions
{
    public partial class CRUDBarang : Form
    {
        string idBarang, namaBarang,stokBarang, kategoriBarang;
       
        public CRUDBarang()
        {
            InitializeComponent();
        }

        private void CRUDBarang_Load(object sender, EventArgs e)
        {
            getDataTabelBarang();
        }

        private void getDataTabelBarang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM Barang WHERE status = 1";
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

        private void dgvTabelBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                idBarang = Convert.ToString(dgvTabelBarang.Rows[e.RowIndex].Cells["idBarangColumn"].Value);
                namaBarang = Convert.ToString(dgvTabelBarang.Rows[e.RowIndex].Cells["namaBarangColumn"].Value);
                kategoriBarang = Convert.ToString(dgvTabelBarang.Rows[e.RowIndex].Cells["kategoriBarangColumn"].Value);
                stokBarang = Convert.ToString(dgvTabelBarang.Rows[e.RowIndex].Cells["stokBarangColumn"].Value);

                UpdateBarang updateBrg = new UpdateBarang(idBarang, namaBarang, kategoriBarang, stokBarang);
                updateBrg.ShowDialog();

                
            }
            if(e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection();
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteBarang", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idBarang = Convert.ToString(dgvTabelBarang.Rows[e.RowIndex].Cells["idBarangColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idBarang", idBarang);

                        connection.Open();
                        int hasil = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                        connection.Close();

                        if (hasil != 0)
                        {
                            MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDataTabelBarang();
                        }
                        else
                        {
                            MessageBox.Show("Hapus data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message);
                    }

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidBarang.Text.Trim();

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
                string query = "SELECT * FROM Barang WHERE idBarang = @idBarang AND [status] = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idBarang", idCari);
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
                    txtCariidBarang.Text = "";
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
            txtCariidBarang.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputBarang barang = new InputBarang();
            barang.Show();
        }

    }
}
