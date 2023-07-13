using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AccPeminjamanRuangan : Form
    {
        string idPeminjamanTemp, idUserTemp , idRuanganTemp , jenisKegiatanTemp , kapasitasOrangTemp , tanggalPeminjamanTemp , lamaPeminjamanTemp , statusPeminjamanTemp;
        DateTime convertTanggal;

        public AccPeminjamanRuangan(string idPeminjaman, string idUser, string idRuangan, string jenisKegiatan, string kapasitasOrang, string tanggalPeminjaman, string lamaPeminjaman, string statusPeminjaman)
        {
            InitializeComponent();
            idPeminjamanTemp = idPeminjaman;
            idUserTemp = idUser;
            idRuanganTemp = idRuangan;
            jenisKegiatanTemp = jenisKegiatan;
            kapasitasOrangTemp = kapasitasOrang;
            tanggalPeminjamanTemp = tanggalPeminjaman;
            convertTanggal = DateTime.Parse(tanggalPeminjamanTemp);
            lamaPeminjamanTemp = lamaPeminjaman;
            statusPeminjamanTemp = statusPeminjaman;
        }

        private void AccPeminjamanRuangan_Load(object sender, EventArgs e)
        {
            txtNamaUser.Text = idUserTemp;
            txtNamaRuangan.Text = idRuanganTemp;
            txtJenisKegitan.Text = jenisKegiatanTemp;
            txtKapasitasOrang.Text = kapasitasOrangTemp;
            dtTanggalPeminjaman.Value = convertTanggal;
            txtLamaPeminjaman.Text = lamaPeminjamanTemp;
        }
    }
}
