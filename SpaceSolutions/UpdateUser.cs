﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class UpdateUser : Form
    {
        string idUsertemp, namatemp, usernametemp, originalUsername, passwordtemp, notelptemp, jabatantemp, roletemp;
        private bool isUsernameChanged = false;

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPassword.Text.Length >= 20 && e.KeyChar != '\b') // '\b' adalah karakter backspace
            {
                e.Handled = true; // Mencegah karakter ditambahkan jika batas maksimum telah tercapai
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (originalUsername == txtUsername.Text)
            {
                isUsernameChanged = false; // Tidak ada perubahan username
            }
            else
            {
                isUsernameChanged = true; // Terjadi perubahan username
            }
        }

        private void UpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            isUsernameChanged = false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Jika bukan huruf alfabet, angka, atau backspace ('\b'), batalkan input karakter
                e.Handled = true;
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah alfabet atau spasi
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtNoTelp.Text == "" || cbJabatan.Text == "" || cbRole.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isUsernameChanged)
                {
                    // Jika berubah, lakukan validasi seperti sebelumnya
                    string checkUsernameQuery = "SELECT COUNT(*) FROM [User] WHERE username = @username";
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                    {
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
                    }
                }

                updateDB();

                isUsernameChanged = false;
            }
        }

        public UpdateUser(string idUser, string nama, string username, string password, string notelp, string jabatan, string role)
        {
            InitializeComponent();
            idUsertemp = idUser;
            namatemp = nama;
            usernametemp = username;
            originalUsername = username;
            passwordtemp = password;
            notelptemp = notelp;
            jabatantemp = jabatan;
            roletemp = role;
            txtUsername.TextChanged += txtUsername_TextChanged;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            txtNama.Text = namatemp;
            txtUsername.Text = usernametemp;
            txtPassword.Text = passwordtemp;
            txtNoTelp.Text = notelptemp;
            cbJabatan.Text = jabatantemp;
            cbRole.Text = roletemp;
        }

        private void updateDB()
        {
            int role = 0;
            try
            {
                if (cbRole.SelectedItem.Equals("Admin"))
                {
                    role = 1;
                }
                else if (cbRole.SelectedItem.Equals("Manager"))
                {
                    role = 2;
                }
                else if (cbRole.SelectedItem.Equals("User"))
                {
                    role = 3;
                }

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                SqlCommand sqlcmd = new SqlCommand("sp_updateUser", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@idUser", idUsertemp);
                sqlcmd.Parameters.AddWithValue("@nama", txtNama.Text);
                sqlcmd.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlcmd.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlcmd.Parameters.AddWithValue("@noTelp", txtNoTelp.Text);
                sqlcmd.Parameters.AddWithValue("@jabatan", cbJabatan.Text);
                sqlcmd.Parameters.AddWithValue("@role", role);

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
                    MessageBox.Show("Update data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
