namespace SpaceSolutions
{
    partial class DashBoardManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSubMenuLaporan = new System.Windows.Forms.Panel();
            this.btnLaporanBarang = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporanRuangan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.panelDesktopManager = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.panelSubMenuLaporan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(254)))));
            this.guna2Panel1.Controls.Add(this.panelSubMenuLaporan);
            this.guna2Panel1.Controls.Add(this.btnLaporan);
            this.guna2Panel1.Controls.Add(this.btnLogOut);
            this.guna2Panel1.Controls.Add(this.btnPeminjaman);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(290, 720);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panelSubMenuLaporan
            // 
            this.panelSubMenuLaporan.BackColor = System.Drawing.Color.White;
            this.panelSubMenuLaporan.Controls.Add(this.btnLaporanBarang);
            this.panelSubMenuLaporan.Controls.Add(this.btnLaporanRuangan);
            this.panelSubMenuLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuLaporan.Location = new System.Drawing.Point(0, 230);
            this.panelSubMenuLaporan.Name = "panelSubMenuLaporan";
            this.panelSubMenuLaporan.Size = new System.Drawing.Size(290, 156);
            this.panelSubMenuLaporan.TabIndex = 14;
            // 
            // btnLaporanBarang
            // 
            this.btnLaporanBarang.CheckedState.Parent = this.btnLaporanBarang;
            this.btnLaporanBarang.CustomImages.Parent = this.btnLaporanBarang;
            this.btnLaporanBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporanBarang.FillColor = System.Drawing.Color.White;
            this.btnLaporanBarang.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanBarang.ForeColor = System.Drawing.Color.Black;
            this.btnLaporanBarang.HoverState.Parent = this.btnLaporanBarang;
            this.btnLaporanBarang.Location = new System.Drawing.Point(0, 50);
            this.btnLaporanBarang.Name = "btnLaporanBarang";
            this.btnLaporanBarang.ShadowDecoration.Parent = this.btnLaporanBarang;
            this.btnLaporanBarang.Size = new System.Drawing.Size(290, 50);
            this.btnLaporanBarang.TabIndex = 5;
            this.btnLaporanBarang.Text = "Laporan Peminjaman Barang";
            this.btnLaporanBarang.Click += new System.EventHandler(this.btnLaporanBarang_Click);
            // 
            // btnLaporanRuangan
            // 
            this.btnLaporanRuangan.CheckedState.Parent = this.btnLaporanRuangan;
            this.btnLaporanRuangan.CustomImages.Parent = this.btnLaporanRuangan;
            this.btnLaporanRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporanRuangan.FillColor = System.Drawing.Color.White;
            this.btnLaporanRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnLaporanRuangan.HoverState.Parent = this.btnLaporanRuangan;
            this.btnLaporanRuangan.Location = new System.Drawing.Point(0, 0);
            this.btnLaporanRuangan.Name = "btnLaporanRuangan";
            this.btnLaporanRuangan.ShadowDecoration.Parent = this.btnLaporanRuangan;
            this.btnLaporanRuangan.Size = new System.Drawing.Size(290, 50);
            this.btnLaporanRuangan.TabIndex = 4;
            this.btnLaporanRuangan.Text = "Laporan Peminjaman Ruangan";
            this.btnLaporanRuangan.Click += new System.EventHandler(this.btnLaporanRuangan_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLaporan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLaporan.Image = global::SpaceSolutions.Properties.Resources.Riwayat;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 180);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLaporan.Size = new System.Drawing.Size(290, 50);
            this.btnLaporan.TabIndex = 13;
            this.btnLaporan.Text = "         Laporan";
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Image = global::SpaceSolutions.Properties.Resources.Logout_btn;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 596);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(290, 50);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "      Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeminjaman.FlatAppearance.BorderSize = 0;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPeminjaman.Image = global::SpaceSolutions.Properties.Resources.Peminjaman_USER;
            this.btnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeminjaman.Location = new System.Drawing.Point(0, 130);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPeminjaman.Size = new System.Drawing.Size(290, 50);
            this.btnPeminjaman.TabIndex = 9;
            this.btnPeminjaman.Text = "     Halaman Utama";
            this.btnPeminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 130);
            this.panel1.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::SpaceSolutions.Properties.Resources.Logo___text;
            this.guna2PictureBox2.Location = new System.Drawing.Point(50, 42);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(190, 45);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 4;
            this.guna2PictureBox2.TabStop = false;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Transparent;
            this.panelBar.Controls.Add(this.btnClose);
            this.panelBar.Controls.Add(this.guna2ControlBox1);
            this.panelBar.Controls.Add(this.guna2PictureBox1);
            this.panelBar.Controls.Add(this.label2);
            this.panelBar.Controls.Add(this.labelNama);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(290, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(990, 130);
            this.panelBar.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(933, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 13;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1026, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SpaceSolutions.Properties.Resources.user__Black_;
            this.guna2PictureBox1.Location = new System.Drawing.Point(774, 53);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(829, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manager";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(829, 55);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(18, 23);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "-";
            // 
            // panelDesktopManager
            // 
            this.panelDesktopManager.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktopManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopManager.Location = new System.Drawing.Point(290, 130);
            this.panelDesktopManager.Name = "panelDesktopManager";
            this.panelDesktopManager.Size = new System.Drawing.Size(990, 590);
            this.panelDesktopManager.TabIndex = 10;
            // 
            // DashBoardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDesktopManager);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardManager";
            this.Load += new System.EventHandler(this.DashBoardManager_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelSubMenuLaporan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Panel panelBar;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Panel panelSubMenuLaporan;
        private Guna.UI2.WinForms.Guna2Button btnLaporanBarang;
        private Guna.UI2.WinForms.Guna2Button btnLaporanRuangan;
        private System.Windows.Forms.Panel panelDesktopManager;
    }
}