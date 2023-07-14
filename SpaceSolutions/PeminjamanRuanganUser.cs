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
    public partial class PeminjamanRuanganUser : Form
    {
        string idUser;
        public PeminjamanRuanganUser(string idUserTemp)
        { 
            InitializeComponent();
            idUser = idUserTemp;
        }

        private void PeminjamanRuanganUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Ruangan' table. You can move, or remove it, as needed.
            this.ruanganTableAdapter.Query1(this.dSSpaceSolutions.Ruangan);
            getData();
            query1ToolStrip.Visible = false;
            label6.Text = idUser;

        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (cbIdRuangan.SelectedIndex == -1 || txtJenisKegitan.Text == "" || txtKapasitasOrang.Text == "" || txtLamaPeminjaman.Text == "")
            {
                MessageBox.Show("Semua data harus di isi semua", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inputDB();
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

        private int getKapasitasDB()
        {
            int kapasitas = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getKapasitasRuangan", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", cbIdRuangan.SelectedValue.ToString());

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            kapasitas = (int)result;
            return kapasitas;
        }

        private int getKetersediaanRuanganDB()
        {
            int status = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getketersediaanRuangan", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", cbIdRuangan.SelectedValue.ToString());

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            status = (int)result;
            return status;
        }

        private DateTime getTanggalPeminjamanDB()
        {
            int status = 0;
            DateTime tanggal = DateTime.MinValue;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getTanggalPeminjaman", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@idRuangan", cbIdRuangan.SelectedValue.ToString());
            sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", dtTanggalPeminjaman.Value);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                tanggal = Convert.ToDateTime(result);
            }

            return tanggal;
        }


        private void inputDB()
        {
            string convertKapasitasRuangan = txtKapasitasOrang.Text;
            int kapasitasForm = int.Parse(convertKapasitasRuangan);
            int kapasitasDB = 0;
            kapasitasDB = getKapasitasDB();
            int ketersediaanRuanganDB = getKetersediaanRuanganDB();
            DateTime tanggalDB = getTanggalPeminjamanDB();
            DateTime tanggalForm = dtTanggalPeminjaman.Value;
   

            if (kapasitasForm > kapasitasDB)
            {
                MessageBox.Show("Kapasitas Ruangan tidak mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }else if (ketersediaanRuanganDB == 0)
            {
                MessageBox.Show("Maaf Ruangan tidak Tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                try
                {
                    int status = 0;
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                    SqlCommand sqlcmd = new SqlCommand("sp_inputPeminjamanRuangan", connection);
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    string query = "SELECT TOP 1 idPeminjamanRuangan FROM PeminjamanRuangan ORDER BY idPeminjamanRuangan DESC";

                    sqlcmd.Parameters.AddWithValue("@idPeminjamanRuangan", autogenerateID("PR", query));
                    sqlcmd.Parameters.AddWithValue("@idUser", idUser);
                    sqlcmd.Parameters.AddWithValue("@idRuangan", cbIdRuangan.SelectedValue.ToString());
                    sqlcmd.Parameters.AddWithValue("@jenisKegiatan", txtJenisKegitan.Text);
                    sqlcmd.Parameters.AddWithValue("@kapasitasOrang", txtKapasitasOrang.Text);
                    sqlcmd.Parameters.AddWithValue("@tanggalPeminjaman", dtTanggalPeminjaman.Value);
                    sqlcmd.Parameters.AddWithValue("@lamaPeminjaman", txtLamaPeminjaman.Text);
                    sqlcmd.Parameters.AddWithValue("@statusPeminjaman", status);


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

        private void getData()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetDataRuangan() WHERE ketersediaanRuangan = 'Tersedia' AND  [status] = 'Aktif'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void query1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruanganTableAdapter.Query1(this.dSSpaceSolutions.Ruangan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dtTanggalPeminjaman_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
