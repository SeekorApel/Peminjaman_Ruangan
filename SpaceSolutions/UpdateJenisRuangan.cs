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
    public partial class UpdateJenisRuangan : Form
    {
        string idJenisRuanganTemp, namaJenisRuanganTemp, kapasitasRuanganTemp;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNamaJenisRuangan.Text == "" || txtKapasitasRuangan.Text == "")
            {
                MessageBox.Show("Tidak Boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateDB();
            }
            
        }

        public UpdateJenisRuangan(string idJenisRuangan, string namaJenisRuangan, string kapasitasRuangan)
        {
            InitializeComponent();
            idJenisRuanganTemp = idJenisRuangan;
            namaJenisRuanganTemp = namaJenisRuangan;
            kapasitasRuanganTemp = kapasitasRuangan;
        }

        private void txtNamaJenisRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtKapasitasRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void UpdateJenisRuangan_Load(object sender, EventArgs e)
        {
            txtNamaJenisRuangan.Text = namaJenisRuanganTemp;
            txtKapasitasRuangan.Text = kapasitasRuanganTemp;
        }

        private void updateDB()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_updateJenisRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@namaJenisRuangan", txtNamaJenisRuangan.Text);
                sqlcmd.Parameters.AddWithValue("@KapasitasRuangan", txtKapasitasRuangan.Text);
                sqlcmd.Parameters.AddWithValue("@idJenisRuangan", idJenisRuanganTemp);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Update Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
