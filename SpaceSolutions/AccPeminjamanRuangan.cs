using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void btnTolakPeminjaman_Click(object sender, EventArgs e)
        {

        }

        private void btnSetujui_Click(object sender, EventArgs e)
        {
            accPeminjaman();
        }

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
            txtNamaUser.Text = getNamaUser();
            txtNamaRuangan.Text = getNamaRuangan();
            txtJenisKegitan.Text = jenisKegiatanTemp;
            txtKapasitasOrang.Text = kapasitasOrangTemp;
            dtTanggalPeminjaman.Value = convertTanggal;
            txtLamaPeminjaman.Text = lamaPeminjamanTemp;
        }


        private string getNamaUser()
        {
            string nama = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getNamaUserbyId", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idUser", idUserTemp);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            nama = (string)result;

            return nama;
        }

        private string getNamaRuangan()
        {
            string namaRuangan = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getNamaRuanganbyId", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", idRuanganTemp);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            namaRuangan = (string)result;
            
            return namaRuangan;
        }

        private void accPeminjaman()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_AccPeminjamanRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@idPeminjamanRuangan", idPeminjamanTemp);
                sqlcmd.Parameters.AddWithValue("@idRuangan", idRuanganTemp);
                sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", tanggalPeminjamanTemp);

                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Peminjaman Di setujui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Peminjaman Di setujui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
