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
    public partial class InputRuangan : Form
    {
        public InputRuangan()
        {
            InitializeComponent();
            
        }

        private void InputRuangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.JenisRuangan' table. You can move, or remove it, as needed.
            this.jenisRuanganTableAdapter.Fill(this.dSSpaceSolutions.JenisRuangan);
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Fasilitas' table. You can move, or remove it, as needed.
            this.fasilitasTableAdapter.Fill(this.dSSpaceSolutions.Fasilitas);
            cbFasilitas.SelectedIndex = -1;
            cbJenisRuangan.SelectedIndex = -1;
            queryFasilitasToolStrip.Visible = false;
            queryJenisRuanganToolStrip.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNamaRuangan.Text == "" || cbFasilitas.SelectedIndex == -1 || cbJenisRuangan.SelectedIndex == -1 || (rbTersedia.Checked == false && rbTidakTersedia.Checked == false) || txtLokasiRuangan.Text == "")
            {
                MessageBox.Show("Tidak boleh ada field yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inputDB();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNamaRuangan.Text = "";
            cbFasilitas.SelectedIndex = -1;
            cbJenisRuangan.SelectedIndex = -1;
            rbTersedia.Checked = false;
            rbTidakTersedia.Checked = false;
            txtLokasiRuangan.Text = "";
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
            int tersedia = 0;

            if (rbTersedia.Checked)
            {
                tersedia = 1;

            }else if (rbTidakTersedia.Checked)
            {
                tersedia = 0;
            }

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                SqlCommand sqlcmd = new SqlCommand("sp_inputRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                string query = "SELECT TOP 1 idRuangan FROM Ruangan ORDER BY idRuangan DESC";

                sqlcmd.Parameters.AddWithValue("@idRuangan", autogenerateID("RG", query));
                sqlcmd.Parameters.AddWithValue("@idFasilitas", cbFasilitas.SelectedValue.ToString());
                sqlcmd.Parameters.AddWithValue("@idJenisRuangan", cbJenisRuangan.SelectedValue.ToString());
                sqlcmd.Parameters.AddWithValue("@namaRuangan", txtNamaRuangan.Text);
                sqlcmd.Parameters.AddWithValue("@ketersediaanRuangan", tersedia);
                sqlcmd.Parameters.AddWithValue("@lokasiRuangan", txtLokasiRuangan.Text);
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

        private void txtNamaRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah alfabet atau spasi
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }
        }

        private void txtLokasiRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mendapatkan karakter yang sedang ditekan
            char keyPressed = e.KeyChar;

            // Memeriksa apakah karakter adalah huruf, angka, atau spasi
            if (!char.IsLetterOrDigit(keyPressed) && !char.IsWhiteSpace(keyPressed) && !char.IsControl(keyPressed))
            {
                // Jika karakter bukan huruf, angka, atau spasi, hentikan event KeyPress
                e.Handled = true;
            }
        }

        private void queryJenisRuanganToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jenisRuanganTableAdapter.QueryJenisRuangan(this.dSSpaceSolutions.JenisRuangan);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void queryFasilitasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fasilitasTableAdapter.QueryFasilitas(this.dSSpaceSolutions.Fasilitas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
