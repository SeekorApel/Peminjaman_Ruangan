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

namespace SpaceSolutions.Page
{
    public partial class formCRUDUser : Form
    {
        string idUser, nama, username, password, notelp, jabatan, role, status;
        public formCRUDUser()
        {
            InitializeComponent();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            CRUD.InputUser inputUser = new CRUD.InputUser();
            inputUser.Show();
        }

        private void formCRUDUser_Load(object sender, EventArgs e)
        {
           getData();
        }

        public static void displayAndSearch(String query , DataGridView dgv)
        {
            
        }

        private void dgvTabelUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //idUserCollumn dapet dari properties design Name di edit collumn
                idUser = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["idUserColumn"].Value);
                nama = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["namaColumn"].Value);
                username = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["usernameColumn"].Value);
                password = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["passwordColumn"].Value);
                notelp = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["noTelpColumn"].Value);
                jabatan = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["jabatanColumn"].Value);
                role = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["roleColumn"].Value);
                status = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["statusColumn"].Value);
                MessageBox.Show(role);
            }
            if(e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection();
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteUser", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idUser = Convert.ToString(dgvTabelUser.Rows[e.RowIndex].Cells["idUserColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idUser", idUser);

                        connection.Open();
                        int hasil = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                        connection.Close();

                        if (hasil != 0)
                        {
                            MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getData();
                        }
                        else
                        {
                            MessageBox.Show("Hapus data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
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
                string query = "SELECT * FROM [User] WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
