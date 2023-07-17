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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class UpdateBarang : Form
    {
        string idBarangtemp, namaBarangtemp,stocktemp, kategoriBarangtemp;
        

        private void UpdateBarang_Load(object sender, EventArgs e)
        {
            txtNamaBarang.Text = namaBarangtemp;
            txtKategoriBarang.Text = kategoriBarangtemp;
            txtStokBarang.Text = stocktemp;
        }

        
        public UpdateBarang(string idBarang, string namaBarang, string hargaBarang, string stokBarang)
        {
            InitializeComponent();
            idBarangtemp = idBarang;
            namaBarangtemp = namaBarang;
            kategoriBarangtemp = hargaBarang;
            stocktemp = stokBarang;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "" || txtKategoriBarang.Text == "" || txtStokBarang.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateTabelBarang();
            }
            
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

        private void txtKategoriBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtKategoriBarang_Leave(object sender, EventArgs e)
        {

        }

        private void txtKategoriBarang_TextChanged(object sender, EventArgs e)
        {

        }


        private void updateTabelBarang()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_updateBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;
  
                sqlcmd.Parameters.AddWithValue("@namaBarang", txtNamaBarang.Text);
                sqlcmd.Parameters.AddWithValue("@kategoriBarang", txtKategoriBarang.Text);
                sqlcmd.Parameters.AddWithValue("@stokBarang", txtStokBarang.Text);
                sqlcmd.Parameters.AddWithValue("@idBarang", idBarangtemp);


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
