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
    public partial class RiwayatPeminjamanRuangan : Form
    {
        string idUser;
        public RiwayatPeminjamanRuangan(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void RiwayatPeminjamanRuangan_Load(object sender, EventArgs e)
        {
            getDataPeminjamanRuanganByUser();
        }

        private void getDataPeminjamanRuanganByUser()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("GetDataPeminjamanRuanganByUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Menambahkan parameter dan nilainya ke dalam stored procedure
                cmd.Parameters.AddWithValue("@idUser", idUser);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvViewRiwayatPeminjamanRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex == 0)
            {
                filterBy(cbFilter.SelectedIndex.ToString());
            }
            else if(cbFilter.SelectedIndex == 1)
            {
                filterBy(cbFilter.SelectedIndex.ToString());

            }
            else if (cbFilter.SelectedIndex == 2)
            {
                filterBy(cbFilter.SelectedIndex.ToString());
            }
            else if (cbFilter.SelectedIndex == 3)
            {
                filterBy(cbFilter.SelectedIndex.ToString());
            }
        }

        private void filterBy(string status)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("FilterPeminjamanRuanganByStatus", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Menambahkan parameter dan nilainya ke dalam stored procedure
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@status", status);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvViewRiwayatPeminjamanRuangan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataPeminjamanRuanganByUser();
        }
    }
}
