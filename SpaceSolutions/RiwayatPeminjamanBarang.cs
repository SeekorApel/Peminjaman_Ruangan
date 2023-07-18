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
    public partial class RiwayatPeminjamanBarang : Form
    {
        string idUser;
        public RiwayatPeminjamanBarang(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void RiwayatPeminjamanBarang_Load(object sender, EventArgs e)
        {
            getDataPeminjamanBarangByUser();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getDataPeminjamanBarangByUser()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("GetPeminjamanBarangByUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Menambahkan parameter dan nilainya ke dalam stored procedure
                cmd.Parameters.AddWithValue("@idUser", idUser);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvViewRiwayatPeminjamanBarang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterBy(string status)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("FilterPeminjamanBarangByStatus", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Menambahkan parameter dan nilainya ke dalam stored procedure
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@status", status);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvViewRiwayatPeminjamanBarang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
