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
    public partial class PeminjamanRuanganAdmin : Form
    {
        string idPeminjaman, idUser, idRuangan, jenisKegiatan, kapasitasOrang, tanggalPeminjamanTemp,lamaPeminjaman, statusPeminjaman;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataTabelPeminjamanRuangan();
        }

        public PeminjamanRuanganAdmin()
        {
            InitializeComponent();
        }

        private void PeminjamanRuanganAdmin_Load(object sender, EventArgs e)
        {
            getDataTabelPeminjamanRuangan();

        }

        private void getDataTabelPeminjamanRuangan()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.Open();
            try
            {
                string query = "SELECT * FROM GetPeminjamanRuangan() WHERE statusPeminjaman = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvTabelPeminjaman.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTabelPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                idPeminjaman = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom1"].Value);
                idUser = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom2"].Value);
                idRuangan = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom4"].Value);
                jenisKegiatan = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom6"].Value);
                kapasitasOrang = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom7"].Value);
                tanggalPeminjamanTemp = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom8"].Value);
                lamaPeminjaman = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom9"].Value);
                statusPeminjaman = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom10"].Value);
                AccPeminjamanRuangan accPeminjaman = new AccPeminjamanRuangan(idPeminjaman, idUser, idRuangan, jenisKegiatan, kapasitasOrang, tanggalPeminjamanTemp, lamaPeminjaman, statusPeminjaman);
                accPeminjaman.ShowDialog();
                getDataTabelPeminjamanRuangan();
            }
            if(e.ColumnIndex == 1)
            {

            }
        }     
    }
}
