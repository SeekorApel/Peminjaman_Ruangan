namespace SpaceSolutions
{
    partial class PeminjamanRuanganUser
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
            this.cbIdRuangan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtJenisKegitan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLamaPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKapasitasOrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.ruanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.RuanganTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdRuangan
            // 
            this.cbIdRuangan.BackColor = System.Drawing.Color.Transparent;
            this.cbIdRuangan.BorderRadius = 4;
            this.cbIdRuangan.DataSource = this.ruanganBindingSource;
            this.cbIdRuangan.DisplayMember = "namaRuangan";
            this.cbIdRuangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIdRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdRuangan.FocusedColor = System.Drawing.Color.Empty;
            this.cbIdRuangan.FocusedState.Parent = this.cbIdRuangan;
            this.cbIdRuangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIdRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIdRuangan.FormattingEnabled = true;
            this.cbIdRuangan.HoverState.Parent = this.cbIdRuangan;
            this.cbIdRuangan.ItemHeight = 30;
            this.cbIdRuangan.ItemsAppearance.Parent = this.cbIdRuangan;
            this.cbIdRuangan.Location = new System.Drawing.Point(151, 175);
            this.cbIdRuangan.Name = "cbIdRuangan";
            this.cbIdRuangan.ShadowDecoration.Parent = this.cbIdRuangan;
            this.cbIdRuangan.Size = new System.Drawing.Size(220, 36);
            this.cbIdRuangan.TabIndex = 1;
            this.cbIdRuangan.ValueMember = "idRuangan";
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
            this.txtJenisKegitan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegitan.FocusedState.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenisKegitan.HoverState.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.Location = new System.Drawing.Point(151, 251);
            this.txtJenisKegitan.Name = "txtJenisKegitan";
            this.txtJenisKegitan.PasswordChar = '\0';
            this.txtJenisKegitan.PlaceholderText = "";
            this.txtJenisKegitan.SelectedText = "";
            this.txtJenisKegitan.ShadowDecoration.Parent = this.txtJenisKegitan;
            this.txtJenisKegitan.Size = new System.Drawing.Size(220, 36);
            this.txtJenisKegitan.TabIndex = 3;
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
            this.txtLamaPeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.FocusedState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLamaPeminjaman.HoverState.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Location = new System.Drawing.Point(457, 175);
            this.txtLamaPeminjaman.Name = "txtLamaPeminjaman";
            this.txtLamaPeminjaman.PasswordChar = '\0';
            this.txtLamaPeminjaman.PlaceholderText = "";
            this.txtLamaPeminjaman.SelectedText = "";
            this.txtLamaPeminjaman.ShadowDecoration.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Size = new System.Drawing.Size(220, 36);
            this.txtLamaPeminjaman.TabIndex = 5;
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
            this.txtKapasitasOrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.FocusedState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKapasitasOrang.HoverState.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Location = new System.Drawing.Point(151, 334);
            this.txtKapasitasOrang.Name = "txtKapasitasOrang";
            this.txtKapasitasOrang.PasswordChar = '\0';
            this.txtKapasitasOrang.PlaceholderText = "";
            this.txtKapasitasOrang.SelectedText = "";
            this.txtKapasitasOrang.ShadowDecoration.Parent = this.txtKapasitasOrang;
            this.txtKapasitasOrang.Size = new System.Drawing.Size(220, 36);
            this.txtKapasitasOrang.TabIndex = 9;
            // 
            // btnPinjam
            // 
            this.btnPinjam.BorderRadius = 4;
            this.btnPinjam.CheckedState.Parent = this.btnPinjam;
            this.btnPinjam.CustomImages.Parent = this.btnPinjam;
            this.btnPinjam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.HoverState.Parent = this.btnPinjam;
            this.btnPinjam.Location = new System.Drawing.Point(457, 334);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.ShadowDecoration.Parent = this.btnPinjam;
            this.btnPinjam.Size = new System.Drawing.Size(180, 36);
            this.btnPinjam.TabIndex = 11;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // dtTanggalPeminjaman
            // 
            this.dtTanggalPeminjaman.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtTanggalPeminjaman.BorderRadius = 4;
            this.dtTanggalPeminjaman.BorderThickness = 1;
            this.dtTanggalPeminjaman.CheckedState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.FillColor = System.Drawing.Color.White;
            this.dtTanggalPeminjaman.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTanggalPeminjaman.HoverState.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(457, 250);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPeminjaman.TabIndex = 7;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ruangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Jenis Kegiatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kapasitas Orang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Lama Peminjaman (Hari)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tanggal Peminjaman";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 27;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(768, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 28;
            // 
            // PeminjamanRuanganUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 466);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.txtKapasitasOrang);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.Controls.Add(this.txtLamaPeminjaman);
            this.Controls.Add(this.txtJenisKegitan);
            this.Controls.Add(this.cbIdRuangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeminjamanRuanganUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeminjamanRuanganUser";
            this.Load += new System.EventHandler(this.PeminjamanRuanganUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbIdRuangan;
        private Guna.UI2.WinForms.Guna2TextBox txtJenisKegitan;
        private Guna.UI2.WinForms.Guna2TextBox txtLamaPeminjaman;
        private Guna.UI2.WinForms.Guna2TextBox txtKapasitasOrang;
        private Guna.UI2.WinForms.Guna2Button btnPinjam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource ruanganBindingSource;
        private DSSpaceSolutionsTableAdapters.RuanganTableAdapter ruanganTableAdapter;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}