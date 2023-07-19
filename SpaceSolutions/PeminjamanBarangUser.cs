using Guna.UI2.WinForms.Suite;
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
    public partial class PeminjamanBarangUser : Form
    {
        string idUser, idPeminjamanBarang, idPeminjamanBarangTemp, idBarang, idBarangTemp, namaBarang, stokBarangDB, stokBarangTemp;
        public PeminjamanBarangUser(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void PeminjamanBarangUser_Load(object sender, EventArgs e)
        {
            dtTanggalPeminjaman.Value = DateTime.Now;
            getDataTabelBarang();

        }


        public string autogenerateID(string firstText, string query)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlCommand sqlCmd;
            string result = "";
            int num = 0;
            try
            {
                connection.Open();
                sqlCmd = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(3, '0');
            return result;
        }


        private void btnPinjam_Click(object sender, EventArgs e)
        {
            inputTabelPeminjamanBarang();
            inputDetailPeminjamanBarang();
            getDataTabelBarang();
            clear();
        }

        private void inputTabelPeminjamanBarang()
        {
            int status = 1;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputPeminjamanBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                //Buat AUTO INCREMENT Tabel PeminjamanBarang
                string query = "SELECT TOP 1 idPeminjamanBarang FROM PeminjamanBarang ORDER BY idPeminjamanBarang DESC";
                string idPeminjaman = (string)autogenerateID("PB", query);

                sqlcmd.Parameters.AddWithValue("@idPeminjamanBarang", idPeminjaman);
                sqlcmd.Parameters.AddWithValue("@idUser", idUser);
                sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", dtTanggalPeminjaman.Value);
                sqlcmd.Parameters.AddWithValue("@lamaPeminjaman", txtLamaPeminjaman.Text);
                sqlcmd.Parameters.AddWithValue("@statusPeminjaman", status);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Peminjaman Barang Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Peminjaman Barang Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void inputDetailPeminjamanBarang()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputDetailPeminjamanBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                foreach (ListViewItem ListItem in keranjangBarang.Items)
                {

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanBarang", ListItem.SubItems[0].Text);
                    sqlcmd.Parameters.AddWithValue("@IdBarang", ListItem.SubItems[1].Text);
                    sqlcmd.Parameters.AddWithValue("@qty", ListItem.SubItems[3].Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();

                }
                connection.Close();

                /*MessageBox.Show("Peminjaman Barang Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }



        private void dgvTabelBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabelBarang.Rows[e.RowIndex];

                txtIdBarang.Text = row.Cells["Kolom1"].Value.ToString();

            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (keranjangBarang.SelectedItems.Count > 0) // Pastikan ada item yang dipilih
            {
                ListViewItem selectedRow = keranjangBarang.SelectedItems[0]; // Ambil item yang dipilih
                getDataBarang();

                string stokBarangDipijam = txtJumlahBarang.Text;
                int stok1 = 0;
                stok1 = int.Parse(stokBarangDipijam);
                int stok2 = 0;
                stok2 = int.Parse(stokBarangDB);

                if (stok1 > stok2)
                {
                    MessageBox.Show("Jumlah barang tidak Mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJumlahBarang.Text = "";
                    return;
                }
                // Update nilai kolom keempat (Jumlah Barang) dengan nilai dari txtJumlahBarang
                selectedRow.SubItems[1].Text = txtIdBarang.Text;
                selectedRow.SubItems[2].Text = getNamaBarang();
                selectedRow.SubItems[3].Text = txtJumlahBarang.Text;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (keranjangBarang.SelectedItems.Count > 0)
            {
                for (int i = 0; i < keranjangBarang.Items.Count; i++)
                {
                    if (keranjangBarang.Items[i].Selected)
                    {

                        keranjangBarang.Items[i].Remove();
                        txtIdBarang.Text = "";
                        txtJumlahBarang.Text = "";

                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            getDataBarang();

            if (string.IsNullOrEmpty(txtJumlahBarang.Text))
            {
                MessageBox.Show("Masukkan jumlah barang terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string stokBarangDipijam = txtJumlahBarang.Text;
            int stok1 = 0;
            stok1 = int.Parse(stokBarangDipijam);
            int stok2 = 0;
            stok2 = int.Parse(stokBarangDB);

            

            if (stok1 > stok2)
            {
                MessageBox.Show("Jumlah barang tidak Mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahBarang.Text = "";
                return;
            }

            //Buat AUTO INCREMENT Tabel PeminjamanBarang
            string query = "SELECT TOP 1 idPeminjamanBarang FROM PeminjamanBarang ORDER BY idPeminjamanBarang DESC";
            idPeminjamanBarang = (string)autogenerateID("PB", query);


            string[] barang = new string[5];
            barang[0] = idPeminjamanBarang;
            barang[1] = idBarang;
            barang[2] = namaBarang;
            barang[3] = txtJumlahBarang.Text;

            idPeminjamanBarang = null;
            idBarang = null;
            namaBarang = null;


            ListViewItem listBarang = new ListViewItem(barang);
            keranjangBarang.Items.Add(listBarang);
            txtCariBarang.Text = "";
            txtJumlahBarang.Text = "";
            txtIdBarang.Text = "";
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
                string query = "SELECT idBarang, namaBarang, stokBarang FROM Barang where namaBarang LIKE '%' + @CariBarang + '%' AND [status] = 1";
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

        private void keranjangBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keranjangBarang.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = keranjangBarang.SelectedItems[0]; // Ambil item yang dipilih (baris pertama
                idPeminjamanBarangTemp = selectedRow.SubItems[0].Text; // Ambil nilai kolom ke 0 atau id Fasilitasnya
                string valJumlahBarang = selectedRow.SubItems[3].Text; // Ambil nilai kolom ketiga
                string valIDBarang = selectedRow.SubItems[1].Text; // Ambil nilai kolom ketiga
                txtJumlahBarang.Text = valJumlahBarang;
                txtIdBarang.Text = valIDBarang;
                idBarangTemp = valIDBarang;
                stokBarangTemp = valJumlahBarang;
            }
        }

        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            
        }

        private void getDataTabelBarang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT idBarang, namaBarang, stokBarang FROM Barang WHERE status = 1";
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

        private void getDataBarang()
        {
            
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Barang WHERE idBarang = @idBarang AND [status] = 1", connection);
                cmd.Parameters.AddWithValue("@idBarang", txtIdBarang.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    idBarang = dt.Rows[0]["IdBarang"].ToString();
                    namaBarang = dt.Rows[0]["namaBarang"].ToString();
                    stokBarangDB = dt.Rows[0]["stokBarang"].ToString();

                }
                else
                {
                    MessageBox.Show("ID Barang tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdBarang.Text = "";
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error pada saat koneksi dengan database :" + ex.Message);
            }
        }

        private string getNamaBarang()
        {
            string nama = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("SELECT namaBarang FROM Barang WHERE idBarang = @idBarang AND [status] = 1", connection);

            sqlcmd.Parameters.AddWithValue("@idBarang", txtIdBarang.Text);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            nama = (string)result;

            return nama;
        }

        private void clear()
        {
            keranjangBarang.Items.Clear();
            txtIdBarang.Text = "";
            txtJumlahBarang.Text = "";
            txtCariBarang.Text = "";
            dtTanggalPeminjaman.Value = DateTime.Now;
            txtLamaPeminjaman.Text = "";
        }
    }
}
