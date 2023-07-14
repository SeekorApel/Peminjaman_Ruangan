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
    public partial class PengembalianRuanganAdmin : Form
    {
        DateTime tglPeminjaman;
        DateTime tglPengembalian;
        string selisihHari = "";
        string tampungTotalDendaHari = "";
        int statusKerusakan = 0;

        public PengembalianRuanganAdmin()
        {
            InitializeComponent();
            
        }

        private void PengembalianRuanganAdmin_Load(object sender, EventArgs e)
        {
            getData();
            txtIdPeminjaman.Enabled = false;
            dtTanggalPeminjaman.Enabled = false;

        }

        private void txtIdPeminjaman_Leave(object sender, EventArgs e)
        {

        }

        private void getData()
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

        private void dgvTabelPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime tanggalPeminjaman;
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
            }
        }

        private void txtTotalDenda_TextChanged(object sender, EventArgs e)
        {
            getDenda();
        }

        private void btnCoba_Click(object sender, EventArgs e)
        {
            
            string coba = tglPeminjaman.ToString("dd/MM/yyyy");
            MessageBox.Show(coba);
        }

        private void btnCobaSelilih_Click(object sender, EventArgs e)
        {
            tglPengembalian = dtTanggalPengembalian.Value;

            TimeSpan selisihTanggal = tglPengembalian.Date - tglPeminjaman.Date;
            int hari = selisihTanggal.Days;
            string convertHari = hari.ToString("F0");
            selisihHari = convertHari;

            MessageBox.Show(convertHari);
        }

        private void getDenda()
        {
            int jumlahHariPengembalian = 0;
            if (!string.IsNullOrEmpty(selisihHari))
            {
                jumlahHariPengembalian = int.Parse(selisihHari);
            }

            if (jumlahHariPengembalian == 0)
            {
                /*MessageBox.Show("0");*/
                txtTotalDenda.Text = "0";
                tampungTotalDendaHari = txtTotalDenda.Text;
            }
            else if (jumlahHariPengembalian >= 1)
            {
                int dendaTelat = 10000;
                int totalDendaTelatHari = jumlahHariPengembalian * dendaTelat;
                string hasil = totalDendaTelatHari.ToString();
                /*MessageBox.Show(hasil);*/
                txtTotalDenda.Text = hasil;
                tampungTotalDendaHari = txtTotalDenda.Text;
            }
        }


        private void btnDenda_Click(object sender, EventArgs e)
        {
            
        }

        private DateTime tglPengembalianSebelumnya;
        private void dtTanggalPengembalian_ValueChanged(object sender, EventArgs e)
        {
            DateTime tglPengembalianSekarang = dtTanggalPengembalian.Value;
            if (tglPengembalianSekarang.Month != tglPengembalianSebelumnya.Month || tglPengembalianSekarang.Month == tglPengembalianSebelumnya.Month)
            {
                hitungSelisihHari();
                getDenda();
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
            /*MessageBox.Show(convertHari);*/
        }

        private void rbRusak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && selectedRadioButton.Name == "rbRusak")
            {
                MessageBox.Show("Baa");
            }
        }
    }
}
