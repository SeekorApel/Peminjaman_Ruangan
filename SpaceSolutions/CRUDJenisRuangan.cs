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
    public partial class CRUDJenisRuangan : Form
    {
        string idJenisRuangan, namaJenisRuangan, kapasitasRuangan;
        public CRUDJenisRuangan()
        {
            InitializeComponent();
        }

        public void CRUDJenisRuangan_Load(object sender, EventArgs e)
        {
            getDataTabelJenisRuangan();
        }

        public void getDataTabelJenisRuangan()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM JenisRuangan WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelJenisRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputJenisRuangan input = new InputJenisRuangan();
            input.ShowDialog();
            getDataTabelJenisRuangan();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            getDataTabelJenisRuangan();
            txtCariidJenisRuangan.Text = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidJenisRuangan.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataTabelJenisRuangan();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM JenisRuangan WHERE idJenisRuangan = @idJenisRuangan AND [status] = '1'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idJenisRuangan", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelJenisRuangan.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariidJenisRuangan.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgvTabelJenisRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idJenisRuangan = Convert.ToString(dgvTabelJenisRuangan.Rows[e.RowIndex].Cells["idJenisRuanganColumn"].Value);
                namaJenisRuangan = Convert.ToString(dgvTabelJenisRuangan.Rows[e.RowIndex].Cells["namaJenisRuanganColumn"].Value);
                kapasitasRuangan = Convert.ToString(dgvTabelJenisRuangan.Rows[e.RowIndex].Cells["kapasitasRuanganColumn"].Value);
                UpdateJenisRuangan updateJns = new UpdateJenisRuangan(idJenisRuangan, namaJenisRuangan, kapasitasRuangan);
                updateJns.ShowDialog();
                getDataTabelJenisRuangan();
            }
            if (e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection connection = new SqlConnection();
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteJenisRuangan", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idJenisRuangan = Convert.ToString(dgvTabelJenisRuangan.Rows[e.RowIndex].Cells["idJenisRuanganColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idJenisRuangan", idJenisRuangan);

                        connection.Open();
                        int hasil = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                        connection.Close();

                        if (hasil != 0)
                        {
                            MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDataTabelJenisRuangan();
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
    }
}
