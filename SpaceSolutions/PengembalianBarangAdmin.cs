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
        string idPeminjamanBarang, selisihHari, totalPengembalianBarang;
        int kondisiBarang = 0;
        public PengembalianBarangAdmin()
        {
            InitializeComponent();
        }

        private void PengembalianBarangAdmin_Load(object sender, EventArgs e)
        {
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
            DateTime tanggalPeminjaman;
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
    }
}
