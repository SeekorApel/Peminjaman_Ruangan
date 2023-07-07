using System;
using System.Collections;
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
    public partial class UpdateDendaKerusakanBarang : Form
    {
        string idDendaKerusakanTemp, deskripsiKerusakanTemp, biayaDendaTemp;
        public UpdateDendaKerusakanBarang(string idDendaKerusakan, string deskripsiKerusakan, string biayaDenda)
        {
            InitializeComponent();
            idDendaKerusakanTemp = idDendaKerusakan;
            deskripsiKerusakanTemp = deskripsiKerusakan;
            biayaDendaTemp = biayaDenda;
        }

        private void UpdateDendaKerusakanBarang_Load(object sender, EventArgs e)
        {
            txtDeskripsiKerusakan.Text = deskripsiKerusakanTemp;
            txtBiayaKerusakan.Text = biayaDendaTemp;
            int uang = Int32.Parse(txtBiayaKerusakan.Text);
            txtBiayaKerusakan.Text = ToRupiah(uang);
        }

        private String ToRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeskripsiKerusakan.Text == "" || txtBiayaKerusakan.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateDB();
            }
        }

        private void txtBiayaKerusakan_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtBiayaKerusakan.Text, out int uang))
            {
                txtBiayaKerusakan.Text = ToRupiah(uang);
            }
        }

        private void txtDeskripsiKerusakan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Memeriksa jika tombol Enter ditekan
            {
                txtDeskripsiKerusakan.AppendText(Environment.NewLine); // Menambahkan baris baru
                e.Handled = true; // Menghentikan penanganan karakter
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBiayaKerusakan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private int ToAngka(string rupiah)
        {
            if (string.IsNullOrEmpty(rupiah))
            {
                return 0; // Mengembalikan nilai default (0) jika string kosong
            }

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void updateDB()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                SqlCommand sqlcmd = new SqlCommand("sp_updateDendaKerusakanBarang", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@deskripsiKerusakan", txtDeskripsiKerusakan.Text);
                sqlcmd.Parameters.AddWithValue("@biayaDenda", ToAngka(txtBiayaKerusakan.Text));
                sqlcmd.Parameters.AddWithValue("@idDendaKerusakanBarang", idDendaKerusakanTemp);


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
