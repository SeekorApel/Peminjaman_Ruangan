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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSolutions
{
    public partial class InputBarang : Form
    {
        public InputBarang()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "" || txtKategoriBarang.Text == "" || txtStokBarang.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               inputTabelBarang();
            }
            
        }

        private void inputTabelBarang()
        {
            int status = 1;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_inputBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                string query = "SELECT TOP 1 IdBarang FROM Barang ORDER BY IdBarang DESC";

                sqlcmd.Parameters.AddWithValue("@idBarang", autogenerateID("BRG", query));
                sqlcmd.Parameters.AddWithValue("@namaBarang", txtNamaBarang.Text);
                sqlcmd.Parameters.AddWithValue("@kategoriBarang", (txtKategoriBarang.Text));
                sqlcmd.Parameters.AddWithValue("@stokBarang", txtStokBarang.Text);
                sqlcmd.Parameters.AddWithValue("@status", status);


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


        private void txtNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtStokBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNamaBarang.Text = "";
            txtKategoriBarang.Text = "";
            txtStokBarang.Text = "";
        }

        private void txtKategoriBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek apakah karakter yang dimasukkan adalah huruf atau spasi
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                // Jika bukan, maka batalkan input dengan menandai event sebagai sudah ditangani (Handled)
                e.Handled = true;
            }
        }

        private void txtKategoriBarang_Leave(object sender, EventArgs e)
        {

        }
    }
}
