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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void chkLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLihatPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Password/Username tidak boleh kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loginDB();
            }
        }

        private void loginDB()
        {
            //Nampung Hasil Return SP di database
            int returnValue = 0;

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_checkLogin", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text);
            sqlcmd.Parameters.AddWithValue("@password", txtPassword.Text);

            connection.Open();

            object result = sqlcmd.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                returnValue = (int)result;

                if (returnValue == 1)
                {
                    string idUser = getIdUser();
                    string namaUser = getNamaUser();
                    MessageBox.Show("Selamat Datang Admin!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoardAdmin formAdmin = new DashBoardAdmin(idUser, namaUser);
                    this.Hide();
                    formAdmin.Show();
                }
                else if (returnValue == 2)
                {
                    string idUser = getIdUser();
                    string namaUser = getNamaUser();
                    MessageBox.Show("Selamat Datang Manager!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoardManager manager = new DashBoardManager(idUser, namaUser);
                    this.Hide();
                    manager.Show();
                }
                else if (returnValue == 3)
                {
                    string idUser = getIdUser();
                    string namaUser = getNamaUser();
                    MessageBox.Show("Selamat Datang User!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DashBoardUser user = new DashBoardUser(namaUser, idUser);
                    this.Hide();
                    user.Show();
                }

            }
            else
            {
                MessageBox.Show("Password/Username Salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp sg = new SignUp();
            sg.Show();
        }

        private string getIdUser()
        {
            string idUser = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getIduser", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            idUser = (string)result;

            return idUser;
        }

        private string getNamaUser()
        {
            string nama = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            SqlCommand sqlcmd = new SqlCommand("sp_getNamaUser", connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text);

            connection.Open();
            object result = sqlcmd.ExecuteScalar();
            nama = (string)result;

            return nama;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Jika bukan huruf alfabet, angka, atau backspace ('\b'), batalkan input karakter
                e.Handled = true;
            }
        }
    }
}
