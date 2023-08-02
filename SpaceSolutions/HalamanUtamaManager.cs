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
using System.Windows.Forms.DataVisualization.Charting;

namespace SpaceSolutions
{
    public partial class HalamanUtamaManager : Form
    {
        public HalamanUtamaManager()
        {
            InitializeComponent();
        }

        private void HalamanUtamaManager_Load(object sender, EventArgs e)
        {
            labelJumlahPengguna.Text = getJumlahUserAktif();
            labelJumlahBarang.Text = getJumlahBarang();
            labelJumlahRuangan.Text = getJumlahRuangan();     
        }

        private string getJumlahUserAktif()
        {
            string jumlahUser = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT COUNT(*) AS JumlahUser FROM [User] WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                jumlahUser = dt.Rows[0]["JumlahUser"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return jumlahUser;
        }

        private string getJumlahRuangan()
        {
            string jumlahRuangan = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT COUNT(*) AS JumlahRuangan FROM Ruangan WHERE status = 1";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                jumlahRuangan = dt.Rows[0]["JumlahRuangan"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return jumlahRuangan;
        }

        private string getJumlahBarang()
        {
            string jumlahBarang = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT COUNT(*) AS JumlahBarang FROM Barang WHERE status = 1;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                jumlahBarang = dt.Rows[0]["JumlahBarang"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return jumlahBarang;
        }

    }
}
