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
    public partial class DashBoardUser : Form
    {
        private Form activeForm;
        public string namaUser, idUser;
        public DashBoardUser(string nama, string id)
        {
            InitializeComponent();
            customedesign();
            namaUser = nama;
            idUser = id;
        }

        private void DashBoardUser_Load(object sender, EventArgs e)
        {
            labelNama.Text = namaUser;
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopUser.Controls.Add(childForm);
            this.panelDesktopUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customedesign()
        {
            panelSubMenuPeminjaman.Visible = false;
            panelSubMenuRiwayatPeminjaman.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelSubMenuPeminjaman.Visible == true)
                panelSubMenuPeminjaman.Visible = false;
            if (panelSubMenuRiwayatPeminjaman.Visible == true)
                panelSubMenuRiwayatPeminjaman.Visible = false;

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

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuPeminjaman);
        }

        private void btnPeminjamanRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new PeminjamanRuanganUser(idUser), sender);
        }

        private void btnPeminjamanBarang_Click(object sender, EventArgs e)
        {
            openChildForm(new PeminjamanBarangUser(idUser), sender);
        }

        private void btnRiwayatPengembalian_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRiwayatPeminjaman);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
