using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class TransaksiPeminjamanRuanganUser : Form
    {
        string idUserTemp;


        public TransaksiPeminjamanRuanganUser(string idUser)
        {
            InitializeComponent();
            idUserTemp = idUser;
        }

        private void TransaksiPeminjamanRuanganUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Ruangan' table. You can move, or remove it, as needed.
            this.ruanganTableAdapter.Fill(this.dSSpaceSolutions.Ruangan);
            cbNamaRuangan.SelectedIndex = -1;
            labelTest.Text = idUserTemp;
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if(cbNamaRuangan.SelectedIndex == -1 || txtJenisKegiatan.Text == "" || txtKapasitasOrang.Text == "" || txtLamaPeminjaman.Text == "")
            {
                MessageBox.Show("Semua data harus di isi semua", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inputDB();
            }
        }

        private void inputDB()
        {
            int statusPeminjaman = 1;
            int ketersediaanRuangan = 0;
            string convertKapasitasRuangan = txtKapasitasOrang.Text;
            int kapasitasAsli = int.Parse(convertKapasitasRuangan);
            int kapasitasMaksimal = 0;
            /*DateTime tanggalPeminjaman = getTanggalPeminjaman();
            DateTime tanggalSekarang = dtTanggalPeminjaman.Value;*/
            kapasitasMaksimal = getKapasitas();
            ketersediaanRuangan = getKetersediaanRuangan();

            if (ketersediaanRuangan == 0)
            {
                MessageBox.Show("Ruangan tidak Tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }else if (kapasitasAsli > kapasitasMaksimal)
            {
                MessageBox.Show("Kapasitas Ruangan tidak mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }else if(ketersediaanRuangan == 1)
            {
                try
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                    SqlCommand sqlcmd = new SqlCommand("sp_inputTransaksiPeminjamanRuangan", connection);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    string query = "SELECT TOP 1 idPeminjamanRuangan FROM PeminjamanRuangan ORDER BY idPeminjamanRuangan DESC";

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanRuangan", autogenerateID("PR", query));
                    sqlcmd.Parameters.AddWithValue("@idUser", idUserTemp);
                    sqlcmd.Parameters.AddWithValue("@idRuangan", cbNamaRuangan.SelectedValue.ToString());
                    sqlcmd.Parameters.AddWithValue("@jenisKegiatan", txtJenisKegiatan.Text);
                    sqlcmd.Parameters.AddWithValue("@kapasitasOrang", txtKapasitasOrang.Text);
                    sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", dtTanggalPeminjaman.Value);
                    sqlcmd.Parameters.AddWithValue("@lamaPeminjaman", txtLamaPeminjaman.Text);
                    sqlcmd.Parameters.AddWithValue("@statusPeminjaman", statusPeminjaman);


                    connection.Open();
                    int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Input Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Input Data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
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

        private int getKapasitas()
        {
            int kapasitas = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getKapasitasRuangan", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", cbNamaRuangan.SelectedValue.ToString());

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            kapasitas = (int)result;
            return kapasitas;
        }

        private int getKetersediaanRuangan()
        {
            int status = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getketersediaanRuangan", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", cbNamaRuangan.SelectedValue.ToString());

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            status = (int)result;
            return status;
        }

        private DateTime getTanggalPeminjaman()
        {
            DateTime tanggal = DateTime.MinValue;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getTanggalPeminjaman", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", dtTanggalPeminjaman.Value);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                tanggal = Convert.ToDateTime(result);
            }

            return tanggal;
        }

       
    }
}
