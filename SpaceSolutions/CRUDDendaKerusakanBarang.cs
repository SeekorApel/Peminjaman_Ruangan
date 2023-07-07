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
    public partial class CRUDDendaKerusakanBarang : Form
    {
        string idDendaKerusakan, deskripsiKerusakan, biayaDenda;
        public CRUDDendaKerusakanBarang()
        {
            InitializeComponent();
        }

        private void btnAddBarang_Click(object sender, EventArgs e)
        {
            InputDendaKerusakanBarang inputDenda = new InputDendaKerusakanBarang();
            inputDenda.Show();
        }

        private void CRUDDendaKerusakanBarang_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            txtCariidDendaKerusakanBarang.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idCari = txtCariidDendaKerusakanBarang.Text.Trim();

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
                string query = "SELECT * FROM DendaKerusakanBarang WHERE idDendaKerusakanBarang = @idDendaKerusakanBarang AND [status] = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idDendaKerusakanBarang", idCari);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    dgvTabelDendaKerusakanBarang.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCariidDendaKerusakanBarang.Text = "";
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

        private void getData()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM DendaKerusakanBarang WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelDendaKerusakanBarang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTabelDendaKerusakanBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idDendaKerusakan = Convert.ToString(dgvTabelDendaKerusakanBarang.Rows[e.RowIndex].Cells["idDendaKerusakanBarangColumn"].Value);
                deskripsiKerusakan = Convert.ToString(dgvTabelDendaKerusakanBarang.Rows[e.RowIndex].Cells["deskripsiKerusakanColumn"].Value);
                biayaDenda = Convert.ToString(dgvTabelDendaKerusakanBarang.Rows[e.RowIndex].Cells["biayaDendaColumn"].Value);
                UpdateDendaKerusakanBarang updateDenda = new UpdateDendaKerusakanBarang(idDendaKerusakan, deskripsiKerusakan, biayaDenda);
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
                        SqlCommand sqlcmd = new SqlCommand("sp_deleteDendaKerusakanBarang", connection);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        idDendaKerusakan = Convert.ToString(dgvTabelDendaKerusakanBarang.Rows[e.RowIndex].Cells["idDendaKerusakanBarangColumn"].Value);

                        sqlcmd.Parameters.AddWithValue("@idDendaKerusakanBarang", idDendaKerusakan);

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
