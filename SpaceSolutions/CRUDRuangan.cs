﻿using Microsoft.VisualBasic.ApplicationServices;
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
        string idRuangan, namaFasilitas, namaJenisRuangan, namaRuangan, ketersediaanRuangan, lokasiRuangan, status;

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

            }
            if (e.ColumnIndex == 1)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        public CRUDRuangan()
        {
            InitializeComponent();
        }

        private void CRUDRuangan_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnAddRuangan_Click(object sender, EventArgs e)
        {
            InputRuangan inputRuangan = new InputRuangan();
            inputRuangan.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void getData()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM viewRuangan";
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