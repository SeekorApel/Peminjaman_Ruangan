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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            inputDB();
        }

        private void inputDB()
        {
            int role = 3;
            int status = 1;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                // Periksa keberadaan username di dalam database
                string checkUsernameQuery = "SELECT COUNT(*) FROM [User] WHERE username = @username";
                SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connection);
                checkUsernameCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                connection.Open();
                int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                connection.Close();

                // Jika username sudah ada, tampilkan pesan kesalahan
                if (usernameCount > 0)
                {
                    MessageBox.Show("Username sudah digunakan. Harap masukkan username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hentikan proses penyimpanan
                }


                SqlCommand sqlcmd = new SqlCommand("sp_inputUser", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                string query = "SELECT TOP 1 idUser FROM [User] ORDER BY idUser DESC";

                sqlcmd.Parameters.AddWithValue("@idUser", autogenerateID("USR", query));
                sqlcmd.Parameters.AddWithValue("@nama", txtNama.Text);
                sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlcmd.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlcmd.Parameters.AddWithValue("@noTelp", txtNoTelp.Text);
                sqlcmd.Parameters.AddWithValue("@jabatan", cbJabatan.Text);
                sqlcmd.Parameters.AddWithValue("@role", role);
                sqlcmd.Parameters.AddWithValue("@status", status);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Sign Up Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign Up Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void clear()
        {
            txtNama.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNoTelp.Text = "";
            cbJabatan.Text = string.Empty;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek apakah karakter yang dimasukkan adalah huruf alfabet atau spasi
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                // Jika bukan huruf alfabet, spasi, atau backspace ('\b'), batalkan input karakter
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Jika bukan huruf alfabet atau backspace ('\b'), batalkan input karakter
                e.Handled = true;
            }
        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka atau kontrol (seperti backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }

            // Memeriksa apakah jumlah karakter telah mencapai batas maksimum
            if (txtNoTelp.Text.Length >= 13 && e.KeyChar != '\b') // '\b' adalah karakter backspace
            {
                e.Handled = true; // Mencegah karakter ditambahkan jika batas maksimum telah tercapai
            }
        }
    }
}
