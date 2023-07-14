namespace SpaceSolutions
{
    partial class PengembalianRuanganAdmin
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
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtTanggalPengembalian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTotalDenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbRusak = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTidakKerusakan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Denda = new System.Windows.Forms.Label();
            this.btnKembalikan = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTabelPeminjaman = new System.Windows.Forms.DataGridView();
            this.Kolom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCoba = new System.Windows.Forms.Button();
            this.btnCobaSelilih = new System.Windows.Forms.Button();
            this.btnDenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelPeminjaman)).BeginInit();
            this.SuspendLayout();
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
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(86, 244);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPeminjaman.TabIndex = 8;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            // 
            // dtTanggalPengembalian
            // 
            this.dtTanggalPengembalian.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtTanggalPengembalian.BorderRadius = 4;
            this.dtTanggalPengembalian.BorderThickness = 1;
            this.dtTanggalPengembalian.CheckedState.Parent = this.dtTanggalPengembalian;
            this.dtTanggalPengembalian.FillColor = System.Drawing.Color.White;
            this.dtTanggalPengembalian.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTanggalPengembalian.HoverState.Parent = this.dtTanggalPengembalian;
            this.dtTanggalPengembalian.Location = new System.Drawing.Point(86, 319);
            this.dtTanggalPengembalian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPengembalian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPengembalian.Name = "dtTanggalPengembalian";
            this.dtTanggalPengembalian.ShadowDecoration.Parent = this.dtTanggalPengembalian;
            this.dtTanggalPengembalian.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPengembalian.TabIndex = 9;
            this.dtTanggalPengembalian.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            this.dtTanggalPengembalian.ValueChanged += new System.EventHandler(this.dtTanggalPengembalian_ValueChanged);
            // 
            // txtTotalDenda
            // 
            this.txtTotalDenda.BorderRadius = 4;
            this.txtTotalDenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDenda.DefaultText = "";
            this.txtTotalDenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalDenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalDenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDenda.DisabledState.Parent = this.txtTotalDenda;
            this.txtTotalDenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDenda.FocusedState.Parent = this.txtTotalDenda;
            this.txtTotalDenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDenda.HoverState.Parent = this.txtTotalDenda;
            this.txtTotalDenda.Location = new System.Drawing.Point(86, 473);
            this.txtTotalDenda.Name = "txtTotalDenda";
            this.txtTotalDenda.PasswordChar = '\0';
            this.txtTotalDenda.PlaceholderText = "";
            this.txtTotalDenda.SelectedText = "";
            this.txtTotalDenda.ShadowDecoration.Parent = this.txtTotalDenda;
            this.txtTotalDenda.Size = new System.Drawing.Size(220, 36);
            this.txtTotalDenda.TabIndex = 11;
            this.txtTotalDenda.TextChanged += new System.EventHandler(this.txtTotalDenda_TextChanged);
            // 
            // rbRusak
            // 
            this.rbRusak.AutoSize = true;
            this.rbRusak.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRusak.CheckedState.BorderThickness = 0;
            this.rbRusak.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRusak.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbRusak.CheckedState.InnerOffset = -4;
            this.rbRusak.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.rbRusak.Location = new System.Drawing.Point(86, 401);
            this.rbRusak.Name = "rbRusak";
            this.rbRusak.Size = new System.Drawing.Size(75, 30);
            this.rbRusak.TabIndex = 12;
            this.rbRusak.TabStop = true;
            this.rbRusak.Text = "Rusak";
            this.rbRusak.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbRusak.UncheckedState.BorderThickness = 2;
            this.rbRusak.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRusak.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbRusak.UseVisualStyleBackColor = true;
            // 
            // rbTidakKerusakan
            // 
            this.rbTidakKerusakan.AutoSize = true;
            this.rbTidakKerusakan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakKerusakan.CheckedState.BorderThickness = 0;
            this.rbTidakKerusakan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakKerusakan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTidakKerusakan.CheckedState.InnerOffset = -4;
            this.rbTidakKerusakan.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.rbTidakKerusakan.Location = new System.Drawing.Point(212, 401);
            this.rbTidakKerusakan.Name = "rbTidakKerusakan";
            this.rbTidakKerusakan.Size = new System.Drawing.Size(119, 30);
            this.rbTidakKerusakan.TabIndex = 13;
            this.rbTidakKerusakan.TabStop = true;
            this.rbTidakKerusakan.Text = "Tidak Rusak";
            this.rbTidakKerusakan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTidakKerusakan.UncheckedState.BorderThickness = 2;
            this.rbTidakKerusakan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTidakKerusakan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTidakKerusakan.UseVisualStyleBackColor = true;
            // 
            // Denda
            // 
            this.Denda.AutoSize = true;
            this.Denda.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Denda.Location = new System.Drawing.Point(85, 446);
            this.Denda.Name = "Denda";
            this.Denda.Size = new System.Drawing.Size(62, 26);
            this.Denda.TabIndex = 25;
            this.Denda.Text = "Denda";
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.BorderRadius = 5;
            this.btnKembalikan.CheckedState.Parent = this.btnKembalikan;
            this.btnKembalikan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembalikan.CustomImages.Parent = this.btnKembalikan;
            this.btnKembalikan.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembalikan.ForeColor = System.Drawing.Color.White;
            this.btnKembalikan.HoverState.Parent = this.btnKembalikan;
            this.btnKembalikan.Location = new System.Drawing.Point(141, 530);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.ShadowDecoration.Parent = this.btnKembalikan;
            this.btnKembalikan.Size = new System.Drawing.Size(140, 36);
            this.btnKembalikan.TabIndex = 31;
            this.btnKembalikan.Text = "Kembalikan";
            // 
            // txtIdPeminjaman
            // 
            this.txtIdPeminjaman.BorderRadius = 4;
            this.txtIdPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPeminjaman.DefaultText = "";
            this.txtIdPeminjaman.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPeminjaman.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPeminjaman.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPeminjaman.DisabledState.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPeminjaman.FocusedState.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPeminjaman.HoverState.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.Location = new System.Drawing.Point(90, 174);
            this.txtIdPeminjaman.Name = "txtIdPeminjaman";
            this.txtIdPeminjaman.PasswordChar = '\0';
            this.txtIdPeminjaman.PlaceholderText = "";
            this.txtIdPeminjaman.SelectedText = "";
            this.txtIdPeminjaman.ShadowDecoration.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.Size = new System.Drawing.Size(220, 36);
            this.txtIdPeminjaman.TabIndex = 33;
            this.txtIdPeminjaman.Leave += new System.EventHandler(this.txtIdPeminjaman_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kondisi Ruangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tanggal Pengembalian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tanggal Peminjaman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "ID Peminjmanan";
            // 
            // dgvTabelPeminjaman
            // 
            this.dgvTabelPeminjaman.AllowUserToAddRows = false;
            this.dgvTabelPeminjaman.AllowUserToDeleteRows = false;
            this.dgvTabelPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelPeminjaman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kolom1,
            this.Kolom2,
            this.Kolom3,
            this.Kolom4,
            this.Kolom5,
            this.Kolom6,
            this.Kolom7,
            this.Kolom8,
            this.Kolom9,
            this.Kolom10});
            this.dgvTabelPeminjaman.Location = new System.Drawing.Point(382, 143);
            this.dgvTabelPeminjaman.Name = "dgvTabelPeminjaman";
            this.dgvTabelPeminjaman.ReadOnly = true;
            this.dgvTabelPeminjaman.RowHeadersVisible = false;
            this.dgvTabelPeminjaman.Size = new System.Drawing.Size(582, 366);
            this.dgvTabelPeminjaman.TabIndex = 10;
            this.dgvTabelPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelPeminjaman_CellClick);
            // 
            // Kolom1
            // 
            this.Kolom1.DataPropertyName = "idPeminjamanRuangan";
            this.Kolom1.HeaderText = "ID Peminjaman";
            this.Kolom1.Name = "Kolom1";
            this.Kolom1.ReadOnly = true;
            // 
            // Kolom2
            // 
            this.Kolom2.DataPropertyName = "idUser";
            this.Kolom2.HeaderText = "ID User";
            this.Kolom2.Name = "Kolom2";
            this.Kolom2.ReadOnly = true;
            this.Kolom2.Visible = false;
            // 
            // Kolom3
            // 
            this.Kolom3.DataPropertyName = "nama";
            this.Kolom3.HeaderText = "Nama Peminjam";
            this.Kolom3.Name = "Kolom3";
            this.Kolom3.ReadOnly = true;
            // 
            // Kolom4
            // 
            this.Kolom4.DataPropertyName = "idRuangan";
            this.Kolom4.HeaderText = "ID Ruangann";
            this.Kolom4.Name = "Kolom4";
            this.Kolom4.ReadOnly = true;
            this.Kolom4.Visible = false;
            // 
            // Kolom5
            // 
            this.Kolom5.DataPropertyName = "namaRuangan";
            this.Kolom5.HeaderText = "namaRuangan";
            this.Kolom5.Name = "Kolom5";
            this.Kolom5.ReadOnly = true;
            // 
            // Kolom6
            // 
            this.Kolom6.DataPropertyName = "jenisKegiatan";
            this.Kolom6.HeaderText = "jenisKegiatan";
            this.Kolom6.Name = "Kolom6";
            this.Kolom6.ReadOnly = true;
            // 
            // Kolom7
            // 
            this.Kolom7.DataPropertyName = "kapasitasOrang";
            this.Kolom7.HeaderText = "kapasitasOrang";
            this.Kolom7.Name = "Kolom7";
            this.Kolom7.ReadOnly = true;
            // 
            // Kolom8
            // 
            this.Kolom8.DataPropertyName = "tanggalPeminjaman";
            this.Kolom8.HeaderText = "Tanggal Peminjaman";
            this.Kolom8.Name = "Kolom8";
            this.Kolom8.ReadOnly = true;
            // 
            // Kolom9
            // 
            this.Kolom9.DataPropertyName = "lamaPeminjaman";
            this.Kolom9.HeaderText = "Lama Peminjaman";
            this.Kolom9.Name = "Kolom9";
            this.Kolom9.ReadOnly = true;
            // 
            // Kolom10
            // 
            this.Kolom10.DataPropertyName = "statusPeminjaman";
            this.Kolom10.HeaderText = "Status Peminjaman";
            this.Kolom10.Name = "Kolom10";
            this.Kolom10.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "label3";
            // 
            // btnCoba
            // 
            this.btnCoba.Location = new System.Drawing.Point(326, 244);
            this.btnCoba.Name = "btnCoba";
            this.btnCoba.Size = new System.Drawing.Size(50, 23);
            this.btnCoba.TabIndex = 39;
            this.btnCoba.Text = "Coba";
            this.btnCoba.UseVisualStyleBackColor = true;
            this.btnCoba.Click += new System.EventHandler(this.btnCoba_Click);
            // 
            // btnCobaSelilih
            // 
            this.btnCobaSelilih.Location = new System.Drawing.Point(326, 332);
            this.btnCobaSelilih.Name = "btnCobaSelilih";
            this.btnCobaSelilih.Size = new System.Drawing.Size(50, 23);
            this.btnCobaSelilih.TabIndex = 40;
            this.btnCobaSelilih.Text = "Selisih";
            this.btnCobaSelilih.UseVisualStyleBackColor = true;
            this.btnCobaSelilih.Click += new System.EventHandler(this.btnCobaSelilih_Click);
            // 
            // btnDenda
            // 
            this.btnDenda.Location = new System.Drawing.Point(312, 446);
            this.btnDenda.Name = "btnDenda";
            this.btnDenda.Size = new System.Drawing.Size(64, 23);
            this.btnDenda.TabIndex = 41;
            this.btnDenda.Text = "Denda";
            this.btnDenda.UseVisualStyleBackColor = true;
            this.btnDenda.Click += new System.EventHandler(this.btnDenda_Click);
            // 
            // PengembalianRuanganAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 720);
            this.Controls.Add(this.btnDenda);
            this.Controls.Add(this.btnCobaSelilih);
            this.Controls.Add(this.btnCoba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPeminjaman);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.Denda);
            this.Controls.Add(this.rbTidakKerusakan);
            this.Controls.Add(this.rbRusak);
            this.Controls.Add(this.txtTotalDenda);
            this.Controls.Add(this.dgvTabelPeminjaman);
            this.Controls.Add(this.dtTanggalPengembalian);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PengembalianRuanganAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PengembalianRuanganAdmin";
            this.Load += new System.EventHandler(this.PengembalianRuanganAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPengembalian;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDenda;
        private Guna.UI2.WinForms.Guna2RadioButton rbRusak;
        private Guna.UI2.WinForms.Guna2RadioButton rbTidakKerusakan;
        private System.Windows.Forms.Label Denda;
        private Guna.UI2.WinForms.Guna2Button btnKembalikan;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPeminjaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTabelPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCoba;
        private System.Windows.Forms.Button btnCobaSelilih;
        private System.Windows.Forms.Button btnDenda;
    }
}