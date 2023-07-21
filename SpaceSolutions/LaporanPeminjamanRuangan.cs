using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSolutions
{
    public partial class LaporanPeminjamanRuangan : Form
    {
        public LaporanPeminjamanRuangan()
        {
            InitializeComponent();
        }

        private void LaporanPeminjaman_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            if (txtFilterTahun.Text == "" || cbFilterBulan.SelectedItem == "" || cbFilterStatusPeminjaman.SelectedItem == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int statusPeminjaman = 0;
                if (cbFilterStatusPeminjaman.SelectedIndex.Equals(0))
                {
                    statusPeminjaman = 1;
                }
                else if (cbFilterStatusPeminjaman.SelectedIndex.Equals(1))
                {
                    statusPeminjaman = 3;
                }

                string bulan = cbFilterBulan.SelectedItem?.ToString();
                int bulanAngka = 0;
                int tahun = Convert.ToInt32(txtFilterTahun.Text);

                if (!string.IsNullOrEmpty(bulan))
                {
                    DateTimeFormatInfo formatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
                    bulanAngka = Array.IndexOf(formatInfo.MonthNames, bulan) + 1;
                }

                this.laporanPeminjamanRuanganTableAdapter.Fill(this.dSSpaceSolutions.LaporanPeminjamanRuangan, statusPeminjaman, bulanAngka, tahun);

                this.reportViewer1.RefreshReport();
            }

        }

        private void txtFilterTahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka atau kontrol (seperti backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }

            // Memeriksa apakah jumlah karakter telah mencapai batas maksimum
            if (txtFilterTahun.Text.Length >= 4 && e.KeyChar != '\b') // '\b' adalah karakter backspace
            {
                e.Handled = true; // Mencegah karakter ditambahkan jika batas maksimum telah tercapai
            }
        }
    }
}
