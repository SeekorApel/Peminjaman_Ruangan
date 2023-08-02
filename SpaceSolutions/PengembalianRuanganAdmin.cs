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
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class PengembalianRuanganAdmin : Form
    {
        DateTime tglPeminjaman;
        DateTime tglPengembalian;
        string selisihHari = "";
        string tampungTotalDendaHari = "";
        string idPeminjaman,idDenda, hargaDenda, descDenda;
        int value1 = 0;
        int value2 = 0;
        int statusKerusakan = 0;

        public PengembalianRuanganAdmin()
        {
            InitializeComponent();
            
        }

        private void PengembalianRuanganAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.DendaKerusakanRuangan' table. You can move, or remove it, as needed.
            this.dendaKerusakanRuanganTableAdapter.Fill(this.dSSpaceSolutions.DendaKerusakanRuangan);
            getDataPeminjamanRuangan();
            txtIdPeminjaman.Enabled = false;
            dtTanggalPeminjaman.Enabled = false;
            query1ToolStrip.Visible = false;
            cbKerusakanRuangan.Visible = false;
            btnTambahKeranjang.Visible = false;
            btnHapusKeranjang.Visible = false;
            KeranjangKerusakan.Visible = false;
            tglPengembalianSebelumnya = dtTanggalPengembalian.Value;
            txtTotalDenda.Text = "0";
        }

        

        private void dgvTabelPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DateTime tanggalPeminjaman;
             string tanggalConvert = "";
             if (e.RowIndex >= 0)
             {
                 DataGridViewRow row = dgvTabelPeminjaman.Rows[e.RowIndex];

                 txtIdPeminjaman.Text = row.Cells["Kolom1"].Value.ToString();
                 tanggalConvert = row.Cells["Kolom8"].Value.ToString(); 


                 if (DateTime.TryParse(tanggalConvert, out tanggalPeminjaman))
                 {
                     dtTanggalPeminjaman.Value = tanggalPeminjaman;
                     tglPeminjaman = tanggalPeminjaman;
                 }
                 else
                 {
                     MessageBox.Show("Format tanggal tidak valid.");
                 }
             }*/
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTabelPeminjaman.Rows[e.RowIndex];

                // Get the string value from the DataGridView cell
                string tanggalConvert = row.Cells["Kolom8"].Value.ToString();
                txtIdPeminjaman.Text = row.Cells["Kolom1"].Value.ToString();

                if (DateTime.TryParse(tanggalConvert, out DateTime tanggalPeminjaman))
                {
                    if (int.TryParse(row.Cells["Kolom9"].Value.ToString(), out int lamaPeminjaman))
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

        private void txtTotalDenda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void getDendaTelatPengembalianRuangan()
        {
            int jumlahHariPengembalian = 0;
            if (!string.IsNullOrEmpty(selisihHari))
            {
                jumlahHariPengembalian = int.Parse(selisihHari);
            }

            if (jumlahHariPengembalian == 0)
            {
                txtTotalDendaTelatPengembalian.Text = "0";
                tampungTotalDendaHari = txtTotalDendaTelatPengembalian.Text;
            }
            else if (jumlahHariPengembalian >= 1)
            {
                int dendaTelat = 10000;
                int totalDendaTelatHari = jumlahHariPengembalian * dendaTelat;
                string hasil = totalDendaTelatHari.ToString();
                txtTotalDendaTelatPengembalian.Text = hasil;
                tampungTotalDendaHari = txtTotalDendaTelatPengembalian.Text;
            }
        }

        private DateTime tglPengembalianSebelumnya;
        private void dtTanggalPengembalian_ValueChanged(object sender, EventArgs e)
        {
            DateTime tglPengembalianSekarang = dtTanggalPengembalian.Value;
            if (tglPengembalianSekarang.Month != tglPengembalianSebelumnya.Month || tglPengembalianSekarang.Month == tglPengembalianSebelumnya.Month)
            {
                hitungSelisihHari();
                getDendaTelatPengembalianRuangan();
            }
            tglPengembalianSebelumnya = tglPengembalianSekarang;
        }

        private void hitungSelisihHari()
        {
            tglPengembalian = dtTanggalPengembalian.Value;

            TimeSpan selisihTanggal = tglPengembalian - tglPeminjaman;
            int hari = (int)selisihTanggal.TotalDays;
            string convertHari = hari.ToString("F0");
            selisihHari = convertHari;
           
        }

        private void query1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dendaKerusakanRuanganTableAdapter.Query1(this.dSSpaceSolutions.DendaKerusakanRuangan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnHapusKerusakan_Click(object sender, EventArgs e)
        {
            if (KeranjangKerusakan.SelectedItems.Count > 0)
            {
                for (int i = 0; i < KeranjangKerusakan.Items.Count; i++)
                {
                    if (KeranjangKerusakan.Items[i].Selected)
                    {

                        KeranjangKerusakan.Items[i].Remove();
                        int totalDenda = 0;

                        foreach (ListViewItem item in KeranjangKerusakan.Items)
                        {
                            int biayaDenda = int.Parse(item.SubItems[3].Text);
                            totalDenda += biayaDenda;
                        }

                        txtTotalDendaKerusakanRuangan.Text = totalDenda.ToString();
                    }
                }
            }
        }

        private void txtTotalDendaTelatPengembalian_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalDendaTelatPengembalian.Text, out int newValue))
            {
                value1 = newValue;
                updateTotalDenda();
            }
        }

        private void txtTotalDendaKerusakanRuangan_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTotalDendaKerusakanRuangan.Text, out int newValue))
            {
                value2 = newValue;
                updateTotalDenda();
            }
        }

        private void updateTotalDenda()
        {
            int hasil = value1 + value2;
            txtTotalDenda.Text = hasil.ToString("C0");
        }



        private void btnTambahDenda_Click(object sender, EventArgs e)
        {
            getDataDendaKerusakan();
            idPeminjaman = txtIdPeminjaman.Text;

            string[] barang = new string[5];
            barang[0] = idPeminjaman;
            barang[1] = idDenda;
            barang[2] = descDenda;
            barang[3] = hargaDenda;


            idPeminjaman = null;
            idDenda = null;
            descDenda = null;
            hargaDenda = null;

            ListViewItem listBarang = new ListViewItem(barang);
            KeranjangKerusakan.Items.Add(listBarang);

            int totalDenda = 0;

            foreach (ListViewItem item in KeranjangKerusakan.Items)
            {
                int biayaDenda = int.Parse(item.SubItems[3].Text);
                totalDenda += biayaDenda;
            }

            txtTotalDendaKerusakanRuangan.Text = totalDenda.ToString();

        }


        private void rbRusak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && selectedRadioButton.Name == "rbRusak")
            {
                cbKerusakanRuangan.SelectedIndex = -1;
                cbKerusakanRuangan.Visible = true;
                btnTambahKeranjang.Visible = true;
                btnHapusKeranjang.Visible = true;
                KeranjangKerusakan.Visible = true;
            }
        }

        private void rbTidakKerusakan_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && selectedRadioButton.Name == "rbTidakKerusakan")
            {
                cbKerusakanRuangan.Visible = false;
                btnTambahKeranjang.Visible = false;
                btnHapusKeranjang.Visible = false;
                KeranjangKerusakan.Visible = false;
                KeranjangKerusakan.Items.Clear();
                txtTotalDendaKerusakanRuangan.Text = "0";
            }
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if(rbRusak.Checked == true)
            {
                statusKerusakan = 1;

            }else if(rbTidakKerusakan.Checked == true)
            {
                statusKerusakan = 0;
            }

            if(statusKerusakan == 0)
            {
                if(txtIdPeminjaman.Text == "" || txtTotalDenda.Text == "" || rbTidakKerusakan.Checked == false)
                {
                    MessageBox.Show("Tidak boleh ada data yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                inputPeminjamanRuangan();
                getDataPeminjamanRuangan();
                clear();
            }
            else if (statusKerusakan == 1)
            {
                if (txtIdPeminjaman.Text == "" || txtTotalDenda.Text == "" || KeranjangKerusakan.Items.Count == 0)
                {
                    MessageBox.Show("Tidak boleh ada data yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                inputPeminjamanRuangan();
                inputDetailKerusakanRuangan();
                getDataPeminjamanRuangan();
                clear();
            }
        }

        private void inputPeminjamanRuangan()
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
                SqlCommand sqlcmd = new SqlCommand("sp_PengembalianRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@idPeminjamanRuangan", txtIdPeminjaman.Text);
                sqlcmd.Parameters.AddWithValue("@tanggalPengembalian", dtTanggalPengembalian.Value);
                sqlcmd.Parameters.AddWithValue("@kondisiRuangan", statusKerusakan);
                sqlcmd.Parameters.AddWithValue("@totalBiayaDenda", totalDenda);

                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Pengembalian Ruangan Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Pengembalian Ruangan Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void inputDetailKerusakanRuangan()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_InputDetailKerusakanRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                foreach (ListViewItem ListItem in KeranjangKerusakan.Items)
                {

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanRuangan", ListItem.SubItems[0].Text);
                    sqlcmd.Parameters.AddWithValue("@idDendaKerusakanRuangan", ListItem.SubItems[1].Text);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Parameters.Clear();

                }

                connection.Close();

                /*MessageBox.Show("Pengembalian Ruangan Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnHapusKeranjang_Click(object sender, EventArgs e)
        {
            if (KeranjangKerusakan.SelectedItems.Count > 0)
            {
                for (int i = 0; i < KeranjangKerusakan.Items.Count; i++)
                {
                    if (KeranjangKerusakan.Items[i].Selected)
                    {

                        KeranjangKerusakan.Items[i].Remove();
                        int totalDenda = 0;

                        foreach (ListViewItem item in KeranjangKerusakan.Items)
                        {
                            int biayaDenda = int.Parse(item.SubItems[3].Text);
                            totalDenda += biayaDenda;
                        }

                        txtTotalDendaKerusakanRuangan.Text = totalDenda.ToString();
                    }
                }
            }
        }

        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            getDataDendaKerusakan();
            idPeminjaman = txtIdPeminjaman.Text;

            string[] barang = new string[5];
            barang[0] = idPeminjaman;
            barang[1] = idDenda;
            barang[2] = descDenda;
            barang[3] = hargaDenda;


            idPeminjaman = null;
            idDenda = null;
            descDenda = null;
            hargaDenda = null;

            ListViewItem listBarang = new ListViewItem(barang);
            KeranjangKerusakan.Items.Add(listBarang);

            int totalDenda = 0;

            foreach (ListViewItem item in KeranjangKerusakan.Items)
            {
                int biayaDenda = int.Parse(item.SubItems[3].Text);
                totalDenda += biayaDenda;
            }

            txtTotalDendaKerusakanRuangan.Text = totalDenda.ToString();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string nama = txtCariNamaPeminjaman.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(nama))
            {
                getDataPeminjamanRuangan();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetPeminjamanRuangan() WHERE nama LIKE '%' + @namaPeminjam + '%' AND statusPeminjaman = 'Disetujui'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@namaPeminjam", nama);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelPeminjaman.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariNamaPeminjaman.Text = "";
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

        private void getDataPeminjamanRuangan()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetPeminjamanRuangan() WHERE statusPeminjaman = 'Disetujui'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelPeminjaman.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataPeminjamanRuangan();
            txtCariNamaPeminjaman.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdPeminjaman.Text = "";
            rbRusak.Checked = false;
            rbTidakKerusakan.Checked = false;
            txtTotalDenda.Text = "";
        }

        private void getDataDendaKerusakan()
        {
            try
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DendaKerusakanRuangan WHERE idDendaKerusakanRuangan = @idDenda AND [status] = 1", connection);
                cmd.Parameters.AddWithValue("@idDenda", cbKerusakanRuangan.SelectedValue.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    idDenda = dt.Rows[0]["idDendaKerusakanRuangan"].ToString();
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

        private void txtIdPeminjaman_Leave(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtIdPeminjaman.Text = "";
            dtTanggalPeminjaman.Value = DateTime.Now;
            dtTanggalPengembalian.Value = DateTime.Now;
            rbRusak.Checked = false;
            rbTidakKerusakan.Checked = false;
            txtTotalDenda.Text = "0";
            cbKerusakanRuangan.Visible = false;
            btnTambahKeranjang.Visible = false;
            btnHapusKeranjang.Visible = false;
            KeranjangKerusakan.Visible = false;
            KeranjangKerusakan.Items.Clear();
        }
    }
}
