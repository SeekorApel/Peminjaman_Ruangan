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

            this.reportViewer1.RefreshReport();
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
    }
}
