namespace SpaceSolutions
{
    partial class TransaksiPeminjamanRuanganUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.cbNamaRuangan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtJenisKegiatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKapasitasOrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLamaPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.ruanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.RuanganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kegiatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kapasitasOrang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tanggalPeminjaman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "lama Peminjaman (Hari)";
            // 
            // btnPinjam
            // 
            this.btnPinjam.CheckedState.Parent = this.btnPinjam;
            this.btnPinjam.CustomImages.Parent = this.btnPinjam;
            this.btnPinjam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.HoverState.Parent = this.btnPinjam;
            this.btnPinjam.Location = new System.Drawing.Point(366, 355);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.ShadowDecoration.Parent = this.btnPinjam;
            this.btnPinjam.Size = new System.Drawing.Size(125, 39);
            this.btnPinjam.TabIndex = 5;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // cbNamaRuangan
            // 
            this.cbNamaRuangan.BackColor = System.Drawing.Color.Transparent;
            this.cbNamaRuangan.DataSource = this.ruanganBindingSource;
            this.cbNamaRuangan.DisplayMember = "namaRuangan";
            this.cbNamaRuangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNamaRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamaRuangan.FocusedColor = System.Drawing.Color.Empty;
            this.cbNamaRuangan.FocusedState.Parent = this.cbNamaRuangan;
            this.cbNamaRuangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNamaRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNamaRuangan.FormattingEnabled = true;
            this.cbNamaRuangan.HoverState.Parent = this.cbNamaRuangan;
            this.cbNamaRuangan.ItemHeight = 30;
            this.cbNamaRuangan.ItemsAppearance.Parent = this.cbNamaRuangan;
            this.cbNamaRuangan.Location = new System.Drawing.Point(91, 63);
            this.cbNamaRuangan.Name = "cbNamaRuangan";
            this.cbNamaRuangan.ShadowDecoration.Parent = this.cbNamaRuangan;
            this.cbNamaRuangan.Size = new System.Drawing.Size(229, 36);
            this.cbNamaRuangan.TabIndex = 6;
            this.cbNamaRuangan.ValueMember = "idRuangan";
            // 
            // txtJenisKegiatan
            // 
            this.txtJenisKegiatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenisKegiatan.DefaultText = "";
            this.txtJenisKegiatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJenisKegiatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJenisKegiatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenisKegiatan.DisabledState.Parent = this.txtJenisKegiatan;
            this.txtJenisKegiatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenisKegiatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegiatan.FocusedState.Parent = this.txtJenisKegiatan;
            this.txtJenisKegiatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegiatan.HoverState.Parent = this.txtJenisKegiatan;
            this.txtJenisKegiatan.Location = new System.Drawing.Point(91, 137);
            this.txtJenisKegiatan.Name = "txtJenisKegiatan";
            this.txtJenisKegiatan.PasswordChar = '\0';
            this.txtJenisKegiatan.PlaceholderText = "";
            this.txtJenisKegiatan.SelectedText = "";
            this.txtJenisKegiatan.ShadowDecoration.Parent = this.txtJenisKegiatan;
            this.txtJenisKegiatan.Size = new System.Drawing.Size(229, 36);
            this.txtJenisKegiatan.TabIndex = 7;
            // 
            // txtKapasitasOrang
            // 
            this.txtKapasitasOrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKapasitasOrang.DefaultText = "";
            this.txtKapasitasOrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKapasitasOrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKapasitasOrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKapasitasOrang.DisabledState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKapasitasOrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.FocusedState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.HoverState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Location = new System.Drawing.Point(91, 208);
            this.txtKapasitasOrang.Name = "txtKapasitasOrang";
            this.txtKapasitasOrang.PasswordChar = '\0';
            this.txtKapasitasOrang.PlaceholderText = "";
            this.txtKapasitasOrang.SelectedText = "";
            this.txtKapasitasOrang.ShadowDecoration.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Size = new System.Drawing.Size(229, 36);
            this.txtKapasitasOrang.TabIndex = 8;
            // 
            // dtTanggalPeminjaman
            // 
            this.dtTanggalPeminjaman.CheckedState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.FillColor = System.Drawing.Color.White;
            this.dtTanggalPeminjaman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTanggalPeminjaman.HoverState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(90, 284);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(226, 33);
            this.dtTanggalPeminjaman.TabIndex = 9;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 8, 0, 41, 45);
            // 
            // txtLamaPeminjaman
            // 
            this.txtLamaPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLamaPeminjaman.DefaultText = "";
            this.txtLamaPeminjaman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLamaPeminjaman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLamaPeminjaman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLamaPeminjaman.DisabledState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLamaPeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.FocusedState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.HoverState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Location = new System.Drawing.Point(87, 358);
            this.txtLamaPeminjaman.Name = "txtLamaPeminjaman";
            this.txtLamaPeminjaman.PasswordChar = '\0';
            this.txtLamaPeminjaman.PlaceholderText = "";
            this.txtLamaPeminjaman.SelectedText = "";
            this.txtLamaPeminjaman.ShadowDecoration.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Size = new System.Drawing.Size(229, 36);
            this.txtLamaPeminjaman.TabIndex = 10;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(431, 86);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 13);
            this.labelTest.TabIndex = 11;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruanganBindingSource
            // 
            this.ruanganBindingSource.DataMember = "Ruangan";
            this.ruanganBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // ruanganTableAdapter
            // 
            this.ruanganTableAdapter.ClearBeforeFill = true;
            // 
            // TransaksiPeminjamanRuanganUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.txtLamaPeminjaman);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.Controls.Add(this.txtKapasitasOrang);
            this.Controls.Add(this.txtJenisKegiatan);
            this.Controls.Add(this.cbNamaRuangan);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransaksiPeminjamanRuanganUser";
            this.Text = "TransaksiPeminjamanRuanganUser";
            this.Load += new System.EventHandler(this.TransaksiPeminjamanRuanganUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnPinjam;
        private Guna.UI2.WinForms.Guna2ComboBox cbNamaRuangan;
        private Guna.UI2.WinForms.Guna2TextBox txtJenisKegiatan;
        private Guna.UI2.WinForms.Guna2TextBox txtKapasitasOrang;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private Guna.UI2.WinForms.Guna2TextBox txtLamaPeminjaman;
        private System.Windows.Forms.Label labelTest;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource ruanganBindingSource;
        private DSSpaceSolutionsTableAdapters.RuanganTableAdapter ruanganTableAdapter;
    }
}