using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CRUDRuangan : Form
    {
        string idRuangan, namaFasilitas, namaJenisRuangan, namaRuangan, ketersediaanRuangan, lokasiRuangan;

        private void dgvTabelRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["idRuanganColumn"].Value);
                namaRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["namaRuanganColumn"].Value);
                namaFasilitas = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["namaFasilitasColumn"].Value);
                namaJenisRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["namaJenisRuanganColumn"].Value);
                ketersediaanRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["ketersediaanRuanganColumn"].Value);
                lokasiRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["lokasiRuanganColumn"].Value);
                UpdateRuangan updateRg = new UpdateRuangan(idRuangan, namaRuangan, namaFasilitas, namaJenisRuangan, ketersediaanRuangan, lokasiRuangan);
                updateRg.ShowDialog();
                getDataTabelRuangan();

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
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteRuangan", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idRuangan = Convert.ToString(dgvTabelRuangan.Rows[e.RowIndex].Cells["idRuanganColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idRuangan", idRuangan);

                        connection.Open();
                        int hasil = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                        connection.Close();

                        if (hasil != 0)
                        {
                            MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDataTabelRuangan();
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

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidRuangan.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataTabelRuangan();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetDataRuangan() WHERE idRuangan = @idRuangan AND [status] = 'Aktif'";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idRuangan", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelRuangan.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariidRuangan.Text = "";
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            getDataTabelRuangan();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputRuangan inputRuangan = new InputRuangan();
            inputRuangan.ShowDialog();

            getDataTabelRuangan();
        }

        public CRUDRuangan()
        {
            InitializeComponent();
        }

        private void CRUDRuangan_Load(object sender, EventArgs e)
        {
            getDataTabelRuangan();
        }

        private void getDataTabelRuangan()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetDataRuangan() WHERE status = 'Aktif'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        


    }
}
