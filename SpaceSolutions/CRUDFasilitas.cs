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
    public partial class CRUDFasilitas : Form
    {
        string idFasilitas, namaFasilitas;
        public CRUDFasilitas()
        {
            InitializeComponent();
        }

        private void CRUDFasilitas_Load(object sender, EventArgs e)
        {
            getDataTabelFasilitas();
        }

        private void getDataTabelFasilitas()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM Fasilitas WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelFasilitas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputFasilitas inputFasil = new InputFasilitas();
            inputFasil.ShowDialog();
            getDataTabelFasilitas();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            getDataTabelFasilitas();
            txtCariidFasilitas.Text = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidFasilitas.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getDataTabelFasilitas();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM Fasilitas WHERE idFasilitas = @IdFasilitas AND [status] = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idFasilitas", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelFasilitas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariidFasilitas.Text = "";
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

        private void dgvTabelFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idFasilitas = Convert.ToString(dgvTabelFasilitas.Rows[e.RowIndex].Cells["idFasilitasColumn"].Value);
                namaFasilitas = Convert.ToString(dgvTabelFasilitas.Rows[e.RowIndex].Cells["namaFasilitasColumn"].Value);
                UpdateFasilitas updateFsl = new UpdateFasilitas(idFasilitas, namaFasilitas);
                updateFsl.ShowDialog();
                getDataTabelFasilitas();
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
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteFasilitas", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idFasilitas = Convert.ToString(dgvTabelFasilitas.Rows[e.RowIndex].Cells["idFasilitasColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@IdFasilitas", idFasilitas);

                        connection.Open();
                        int hasil = Convert.ToInt32(sqlcmd.ExecuteNonQuery());
                        connection.Close();

                        if (hasil != 0)
                        {
                            MessageBox.Show("Hapus Data Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDataTabelFasilitas();
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
