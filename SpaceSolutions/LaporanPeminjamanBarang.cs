using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSolutions
{
    public partial class LaporanPeminjamanBarang : Form
    {
        public LaporanPeminjamanBarang()
        {
            InitializeComponent();
        }

        private void LaporanPeminjamanBarang_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (txtTahun.Text == "" || cbFilterBulan.SelectedItem == "" || cbFilterStatus.SelectedItem == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int statusPeminjaman = 0;
                if (cbFilterStatus.SelectedIndex.Equals(0))
                {
                    statusPeminjaman = 1;
                }
                else if (cbFilterStatus.SelectedIndex.Equals(1))
                {
                    statusPeminjaman = 2;
                }

                string bulan = cbFilterBulan.SelectedItem?.ToString();
                int bulanAngka = 0;
                int tahun = Convert.ToInt32(txtTahun.Text);

                if (!string.IsNullOrEmpty(bulan))
                {
                    DateTimeFormatInfo formatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
                    bulanAngka = Array.IndexOf(formatInfo.MonthNames, bulan) + 1;
                }

                this.laporanPeminjamanBarangTableAdapter.Fill(this.dSSpaceSolutions.LaporanPeminjamanBarang, statusPeminjaman, bulanAngka, tahun);
                this.reportViewer1.RefreshReport();
            }
        }

        private void txtTahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka atau kontrol (seperti backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }

            // Memeriksa apakah jumlah karakter telah mencapai batas maksimum
            if (txtTahun.Text.Length >= 4 && e.KeyChar != '\b') // '\b' adalah karakter backspace
            {
                e.Handled = true; // Mencegah karakter ditambahkan jika batas maksimum telah tercapai
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbFilterBulan.SelectedIndex = -1;
            cbFilterStatus.SelectedIndex = -1;
            txtTahun.Text = "";

            DataTable dataTable = new DataTable();
            /*dgvPeminjamanBarang.DataSource = dataTable;*/

            // Setelah Anda mengambil data dari database dan mengisinya ke dalam DataTable, Anda bisa mengosongkannya dengan cara berikut:
            dataTable.Clear();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            this.laporanDetailPeminjamanBarangTableAdapter.Fill(this.dSSpaceSolutions.LaporanDetailPeminjamanBarang, (string)txtCariidPeminjamanBarang.Text);
            this.reportViewer2.RefreshReport();
        }
    }
}
