using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SpaceSolutions
{
    public partial class InputFasilitas : Form
    {
        string idBarang, namaBarang, idFasilitas, jumlahBarang, stokBarangDB;

        public InputFasilitas()
        {
            InitializeComponent();
        }

        private void InputFasilitas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.dSSpaceSolutions.Barang);


            //Buat AUTO INCREMENT Tabel Fasilitas
            string query = "SELECT TOP 1 IdFasilitas FROM Fasilitas ORDER BY IdFasilitas DESC";
            idFasilitas = (string)autogenerateID("FS", query);
           

        }


        private void getDataNamaRuanganIdRuangan()
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

        private void getDataBarang()
        {
            try {

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
                    idBarang = dt.Rows[0]["IdBarang"].ToString();
                    namaBarang = dt.Rows[0]["namaBarang"].ToString();
                    stokBarangDB = dt.Rows[0]["stokBarang"].ToString();
                }
                else
                {
                    MessageBox.Show("ID Barang tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDBarang.Text = "";
                }

                connection.Close();

            }
            catch (Exception ex){
                MessageBox.Show("Terjadi error pada saat koneksi dengan database :" + ex.Message);
            }
        }


        private void txtTambahIDBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (keranjangDetail.Items.Count > 0)
            {
                if (string.IsNullOrEmpty(txtNamaFasilitas.Text))
                {
                    MessageBox.Show("Masukkan nama fasilitas terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                inputTableFasilitas();
                inputDetailFasilitas();
                this.Close();
            }
            else
            {
                MessageBox.Show("Harus mengisi Data Barang terelebih dahulu", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataNamaRuanganIdRuangan();
            txtCariBarang.Text = "";
        }

        private void btnTambahKeranjang_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHapusKeranjang_Click(object sender, EventArgs e)
        {
            if (keranjangDetail.SelectedItems.Count > 0)
            {
                for (int i = 0; i < keranjangDetail.Items.Count; i++)
                {
                    if (keranjangDetail.Items[i].Selected)
                    {

                        keranjangDetail.Items[i].Remove();


                    }
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariBarang.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataNamaRuanganIdRuangan();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT idBarang, namaBarang, kategoriBarang, stokBarang FROM Barang where namaBarang LIKE '%' + @CariBarang + '%' AND [status] = 1";
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
            getDataNamaRuanganIdRuangan();
            txtCariBarang.Text = "";
        }

        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            getDataBarang();

            if (idBarang == null || namaBarang == null) return;

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


            //Buat AUTO INCREMENT Tabel Fasilitas
            string query = "SELECT TOP 1 IdFasilitas FROM Fasilitas ORDER BY IdFasilitas DESC";
            idFasilitas = (string)autogenerateID("FS", query);


            string[] barang = new string[5];
            barang[0] = idFasilitas;
            barang[1] = idBarang;
            barang[2] = namaBarang;
            barang[3] = txtJumlahBarang.Text;

            idFasilitas = null;
            idBarang = null;
            namaBarang = null;


            ListViewItem listBarang = new ListViewItem(barang);
            keranjangDetail.Items.Add(listBarang);
            txtCariBarang.Text = "";
            txtJumlahBarang.Text = "";
            txtIDBarang.Text = ""; 
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

        private void inputTableFasilitas()
        {
            int status = 1;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputFasilitas", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                string query = "SELECT TOP 1 IdFasilitas FROM Fasilitas ORDER BY IdFasilitas DESC";

                sqlcmd.Parameters.AddWithValue("@IdFasilitas", autogenerateID("FS", query));
                sqlcmd.Parameters.AddWithValue("@namaFasilitas", txtNamaFasilitas.Text);
                sqlcmd.Parameters.AddWithValue("@status", status);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Input Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Input Data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inputTabelFasilitas : " + ex.Message);
            }
        }

        private void inputDetailFasilitas()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputDetailFasilitas", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                foreach (ListViewItem ListItem in keranjangDetail.Items)
                {

                    sqlcmd.Parameters.AddWithValue("@IdFasilitas", ListItem.SubItems[0].Text);
                    sqlcmd.Parameters.AddWithValue("@IdBarang", ListItem.SubItems[1].Text);
                    sqlcmd.Parameters.AddWithValue("@jumlahBarang", ListItem.SubItems[3].Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();

                }

                
                connection.Close();

                /*MessageBox.Show("Input Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (Exception ex) {

                MessageBox.Show("Error input tabelDetailFasilitas : " + ex.Message);
            }
        }
    }
}
