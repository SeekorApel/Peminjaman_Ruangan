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
    public partial class InputDendaKerusakanRuangan : Form
    {
        public InputDendaKerusakanRuangan()
        {
            InitializeComponent();
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

        private void inputDB()
        {
            int status = 1;
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                SqlCommand sqlcmd = new SqlCommand("sp_inputDendaKerusakanRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                string query = "SELECT TOP 1 idDendaKerusakanRuangan FROM DendaKerusakanRuangan ORDER BY idDendaKerusakanRuangan DESC";

                sqlcmd.Parameters.AddWithValue("@idDendaKerusakanRuangan", autogenerateID("DKR", query));
                sqlcmd.Parameters.AddWithValue("@deskripsiKerusakan", txtDeskripsiKerusakan.Text);
                sqlcmd.Parameters.AddWithValue("@biayaDenda", ToAngka(txtBiayaKerusakan.Text));
                sqlcmd.Parameters.AddWithValue("@status", status);


                connection.Open();
                int result = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Input data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Input data Gagal", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private String ToRupiah(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }

        private int ToAngka(string rupiah)
        {
            if (string.IsNullOrEmpty(rupiah))
            {
                return 0; // Mengembalikan nilai default (0) jika string kosong
            }

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDeskripsiKerusakan.Text == "" || txtBiayaKerusakan.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringantan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inputDB();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDeskripsiKerusakan.Text = "";
            txtBiayaKerusakan.Text = "";
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
    }

}
