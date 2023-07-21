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
    public partial class DashBoardManager : Form
    {
        private Form activeForm;
        string idUser, namaUser;
        public DashBoardManager(string id, string nama)
        {
            InitializeComponent();
            customedesign();
            idUser = id;
            namaUser = nama;
        }

        private void DashBoardManager_Load(object sender, EventArgs e)
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
            this.panelDesktopManager.Controls.Add(childForm);
            this.panelDesktopManager.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customedesign()
        {
            panelSubMenuLaporan.Visible = false;
            
        }

        private void hidesubmenu()
        {
            if (panelSubMenuLaporan.Visible == true)
                panelSubMenuLaporan.Visible = false;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuLaporan);
        }

        private void btnLaporanRuangan_Click(object sender, EventArgs e)
        {
            openChildForm(new LaporanPeminjamanRuangan(), sender);
        }

        private void btnLaporanBarang_Click(object sender, EventArgs e)
        {
            openChildForm(new LaporanPeminjamanBarang(), sender);
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
    }
}
