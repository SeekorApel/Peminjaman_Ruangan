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
    public partial class PengembalianBarangAdmin : Form
    {
        DateTime tglPeminjaman;
        DateTime tglPengembalian;
        DateTime tglPengembalianSebelumnya;
        string idPeminjamanBarang, selisihHari, totalPengembalianBarang, idDenda, descDenda, hargaDenda;
        int kondisiBarang = 0;
        int value1 = 0;
        int value2 = 0;

        List<string[]> listItems = new List<string[]>();
        int totalDendaKerusakan = 0;
        public PengembalianBarangAdmin()
        {
            InitializeComponent();
        }

        private void PengembalianBarangAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.DendaKerusakanBarang' table. You can move, or remove it, as needed.
            this.dendaKerusakanBarangTableAdapter.QueryDendaBarang(this.dSSpaceSolutions.DendaKerusakanBarang);
            getDataPeminjamanBarang();
        }

        private void getDataPeminjamanBarang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetPeminjamanBarang() WHERE statusPeminjaman = 'Dipinjam'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelPeminjamanBarang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTabelPeminjamanBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DateTime tanggalPeminjaman;
            string tanggalConvert = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabelPeminjamanBarang.Rows[e.RowIndex];

                txtIdPeminjaman.Text = row.Cells["Kolom1"].Value.ToString();
                idPeminjamanBarang = txtIdPeminjaman.Text;
                tanggalConvert = row.Cells["Kolom4"].Value.ToString();
                keranjangBarang.Items.Clear();
                getDataDetailPeminjamanBarang();


                if (DateTime.TryParse(tanggalConvert, out tanggalPeminjaman))
                {
                    dtTanggalPeminjaman.Value = tanggalPeminjaman;
                    tglPeminjaman = tanggalPeminjaman;
                }
                else
                {
                    MessageBox.Show("Format tanggal tidak valid.");
                }
                txtTotalTelatPengembalian.Text = "0";
            }*/

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabelPeminjamanBarang.Rows[e.RowIndex];

                
                string tanggalConvert = row.Cells["Kolom4"].Value.ToString();
                txtIdPeminjaman.Text = row.Cells["Kolom1"].Value.ToString();
                idPeminjamanBarang = txtIdPeminjaman.Text;
                keranjangBarang.Items.Clear();
                getDataDetailPeminjamanBarang();

                if (DateTime.TryParse(tanggalConvert, out DateTime tanggalPeminjaman))
                {
                    if (int.TryParse(row.Cells["Kolom6"].Value.ToString(), out int lamaPeminjaman))
                    {
                        DateTime tanggalKembali = tanggalPeminjaman.AddDays(lamaPeminjaman);
                        dtTanggalPeminjaman.Value = tanggalKembali;
                        tglPeminjaman = dtTanggalPeminjaman.Value;
                    }
                    else
                    {
                        MessageBox.Show("Format lama peminjaman tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Format tanggal tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getDataDetailPeminjamanBarang()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();

            SqlCommand command = new SqlCommand("sp_GetDetailPeminjamanBarang", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idPeminjamanBarang", idPeminjamanBarang);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["idPeminjamanBarang"].ToString());
                item.SubItems.Add(reader["idBarang"].ToString());
                item.SubItems.Add(reader["namaBarang"].ToString());
                item.SubItems.Add(reader["qty"].ToString());
                keranjangBarang.Items.Add(item);
            }
        }

        private void dtTanggalPengembalian_ValueChanged(object sender, EventArgs e)
        {
            DateTime tglPengembalianSekarang = dtTanggalPengembalian.Value;
            if (tglPengembalianSekarang.Month != tglPengembalianSebelumnya.Month || tglPengembalianSekarang.Month == tglPengembalianSebelumnya.Month)
            {
                hitungSelisihHari();
                getDendaTelatPengembalianBarang();
            }
            tglPengembalianSebelumnya = tglPengembalianSekarang;
        }

        private void queryDendaBarangToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dendaKerusakanBarangTableAdapter.QueryDendaBarang(this.dSSpaceSolutions.DendaKerusakanBarang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private int totalHargaSebelumnya = 0;

        private void KeranjangKerusakan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cek apakah ada item yang dipilih
            if (KeranjangKerusakan.SelectedItems.Count > 0)
            {
                // Ambil harga denda dari item yang dipilih
                int hargaDendaInt = int.Parse(KeranjangKerusakan.SelectedItems[0].SubItems[3].Text);
                int jumlahBarangRusakInt = int.Parse(KeranjangKerusakan.SelectedItems[0].SubItems[4].Text);

                // Simpan total harga sebelumnya sebelum menghapus item
                totalHargaSebelumnya = hargaDendaInt * jumlahBarangRusakInt;
            }
        }

        private void txtTotalTelatPengembalian_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalTelatPengembalian.Text, out int newValue))
            {
                value1 = newValue;
                updateTotalDenda();
            }
        }

        private void txtTotalDendaKerusakan_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalDendaKerusakan.Text, out int newValue))
            {
                value2 = newValue;
                updateTotalDenda();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void rbRusak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && selectedRadioButton.Name == "rbRusak")
            {
                cbKerusakanBarang.Visible = true;
                btnTambahKeranjang.Visible = true;
                btnHapusKeranjang.Visible = true;
                LabelDetailDenda.Visible = true;
                labelJumlahBarangRusak.Visible = true;
                txtJumlahKerusakanBarang.Visible = true;
                KeranjangKerusakan.Visible = true;
            }
        }

        private void rbTidakRusak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && selectedRadioButton.Name == "rbTidakRusak")
            {
                cbKerusakanBarang.Visible = false;
                btnTambahKeranjang.Visible = false;
                btnHapusKeranjang.Visible = false;
                LabelDetailDenda.Visible = false;
                labelJumlahBarangRusak.Visible = false;
                txtJumlahKerusakanBarang.Visible = false;
                KeranjangKerusakan.Visible = false;
                KeranjangKerusakan.Items.Clear();
                txtJumlahKerusakanBarang.Text = "";
                txtTotalDendaKerusakan.Text = "0";
                cbKerusakanBarang.SelectedIndex = -1;
            }
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if(rbRusak.Checked == true)
            {
                kondisiBarang = 1;

            }else if(rbTidakRusak.Checked == true)
            {
                kondisiBarang = 0;
            }

            if(kondisiBarang == 0)
            {
                if (txtIdPeminjaman.Text == "" || txtTotalDenda.Text == "")
                {
                    MessageBox.Show("Tidak boleh ada data yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InputPengembalianBarang();
                cbKerusakanBarang.Visible = false;
                btnTambahKeranjang.Visible = false;
                btnHapusKeranjang.Visible = false;
                LabelDetailDenda.Visible = false;
                labelJumlahBarangRusak.Visible = false;
                txtJumlahKerusakanBarang.Visible = false;
                KeranjangKerusakan.Visible = false;
                KeranjangKerusakan.Items.Clear();
                keranjangBarang.Items.Clear();
                rbRusak.Checked = false;
                rbTidakRusak.Checked = false;
                txtTotalDenda.Text = "0";
                pengembalianStockBarang();
                getDataPeminjamanBarang();
            }
            else if(kondisiBarang == 1)
            {
                if (txtIdPeminjaman.Text == "" || txtTotalDenda.Text == "")
                {
                    MessageBox.Show("Tidak boleh ada data yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InputPengembalianBarang();
                InputdetailDendaKerusakanBarang();
                cbKerusakanBarang.Visible = false;
                btnTambahKeranjang.Visible = false;
                btnHapusKeranjang.Visible = false;
                LabelDetailDenda.Visible = false;
                labelJumlahBarangRusak.Visible = false;
                txtJumlahKerusakanBarang.Visible = false;
                KeranjangKerusakan.Visible = false;
                KeranjangKerusakan.Items.Clear();
                keranjangBarang.Items.Clear();
                rbRusak.Checked = false;
                rbTidakRusak.Checked = false;
                txtTotalDenda.Text = "0";
                pengembalianStockBarang();
                getDataPeminjamanBarang();
            }
        }

        private void InputPengembalianBarang()
        {
            string hasilText = txtTotalDenda.Text;

            // Menghapus simbol mata uang dan pemisah ribuan
            string angkaString = hasilText.Replace("Rp", "").Replace(",", "");

            // Mengonversi string menjadi angka desimal
            decimal angka = decimal.Parse(angkaString);

            // Tampung hasil konversi ke string
            string totalDenda = "";
            totalDenda = angka.ToString();

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_PengembalianBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@idPeminjamanBarang", txtIdPeminjaman.Text);
                sqlcmd.Parameters.AddWithValue("@tanggalPengembalian", dtTanggalPengembalian.Value);
                sqlcmd.Parameters.AddWithValue("@kondisiBarang", kondisiBarang);
                sqlcmd.Parameters.AddWithValue("@totalBiayaDenda", totalDenda);

                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Pengembalian Barang Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Pengembalian Barang Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void InputdetailDendaKerusakanBarang()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputDetailKerusakanBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                foreach (ListViewItem ListItem in KeranjangKerusakan.Items)
                {

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanBarang", ListItem.SubItems[0].Text);
                    sqlcmd.Parameters.AddWithValue("@idDendaKerusakanBarang", ListItem.SubItems[1].Text);
                    sqlcmd.Parameters.AddWithValue("@jumlahBarangRusak", ListItem.SubItems[4].Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();

                }

                connection.Close();

                /*MessageBox.Show("Pengembalian Barang Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void pengembalianStockBarang()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_PengembalianBarangStok", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                foreach (ListViewItem ListItem in keranjangBarang.Items)
                {

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanBarang", ListItem.SubItems[0].Text);
                    sqlcmd.Parameters.AddWithValue("@idBarang", ListItem.SubItems[1].Text);
                    sqlcmd.Parameters.AddWithValue("@qty", ListItem.SubItems[3].Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();

                }

                connection.Close();

                /*MessageBox.Show("Pengembalian Barang Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            getDataDendaKerusakanBarang();
            idPeminjamanBarang = txtIdPeminjaman.Text;
            string jumlahBarangRusak = txtJumlahKerusakanBarang.Text;

            string[] barang = new string[7];
            barang[0] = idPeminjamanBarang;
            barang[1] = idDenda;
            barang[2] = descDenda;
            barang[3] = hargaDenda;
            barang[4] = jumlahBarangRusak;

            // Lakukan perhitungan untuk mengalikan hargaDenda dengan jumlahBarangRusak
            int hargaDendaInt = 0;
            int jumlahBarangRusakInt = 0;
            int totalDenda = 0;

            if (int.TryParse(hargaDenda, out hargaDendaInt) && int.TryParse(jumlahBarangRusak, out jumlahBarangRusakInt))
            {
                totalDenda = hargaDendaInt * jumlahBarangRusakInt;
            }

            // Tampilkan hasil perhitungan pada txtTotalDendaKerusakan
            txtTotalDendaKerusakan.Text = totalDenda.ToString();

            // Tambahkan item ke dalam daftar
            listItems.Add(barang);

            // Hitung dan perbarui total keseluruhan denda
            UpdateTotalDendaKerusakan();

            idPeminjamanBarang = null;
            idDenda = null;
            descDenda = null;
            hargaDenda = null;
            jumlahBarangRusak = null;

            ListViewItem listBarang = new ListViewItem(barang);
            KeranjangKerusakan.Items.Add(listBarang);
        }

        private void btnHapusKeranjang_Click(object sender, EventArgs e)
        {
            if (KeranjangKerusakan.SelectedItems.Count > 0)
            {
                // Ambil item yang dipilih
                ListViewItem selectedItem = KeranjangKerusakan.SelectedItems[0];

                // Ambil harga denda dan jumlah barang rusak dari item yang dipilih
                int hargaDendaInt = int.Parse(selectedItem.SubItems[3].Text);
                int jumlahBarangRusakInt = int.Parse(selectedItem.SubItems[4].Text);

                // Hitung total denda yang akan dikurangi
                int totalDendaItem = hargaDendaInt * jumlahBarangRusakInt;

                // Hapus item dari KeranjangKerusakan dan listItems
                KeranjangKerusakan.Items.Remove(selectedItem);
                listItems.RemoveAll(item => item[0] == selectedItem.SubItems[0].Text);

                // Perbarui total keseluruhan denda setelah penghapusan item
                totalDendaKerusakan -= totalDendaItem;
                txtTotalDendaKerusakan.Text = totalDendaKerusakan.ToString();
            }
        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {
            string idCari = txtCariNamaPeminjam.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataPeminjamanBarang();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetPeminjamanBarang() where namaUser LIKE '%' + @namaUser + '%' AND statusPeminjaman = 'Dipinjam'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@namaUser", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelPeminjamanBarang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariNamaPeminjam.Text = "";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataPeminjamanBarang();
            txtCariNamaPeminjam.Text = "";
        }

        private void UpdateTotalDendaKerusakan()
        {
            // Hitung total keseluruhan denda dari semua item di daftar
            totalDendaKerusakan = 0;
            foreach (string[] barang in listItems)
            {
                int hargaDendaInt = int.Parse(barang[3]);
                int jumlahBarangRusakInt = int.Parse(barang[4]);
                totalDendaKerusakan += hargaDendaInt * jumlahBarangRusakInt;
            }

            // Tampilkan total keseluruhan denda pada txtTotalDendaKerusakan
            txtTotalDendaKerusakan.Text = totalDendaKerusakan.ToString();
        }

        private void hitungSelisihHari()
        {
            tglPengembalian = dtTanggalPengembalian.Value;
            TimeSpan selisihTanggal = tglPengembalian - tglPeminjaman;
            int hari = (int)selisihTanggal.TotalDays;
            string convertHari = hari.ToString("F0");
            selisihHari = convertHari;

        }

        private void getDendaTelatPengembalianBarang()
        {
            int jumlahHariPengembalian = 0;
            if (!string.IsNullOrEmpty(selisihHari))
            {
                jumlahHariPengembalian = int.Parse(selisihHari);
            }

            if (jumlahHariPengembalian == 0)
            {
                txtTotalTelatPengembalian.Text = "0";
                totalPengembalianBarang = txtTotalTelatPengembalian.Text;
            }
            else if (jumlahHariPengembalian >= 1)
            {
                int dendaTelat = 10000;
                int totalDendaTelatHari = jumlahHariPengembalian * dendaTelat;
                string hasil = totalDendaTelatHari.ToString();
                txtTotalTelatPengembalian.Text = hasil;
                totalPengembalianBarang = txtTotalTelatPengembalian.Text;
            }
        }

        private void getDataDendaKerusakanBarang()
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DendaKerusakanBarang WHERE idDendaKerusakanBarang = @idDenda AND [status] = 1", connection);
                cmd.Parameters.AddWithValue("@idDenda", cbKerusakanBarang.SelectedValue.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    idDenda = dt.Rows[0]["idDendaKerusakanBarang"].ToString();
                    descDenda = dt.Rows[0]["deskripsiKerusakan"].ToString();
                    hargaDenda = dt.Rows[0]["biayaDenda"].ToString();
                }
                else
                {
                    MessageBox.Show("ID Denda tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error pada saat koneksi dengan database :" + ex.Message);
            }
        }

        private void updateTotalDenda()
        {
            int hasil = value1 + value2;
            txtTotalDenda.Text = hasil.ToString("C0");
        }


    }
}
