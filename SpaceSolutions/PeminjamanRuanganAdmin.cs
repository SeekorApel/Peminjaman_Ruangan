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
        public PeminjamanRuanganAdmin()
        {
            InitializeComponent();
        }

        private void PeminjamanRuanganAdmin_Load(object sender, EventArgs e)
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
                string query = "SELECT idPeminjamanRuangan, idUser, idRuangan, jenisKegiatan, kapasitasOrang, tanggalPeminjaman, lamaPeminjaman, statusPeminjaman FROM PeminjamanRuangan WHERE statusPeminjaman = 0";
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
                idRuangan = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom3"].Value);
                jenisKegiatan = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom4"].Value);
                kapasitasOrang = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom5"].Value);
                tanggalPeminjamanTemp = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom6"].Value);
                lamaPeminjaman = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom7"].Value);
                statusPeminjaman = Convert.ToString(dgvTabelPeminjaman.Rows[e.RowIndex].Cells["Kolom8"].Value);
                AccPeminjamanRuangan accPeminjaman = new AccPeminjamanRuangan(idPeminjaman, idUser, idRuangan, jenisKegiatan, kapasitasOrang, tanggalPeminjamanTemp, lamaPeminjaman, statusPeminjaman);
                accPeminjaman.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {

            }
        }     
    }
}
