namespace SpaceSolutions
{
    partial class DashBoardAdmin
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
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelSubMenuPeminjaman = new System.Windows.Forms.Panel();
            this.btnPeminjaman = new System.Windows.Forms.Button();
            this.panelSubMenuDenda = new System.Windows.Forms.Panel();
            this.btnDendaKerusakanRuangan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDendaKerusakanBarang = new Guna.UI2.WinForms.Guna2Button();
            this.btnDenda = new System.Windows.Forms.Button();
            this.btnKelolaBarang = new System.Windows.Forms.Button();
            this.btnFasilitas = new System.Windows.Forms.Button();
            this.btnJenisRuangan = new System.Windows.Forms.Button();
            this.btnKelolaRuangan = new System.Windows.Forms.Button();
            this.btnKelolaUser = new System.Windows.Forms.Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDesktopAdmin = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPeminjamanRuangan = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeminjamanBarang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.panelSubMenuPeminjaman.SuspendLayout();
            this.panelSubMenuDenda.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(114)))), ((int)(((byte)(254)))));
            this.guna2Panel1.Controls.Add(this.btnLogOut);
            this.guna2Panel1.Controls.Add(this.panelSubMenuPeminjaman);
            this.guna2Panel1.Controls.Add(this.btnPeminjaman);
            this.guna2Panel1.Controls.Add(this.panelSubMenuDenda);
            this.guna2Panel1.Controls.Add(this.btnDenda);
            this.guna2Panel1.Controls.Add(this.btnKelolaBarang);
            this.guna2Panel1.Controls.Add(this.btnFasilitas);
            this.guna2Panel1.Controls.Add(this.btnJenisRuangan);
            this.guna2Panel1.Controls.Add(this.btnKelolaRuangan);
            this.guna2Panel1.Controls.Add(this.btnKelolaUser);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(290, 720);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Image = global::SpaceSolutions.Properties.Resources.Logout_btn;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1, 615);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(290, 50);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "      Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelSubMenuPeminjaman
            // 
            this.panelSubMenuPeminjaman.BackColor = System.Drawing.Color.White;
            this.panelSubMenuPeminjaman.Controls.Add(this.btnPeminjamanBarang);
            this.panelSubMenuPeminjaman.Controls.Add(this.btnPeminjamanRuangan);
            this.panelSubMenuPeminjaman.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPeminjaman.Location = new System.Drawing.Point(0, 582);
            this.panelSubMenuPeminjaman.Name = "panelSubMenuPeminjaman";
            this.panelSubMenuPeminjaman.Size = new System.Drawing.Size(290, 101);
            this.panelSubMenuPeminjaman.TabIndex = 9;
            // 
            // btnPeminjaman
            // 
            this.btnPeminjaman.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeminjaman.FlatAppearance.BorderSize = 0;
            this.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeminjaman.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjaman.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPeminjaman.Image = global::SpaceSolutions.Properties.Resources.barang_btn;
            this.btnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeminjaman.Location = new System.Drawing.Point(0, 532);
            this.btnPeminjaman.Name = "btnPeminjaman";
            this.btnPeminjaman.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPeminjaman.Size = new System.Drawing.Size(290, 50);
            this.btnPeminjaman.TabIndex = 8;
            this.btnPeminjaman.Text = "      Peminjaman";
            this.btnPeminjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeminjaman.UseVisualStyleBackColor = true;
            this.btnPeminjaman.Click += new System.EventHandler(this.btnPeminjaman_Click);
            // 
            // panelSubMenuDenda
            // 
            this.panelSubMenuDenda.BackColor = System.Drawing.Color.White;
            this.panelSubMenuDenda.Controls.Add(this.btnDendaKerusakanRuangan);
            this.panelSubMenuDenda.Controls.Add(this.btnDendaKerusakanBarang);
            this.panelSubMenuDenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuDenda.ForeColor = System.Drawing.Color.Black;
            this.panelSubMenuDenda.Location = new System.Drawing.Point(0, 430);
            this.panelSubMenuDenda.Name = "panelSubMenuDenda";
            this.panelSubMenuDenda.Size = new System.Drawing.Size(290, 102);
            this.panelSubMenuDenda.TabIndex = 7;
            // 
            // btnDendaKerusakanRuangan
            // 
            this.btnDendaKerusakanRuangan.CheckedState.Parent = this.btnDendaKerusakanRuangan;
            this.btnDendaKerusakanRuangan.CustomImages.Parent = this.btnDendaKerusakanRuangan;
            this.btnDendaKerusakanRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDendaKerusakanRuangan.FillColor = System.Drawing.Color.White;
            this.btnDendaKerusakanRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDendaKerusakanRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnDendaKerusakanRuangan.HoverState.Parent = this.btnDendaKerusakanRuangan;
            this.btnDendaKerusakanRuangan.Location = new System.Drawing.Point(0, 50);
            this.btnDendaKerusakanRuangan.Name = "btnDendaKerusakanRuangan";
            this.btnDendaKerusakanRuangan.ShadowDecoration.Parent = this.btnDendaKerusakanRuangan;
            this.btnDendaKerusakanRuangan.Size = new System.Drawing.Size(290, 50);
            this.btnDendaKerusakanRuangan.TabIndex = 1;
            this.btnDendaKerusakanRuangan.Text = "Denda Kerusakan Ruangan";
            this.btnDendaKerusakanRuangan.Click += new System.EventHandler(this.btnDendaKerusakanRuangan_Click);
            // 
            // btnDendaKerusakanBarang
            // 
            this.btnDendaKerusakanBarang.CheckedState.Parent = this.btnDendaKerusakanBarang;
            this.btnDendaKerusakanBarang.CustomImages.Parent = this.btnDendaKerusakanBarang;
            this.btnDendaKerusakanBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDendaKerusakanBarang.FillColor = System.Drawing.Color.White;
            this.btnDendaKerusakanBarang.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDendaKerusakanBarang.ForeColor = System.Drawing.Color.Black;
            this.btnDendaKerusakanBarang.HoverState.Parent = this.btnDendaKerusakanBarang;
            this.btnDendaKerusakanBarang.Location = new System.Drawing.Point(0, 0);
            this.btnDendaKerusakanBarang.Name = "btnDendaKerusakanBarang";
            this.btnDendaKerusakanBarang.ShadowDecoration.Parent = this.btnDendaKerusakanBarang;
            this.btnDendaKerusakanBarang.Size = new System.Drawing.Size(290, 50);
            this.btnDendaKerusakanBarang.TabIndex = 0;
            this.btnDendaKerusakanBarang.Text = "Denda Kerusakan Barang";
            this.btnDendaKerusakanBarang.Click += new System.EventHandler(this.btnDendaKerusakanBarang_Click);
            // 
            // btnDenda
            // 
            this.btnDenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDenda.FlatAppearance.BorderSize = 0;
            this.btnDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenda.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDenda.Image = global::SpaceSolutions.Properties.Resources.Denda_Kerusakan_Ruangan_btm;
            this.btnDenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDenda.Location = new System.Drawing.Point(0, 380);
            this.btnDenda.Name = "btnDenda";
            this.btnDenda.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDenda.Size = new System.Drawing.Size(290, 50);
            this.btnDenda.TabIndex = 6;
            this.btnDenda.Text = "      Denda";
            this.btnDenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDenda.UseVisualStyleBackColor = true;
            this.btnDenda.Click += new System.EventHandler(this.btnDenda_Click);
            // 
            // btnKelolaBarang
            // 
            this.btnKelolaBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKelolaBarang.FlatAppearance.BorderSize = 0;
            this.btnKelolaBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaBarang.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaBarang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKelolaBarang.Image = global::SpaceSolutions.Properties.Resources.barang_btn;
            this.btnKelolaBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelolaBarang.Location = new System.Drawing.Point(0, 330);
            this.btnKelolaBarang.Name = "btnKelolaBarang";
            this.btnKelolaBarang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKelolaBarang.Size = new System.Drawing.Size(290, 50);
            this.btnKelolaBarang.TabIndex = 5;
            this.btnKelolaBarang.Text = "      Kelola Barang";
            this.btnKelolaBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKelolaBarang.UseVisualStyleBackColor = true;
            this.btnKelolaBarang.Click += new System.EventHandler(this.btnKelolaBarang_Click);
            // 
            // btnFasilitas
            // 
            this.btnFasilitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFasilitas.FlatAppearance.BorderSize = 0;
            this.btnFasilitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFasilitas.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFasilitas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFasilitas.Image = global::SpaceSolutions.Properties.Resources.Fasilitas_btn;
            this.btnFasilitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFasilitas.Location = new System.Drawing.Point(0, 280);
            this.btnFasilitas.Name = "btnFasilitas";
            this.btnFasilitas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFasilitas.Size = new System.Drawing.Size(290, 50);
            this.btnFasilitas.TabIndex = 4;
            this.btnFasilitas.Text = "      Fasilitas";
            this.btnFasilitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFasilitas.UseVisualStyleBackColor = true;
            this.btnFasilitas.Click += new System.EventHandler(this.btnFasilitas_Click);
            // 
            // btnJenisRuangan
            // 
            this.btnJenisRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJenisRuangan.FlatAppearance.BorderSize = 0;
            this.btnJenisRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenisRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisRuangan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnJenisRuangan.Image = global::SpaceSolutions.Properties.Resources.Jenis_Ruangan_btn;
            this.btnJenisRuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJenisRuangan.Location = new System.Drawing.Point(0, 230);
            this.btnJenisRuangan.Name = "btnJenisRuangan";
            this.btnJenisRuangan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnJenisRuangan.Size = new System.Drawing.Size(290, 50);
            this.btnJenisRuangan.TabIndex = 3;
            this.btnJenisRuangan.Text = "     Jenis Ruangan";
            this.btnJenisRuangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJenisRuangan.UseVisualStyleBackColor = true;
            this.btnJenisRuangan.Click += new System.EventHandler(this.btnJenisRuangan_Click);
            // 
            // btnKelolaRuangan
            // 
            this.btnKelolaRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKelolaRuangan.FlatAppearance.BorderSize = 0;
            this.btnKelolaRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaRuangan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKelolaRuangan.Image = global::SpaceSolutions.Properties.Resources.Ruangan_btn;
            this.btnKelolaRuangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelolaRuangan.Location = new System.Drawing.Point(0, 180);
            this.btnKelolaRuangan.Name = "btnKelolaRuangan";
            this.btnKelolaRuangan.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKelolaRuangan.Size = new System.Drawing.Size(290, 50);
            this.btnKelolaRuangan.TabIndex = 2;
            this.btnKelolaRuangan.Text = "     Kelola Ruangan";
            this.btnKelolaRuangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKelolaRuangan.UseVisualStyleBackColor = true;
            this.btnKelolaRuangan.Click += new System.EventHandler(this.btnKelolaRuangan_Click);
            // 
            // btnKelolaUser
            // 
            this.btnKelolaUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKelolaUser.FlatAppearance.BorderSize = 0;
            this.btnKelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaUser.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKelolaUser.Image = global::SpaceSolutions.Properties.Resources.user_btn;
            this.btnKelolaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelolaUser.Location = new System.Drawing.Point(0, 130);
            this.btnKelolaUser.Name = "btnKelolaUser";
            this.btnKelolaUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKelolaUser.Size = new System.Drawing.Size(290, 50);
            this.btnKelolaUser.TabIndex = 1;
            this.btnKelolaUser.Text = "     Kelola User";
            this.btnKelolaUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelolaUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKelolaUser.UseVisualStyleBackColor = true;
            this.btnKelolaUser.Click += new System.EventHandler(this.btnKelolaUser_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(290, 130);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::SpaceSolutions.Properties.Resources.Logo___text;
            this.guna2PictureBox2.Location = new System.Drawing.Point(39, 42);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(205, 49);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(933, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Halo Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(808, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // panelDesktopAdmin
            // 
            this.panelDesktopAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktopAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopAdmin.Location = new System.Drawing.Point(290, 0);
            this.panelDesktopAdmin.Name = "panelDesktopAdmin";
            this.panelDesktopAdmin.Size = new System.Drawing.Size(990, 720);
            this.panelDesktopAdmin.TabIndex = 5;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Transparent;
            this.panelBar.Controls.Add(this.guna2ControlBox1);
            this.panelBar.Controls.Add(this.guna2PictureBox1);
            this.panelBar.Controls.Add(this.label2);
            this.panelBar.Controls.Add(this.label1);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(290, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(990, 130);
            this.panelBar.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SpaceSolutions.Properties.Resources.user__Black_;
            this.guna2PictureBox1.Location = new System.Drawing.Point(873, 62);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnPeminjamanRuangan
            // 
            this.btnPeminjamanRuangan.CheckedState.Parent = this.btnPeminjamanRuangan;
            this.btnPeminjamanRuangan.CustomImages.Parent = this.btnPeminjamanRuangan;
            this.btnPeminjamanRuangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeminjamanRuangan.FillColor = System.Drawing.Color.White;
            this.btnPeminjamanRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjamanRuangan.ForeColor = System.Drawing.Color.Black;
            this.btnPeminjamanRuangan.HoverState.Parent = this.btnPeminjamanRuangan;
            this.btnPeminjamanRuangan.Location = new System.Drawing.Point(0, 0);
            this.btnPeminjamanRuangan.Name = "btnPeminjamanRuangan";
            this.btnPeminjamanRuangan.ShadowDecoration.Parent = this.btnPeminjamanRuangan;
            this.btnPeminjamanRuangan.Size = new System.Drawing.Size(290, 50);
            this.btnPeminjamanRuangan.TabIndex = 0;
            this.btnPeminjamanRuangan.Text = "Peminjaman Ruangan";
            // 
            // btnPeminjamanBarang
            // 
            this.btnPeminjamanBarang.CheckedState.Parent = this.btnPeminjamanBarang;
            this.btnPeminjamanBarang.CustomImages.Parent = this.btnPeminjamanBarang;
            this.btnPeminjamanBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeminjamanBarang.FillColor = System.Drawing.Color.White;
            this.btnPeminjamanBarang.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeminjamanBarang.ForeColor = System.Drawing.Color.Black;
            this.btnPeminjamanBarang.HoverState.Parent = this.btnPeminjamanBarang;
            this.btnPeminjamanBarang.Location = new System.Drawing.Point(0, 50);
            this.btnPeminjamanBarang.Name = "btnPeminjamanBarang";
            this.btnPeminjamanBarang.ShadowDecoration.Parent = this.btnPeminjamanBarang;
            this.btnPeminjamanBarang.Size = new System.Drawing.Size(290, 50);
            this.btnPeminjamanBarang.TabIndex = 1;
            this.btnPeminjamanBarang.Text = "Peminjaman Barang";
            // 
            // DashBoardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelDesktopAdmin);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardAdmin";
            this.Load += new System.EventHandler(this.DashBoardAdmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelSubMenuPeminjaman.ResumeLayout(false);
            this.panelSubMenuDenda.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKelolaUser;
        private System.Windows.Forms.Button btnKelolaRuangan;
        private System.Windows.Forms.Button btnFasilitas;
        private System.Windows.Forms.Button btnJenisRuangan;
        private System.Windows.Forms.Button btnKelolaBarang;
        private System.Windows.Forms.Button btnDenda;
        private System.Windows.Forms.Panel panelSubMenuDenda;
        private System.Windows.Forms.Button btnPeminjaman;
        private System.Windows.Forms.Panel panelSubMenuPeminjaman;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelDesktopAdmin;
        private Guna.UI2.WinForms.Guna2Button btnDendaKerusakanRuangan;
        private Guna.UI2.WinForms.Guna2Button btnDendaKerusakanBarang;
        private Guna.UI2.WinForms.Guna2Button btnPeminjamanRuangan;
        private Guna.UI2.WinForms.Guna2Button btnPeminjamanBarang;
    }
}