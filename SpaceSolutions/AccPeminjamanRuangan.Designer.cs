namespace SpaceSolutions
{
    partial class AccPeminjamanRuangan
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetujui = new Guna.UI2.WinForms.Guna2Button();
            this.txtKapasitasOrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLamaPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenisKegitan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTolakPeminjaman = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamaRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbSetujuiPeminjaman = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbTolakPeminjaman = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlasanPenolakan = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAlasan = new System.Windows.Forms.Label();
            this.labelBintang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tanggal Peminjaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Lama Peminjaman (Hari)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kapasitas Orang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Jenis Kegiatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ruangan";
            // 
            // btnSetujui
            // 
            this.btnSetujui.BorderRadius = 4;
            this.btnSetujui.CheckedState.Parent = this.btnSetujui;
            this.btnSetujui.CustomImages.Parent = this.btnSetujui;
            this.btnSetujui.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSetujui.ForeColor = System.Drawing.Color.White;
            this.btnSetujui.HoverState.Parent = this.btnSetujui;
            this.btnSetujui.Location = new System.Drawing.Point(435, 268);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.ShadowDecoration.Parent = this.btnSetujui;
            this.btnSetujui.Size = new System.Drawing.Size(145, 36);
            this.btnSetujui.TabIndex = 33;
            this.btnSetujui.Text = "Setujui Peminjaman";
            this.btnSetujui.Visible = false;
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            // 
            // txtKapasitasOrang
            // 
            this.txtKapasitasOrang.BorderRadius = 4;
            this.txtKapasitasOrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKapasitasOrang.DefaultText = "";
            this.txtKapasitasOrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKapasitasOrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKapasitasOrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKapasitasOrang.DisabledState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKapasitasOrang.Enabled = false;
            this.txtKapasitasOrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.FocusedState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.HoverState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Location = new System.Drawing.Point(129, 328);
            this.txtKapasitasOrang.Name = "txtKapasitasOrang";
            this.txtKapasitasOrang.PasswordChar = '\0';
            this.txtKapasitasOrang.PlaceholderText = "";
            this.txtKapasitasOrang.SelectedText = "";
            this.txtKapasitasOrang.ShadowDecoration.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Size = new System.Drawing.Size(220, 36);
            this.txtKapasitasOrang.TabIndex = 32;
            // 
            // dtTanggalPeminjaman
            // 
            this.dtTanggalPeminjaman.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtTanggalPeminjaman.BorderRadius = 4;
            this.dtTanggalPeminjaman.BorderThickness = 1;
            this.dtTanggalPeminjaman.CheckedState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Enabled = false;
            this.dtTanggalPeminjaman.FillColor = System.Drawing.Color.White;
            this.dtTanggalPeminjaman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTanggalPeminjaman.HoverState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(434, 83);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPeminjaman.TabIndex = 31;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            // 
            // txtLamaPeminjaman
            // 
            this.txtLamaPeminjaman.BorderRadius = 4;
            this.txtLamaPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLamaPeminjaman.DefaultText = "";
            this.txtLamaPeminjaman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLamaPeminjaman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLamaPeminjaman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLamaPeminjaman.DisabledState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLamaPeminjaman.Enabled = false;
            this.txtLamaPeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.FocusedState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.HoverState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Location = new System.Drawing.Point(435, 169);
            this.txtLamaPeminjaman.Name = "txtLamaPeminjaman";
            this.txtLamaPeminjaman.PasswordChar = '\0';
            this.txtLamaPeminjaman.PlaceholderText = "";
            this.txtLamaPeminjaman.SelectedText = "";
            this.txtLamaPeminjaman.ShadowDecoration.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Size = new System.Drawing.Size(220, 36);
            this.txtLamaPeminjaman.TabIndex = 30;
            // 
            // txtJenisKegitan
            // 
            this.txtJenisKegitan.BorderRadius = 4;
            this.txtJenisKegitan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenisKegitan.DefaultText = "";
            this.txtJenisKegitan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJenisKegitan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJenisKegitan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenisKegitan.DisabledState.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenisKegitan.Enabled = false;
            this.txtJenisKegitan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegitan.FocusedState.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegitan.HoverState.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.Location = new System.Drawing.Point(129, 245);
            this.txtJenisKegitan.Name = "txtJenisKegitan";
            this.txtJenisKegitan.PasswordChar = '\0';
            this.txtJenisKegitan.PlaceholderText = "";
            this.txtJenisKegitan.SelectedText = "";
            this.txtJenisKegitan.ShadowDecoration.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.Size = new System.Drawing.Size(220, 36);
            this.txtJenisKegitan.TabIndex = 29;
            // 
            // btnTolakPeminjaman
            // 
            this.btnTolakPeminjaman.BorderRadius = 4;
            this.btnTolakPeminjaman.CheckedState.Parent = this.btnTolakPeminjaman;
            this.btnTolakPeminjaman.CustomImages.Parent = this.btnTolakPeminjaman;
            this.btnTolakPeminjaman.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTolakPeminjaman.ForeColor = System.Drawing.Color.White;
            this.btnTolakPeminjaman.HoverState.Parent = this.btnTolakPeminjaman;
            this.btnTolakPeminjaman.Location = new System.Drawing.Point(435, 406);
            this.btnTolakPeminjaman.Name = "btnTolakPeminjaman";
            this.btnTolakPeminjaman.ShadowDecoration.Parent = this.btnTolakPeminjaman;
            this.btnTolakPeminjaman.Size = new System.Drawing.Size(145, 36);
            this.btnTolakPeminjaman.TabIndex = 39;
            this.btnTolakPeminjaman.Text = "Tolak Peminjaman";
            this.btnTolakPeminjaman.Visible = false;
            this.btnTolakPeminjaman.Click += new System.EventHandler(this.btnTolakPeminjaman_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nama Peminjam";
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.BorderRadius = 4;
            this.txtNamaUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaUser.DefaultText = "";
            this.txtNamaUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaUser.DisabledState.Parent = this.txtNamaUser;
            this.txtNamaUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaUser.Enabled = false;
            this.txtNamaUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaUser.FocusedState.Parent = this.txtNamaUser;
            this.txtNamaUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaUser.HoverState.Parent = this.txtNamaUser;
            this.txtNamaUser.Location = new System.Drawing.Point(129, 83);
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.PasswordChar = '\0';
            this.txtNamaUser.PlaceholderText = "";
            this.txtNamaUser.SelectedText = "";
            this.txtNamaUser.ShadowDecoration.Parent = this.txtNamaUser;
            this.txtNamaUser.Size = new System.Drawing.Size(220, 36);
            this.txtNamaUser.TabIndex = 40;
            // 
            // txtNamaRuangan
            // 
            this.txtNamaRuangan.BorderRadius = 4;
            this.txtNamaRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaRuangan.DefaultText = "";
            this.txtNamaRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaRuangan.DisabledState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaRuangan.Enabled = false;
            this.txtNamaRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaRuangan.FocusedState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaRuangan.HoverState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.Location = new System.Drawing.Point(129, 164);
            this.txtNamaRuangan.Name = "txtNamaRuangan";
            this.txtNamaRuangan.PasswordChar = '\0';
            this.txtNamaRuangan.PlaceholderText = "";
            this.txtNamaRuangan.SelectedText = "";
            this.txtNamaRuangan.ShadowDecoration.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.Size = new System.Drawing.Size(220, 36);
            this.txtNamaRuangan.TabIndex = 42;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // cbSetujuiPeminjaman
            // 
            this.cbSetujuiPeminjaman.AutoSize = true;
            this.cbSetujuiPeminjaman.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSetujuiPeminjaman.CheckedState.BorderRadius = 2;
            this.cbSetujuiPeminjaman.CheckedState.BorderThickness = 0;
            this.cbSetujuiPeminjaman.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSetujuiPeminjaman.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.cbSetujuiPeminjaman.Location = new System.Drawing.Point(435, 228);
            this.cbSetujuiPeminjaman.Name = "cbSetujuiPeminjaman";
            this.cbSetujuiPeminjaman.Size = new System.Drawing.Size(15, 14);
            this.cbSetujuiPeminjaman.TabIndex = 43;
            this.cbSetujuiPeminjaman.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSetujuiPeminjaman.UncheckedState.BorderRadius = 2;
            this.cbSetujuiPeminjaman.UncheckedState.BorderThickness = 0;
            this.cbSetujuiPeminjaman.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSetujuiPeminjaman.UseVisualStyleBackColor = true;
            this.cbSetujuiPeminjaman.CheckedChanged += new System.EventHandler(this.cbSetujuiPeminjaman_CheckedChanged);
            // 
            // cbTolakPeminjaman
            // 
            this.cbTolakPeminjaman.AutoSize = true;
            this.cbTolakPeminjaman.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTolakPeminjaman.CheckedState.BorderRadius = 2;
            this.cbTolakPeminjaman.CheckedState.BorderThickness = 0;
            this.cbTolakPeminjaman.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTolakPeminjaman.Location = new System.Drawing.Point(541, 228);
            this.cbTolakPeminjaman.Name = "cbTolakPeminjaman";
            this.cbTolakPeminjaman.Size = new System.Drawing.Size(15, 14);
            this.cbTolakPeminjaman.TabIndex = 44;
            this.cbTolakPeminjaman.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbTolakPeminjaman.UncheckedState.BorderRadius = 2;
            this.cbTolakPeminjaman.UncheckedState.BorderThickness = 0;
            this.cbTolakPeminjaman.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbTolakPeminjaman.UseVisualStyleBackColor = true;
            this.cbTolakPeminjaman.CheckedChanged += new System.EventHandler(this.cbTolakPeminjaman_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "Setujui";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 26);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tolak";
            // 
            // txtAlasanPenolakan
            // 
            this.txtAlasanPenolakan.BorderRadius = 4;
            this.txtAlasanPenolakan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlasanPenolakan.DefaultText = "";
            this.txtAlasanPenolakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlasanPenolakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlasanPenolakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlasanPenolakan.DisabledState.Parent = this.txtAlasanPenolakan;
            this.txtAlasanPenolakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlasanPenolakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlasanPenolakan.FocusedState.Parent = this.txtAlasanPenolakan;
            this.txtAlasanPenolakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlasanPenolakan.HoverState.Parent = this.txtAlasanPenolakan;
            this.txtAlasanPenolakan.Location = new System.Drawing.Point(437, 286);
            this.txtAlasanPenolakan.Multiline = true;
            this.txtAlasanPenolakan.Name = "txtAlasanPenolakan";
            this.txtAlasanPenolakan.PasswordChar = '\0';
            this.txtAlasanPenolakan.PlaceholderText = "";
            this.txtAlasanPenolakan.SelectedText = "";
            this.txtAlasanPenolakan.ShadowDecoration.Parent = this.txtAlasanPenolakan;
            this.txtAlasanPenolakan.Size = new System.Drawing.Size(220, 107);
            this.txtAlasanPenolakan.TabIndex = 47;
            this.txtAlasanPenolakan.Visible = false;
            // 
            // labelAlasan
            // 
            this.labelAlasan.AutoSize = true;
            this.labelAlasan.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlasan.Location = new System.Drawing.Point(433, 254);
            this.labelAlasan.Name = "labelAlasan";
            this.labelAlasan.Size = new System.Drawing.Size(64, 26);
            this.labelAlasan.TabIndex = 48;
            this.labelAlasan.Text = "Alasan";
            this.labelAlasan.Visible = false;
            // 
            // labelBintang
            // 
            this.labelBintang.AutoSize = true;
            this.labelBintang.BackColor = System.Drawing.Color.Transparent;
            this.labelBintang.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBintang.ForeColor = System.Drawing.Color.Red;
            this.labelBintang.Location = new System.Drawing.Point(503, 254);
            this.labelBintang.Name = "labelBintang";
            this.labelBintang.Size = new System.Drawing.Size(19, 26);
            this.labelBintang.TabIndex = 49;
            this.labelBintang.Text = "*";
            this.labelBintang.Visible = false;
            // 
            // AccPeminjamanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.labelBintang);
            this.Controls.Add(this.labelAlasan);
            this.Controls.Add(this.txtAlasanPenolakan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTolakPeminjaman);
            this.Controls.Add(this.cbSetujuiPeminjaman);
            this.Controls.Add(this.txtNamaRuangan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaUser);
            this.Controls.Add(this.btnTolakPeminjaman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetujui);
            this.Controls.Add(this.txtKapasitasOrang);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.Controls.Add(this.txtLamaPeminjaman);
            this.Controls.Add(this.txtJenisKegitan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AccPeminjamanRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccPeminjamanRuangan";
            this.Load += new System.EventHandler(this.AccPeminjamanRuangan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSetujui;
        private Guna.UI2.WinForms.Guna2TextBox txtKapasitasOrang;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private Guna.UI2.WinForms.Guna2TextBox txtLamaPeminjaman;
        private Guna.UI2.WinForms.Guna2TextBox txtJenisKegitan;
        private Guna.UI2.WinForms.Guna2Button btnTolakPeminjaman;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaUser;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaRuangan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox cbTolakPeminjaman;
        private Guna.UI2.WinForms.Guna2CheckBox cbSetujuiPeminjaman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAlasan;
        private Guna.UI2.WinForms.Guna2TextBox txtAlasanPenolakan;
        private System.Windows.Forms.Label labelBintang;
    }
}