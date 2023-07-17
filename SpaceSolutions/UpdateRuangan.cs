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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceSolutions
{
    public partial class UpdateRuangan : Form
    {
        string idRuanganTemp, namaRuanganTemp , idFasilitasTemp, idJenisRuanganTemp , ketersediaanRuanganTemp, lokasiRuanganTemp;

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

        private void txtNamaRuangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah alfabet atau spasi
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
            }
        }

        public UpdateRuangan(string idRuangan, string namaRuangan , string namaFasilitas , string namaJenisRuangan, string ketersediaanRuangan, string lokasiRuangan)
        {
            InitializeComponent();
            idRuanganTemp = idRuangan;
            namaRuanganTemp = namaRuangan;
            idFasilitasTemp = namaFasilitas;
            idJenisRuanganTemp = namaJenisRuangan;
            ketersediaanRuanganTemp = ketersediaanRuangan;
            lokasiRuanganTemp = lokasiRuangan;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDB();
        }

        private void UpdateRuangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSpaceSolutions.JenisRuangan' table. You can move, or remove it, as needed.
            this.jenisRuanganTableAdapter.Fill(this.dSSpaceSolutions.JenisRuangan);
            // TODO: This line of code loads data into the 'dSSpaceSolutions.Fasilitas' table. You can move, or remove it, as needed.
            this.fasilitasTableAdapter.Fill(this.dSSpaceSolutions.Fasilitas);
            txtNamaRuangan.Text = namaRuanganTemp;
            cbFasilitas.Text = idFasilitasTemp;
            cbJenisRuangan.Text = idJenisRuanganTemp;
            if (ketersediaanRuanganTemp == "Tersedia")
            {
                rbTersedia.Checked = true;

            }
            else if (ketersediaanRuanganTemp == "Tidak Tersedia")
            {
                rbTidakTersedia.Checked = true;
            }
            txtLokasiRuangan.Text = lokasiRuanganTemp;

        }

        private void updateDB()
        {
            try
            {
                int tersedia = 0;

                if (rbTersedia.Checked)
                {
                    tersedia = 1;

                }
                else if (rbTidakTersedia.Checked)
                {
                    tersedia = 0;
                }

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                SqlCommand sqlcmd = new SqlCommand("sp_updateRuangan", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@idRuangan", idRuanganTemp);
                sqlcmd.Parameters.AddWithValue("@idFasilitas", cbFasilitas.SelectedValue.ToString());
                sqlcmd.Parameters.AddWithValue("@idJenisRuangan", cbJenisRuangan.SelectedValue.ToString());
                sqlcmd.Parameters.AddWithValue("@namaRuangan", txtNamaRuangan.Text);
                sqlcmd.Parameters.AddWithValue("@ketersediaanRuangan", tersedia);
                sqlcmd.Parameters.AddWithValue("@lokasiRuangan", txtLokasiRuangan.Text);

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
