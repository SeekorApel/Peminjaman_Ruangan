﻿using System;
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

        private void CRUDJenisRuangan_Load(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            txtCariidJenisRuangan.Text = "";
        }

        private void btnAddJenisRuangan_Click(object sender, EventArgs e)
        {
            InputJenisRuangan input = new InputJenisRuangan();
            input.Show();
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