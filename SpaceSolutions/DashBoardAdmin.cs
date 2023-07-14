using SpaceSolutions.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSolutions
{
    public partial class DashBoardAdmin : Form
    {
        private Form activeForm;
        private string idUsr, nama;
        public DashBoardAdmin(string idUser, string namaUser)
        {
            InitializeComponent();
            customedesign();
            idUsr = idUser;
            nama = namaUser;
        }

        private void DashBoardAdmin_Load(object sender, EventArgs e)
        {
            labelNama.Text = nama;

        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopAdmin.Controls.Add(childForm);
            this.panelDesktopAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customedesign()
        {
            panelSubMenuDenda.Visible = false;
            panelSubMenuPeminjaman.Visible = false;
            panelSubMenuPengembalian.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelSubMenuDenda.Visible == true)
                panelSubMenuDenda.Visible = false;
            if (panelSubMenuPeminjaman.Visible == true)
                panelSubMenuPeminjaman.Visible = false;
            if (panelSubMenuPengembalian.Visible == true)
                panelSubMenuPengembalian.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnKelolaRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDRuangan(), sender);
        }

        private void btnDenda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuDenda);
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPeminjaman);
        }

        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDUser(), sender);
        }

        private void btnKelolaBarang_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDBarang(), sender);
        }

        private void btnJenisRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDJenisRuangan(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm lgnForm = new LoginForm();
            this.Close();
            lgnForm.ShowDialog();
        }

        private void btnDendaKerusakanBarang_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDDendaKerusakanBarang(), sender);
        }

        private void btnDendaKerusakanRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDDendaKerusakanRuangan(), sender);
        }

        private void btnPengembalianRuangan_Click(object sender, EventArgs e)
        {

        }

        private void btnPengembalianBarang_Click(object sender, EventArgs e)
        {

        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPengembalian);
        }

        private void btnPeminjamanRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new PeminjamanRuanganAdmin(), sender);
        }

        private void btnPeminjamanBarang_Click(object sender, EventArgs e)
        {

        }

        private void btnFasilitas_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDFasilitas(), sender);
        }
    }
}
