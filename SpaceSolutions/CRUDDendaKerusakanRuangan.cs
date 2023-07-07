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
    public partial class CRUDDendaKerusakanRuangan : Form
    {
        string idDendaKerusakan, deskripsiKerusakan, biayaDenda;
        public CRUDDendaKerusakanRuangan()
        {
            InitializeComponent();
        }

        private void btnAddBarang_Click(object sender, EventArgs e)
        {
            InputDendaKerusakanRuangan inputRuangan = new InputDendaKerusakanRuangan();
            inputRuangan.Show();
        }

        private void CRUDDendaKerusakanRuangan_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM DendaKerusakanRuangan WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelDendaKerusakanRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidDendaKerusakanRuangan.Text.Trim();

            // Jika ID yang dicari kosong, reset tampilan DataGridView
            if (string.IsNullOrEmpty(idCari))
            {
                getData();
                return;
            }

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM DendaKerusakanRuangan WHERE idDendaKerusakanRuangan = @idDendaKerusakanRuangan AND [status] = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idDendaKerusakanRuangan", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelDendaKerusakanRuangan.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariidDendaKerusakanRuangan.Text = "";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            txtCariidDendaKerusakanRuangan.Text = "";
        }

        private void dgvTabelDendaKerusakanRuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idDendaKerusakan = Convert.ToString(dgvTabelDendaKerusakanRuangan.Rows[e.RowIndex].Cells["idDendaKerusakanRuanganColumn"].Value);
                deskripsiKerusakan = Convert.ToString(dgvTabelDendaKerusakanRuangan.Rows[e.RowIndex].Cells["deskripsiKerusakanColumn"].Value);
                biayaDenda = Convert.ToString(dgvTabelDendaKerusakanRuangan.Rows[e.RowIndex].Cells["biayaDendaColumn"].Value);
                UpdateDendaKerusakanRuangan updateDenda = new UpdateDendaKerusakanRuangan(idDendaKerusakan, deskripsiKerusakan, biayaDenda);
                updateDenda.ShowDialog();
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
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteDendaKerusakanRuangan", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idDendaKerusakan = Convert.ToString(dgvTabelDendaKerusakanRuangan.Rows[e.RowIndex].Cells["idDendaKerusakanRuanganColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idDendaKerusakanRuangan", idDendaKerusakan);

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
    }
}
