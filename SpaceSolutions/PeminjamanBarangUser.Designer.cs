namespace SpaceSolutions
{
    partial class PeminjamanBarangUser
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvTabelBarang = new System.Windows.Forms.DataGridView();
            this.Kolom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJumlahBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keranjangBarang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPinjam = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCariBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLamaPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUbah = new System.Windows.Forms.PictureBox();
            this.btnHapus = new System.Windows.Forms.PictureBox();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnTambah = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tanggal Peminjaman";
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
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(480, 271);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPeminjaman.TabIndex = 27;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            // 
            // dgvTabelBarang
            // 
            this.dgvTabelBarang.AllowUserToAddRows = false;
            this.dgvTabelBarang.AllowUserToDeleteRows = false;
            this.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kolom1,
            this.Column2,
            this.Column3});
            this.dgvTabelBarang.Location = new System.Drawing.Point(480, 47);
            this.dgvTabelBarang.Name = "dgvTabelBarang";
            this.dgvTabelBarang.ReadOnly = true;
            this.dgvTabelBarang.RowHeadersVisible = false;
            this.dgvTabelBarang.Size = new System.Drawing.Size(321, 125);
            this.dgvTabelBarang.TabIndex = 29;
            this.dgvTabelBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelBarang_CellClick);
            // 
            // Kolom1
            // 
            this.Kolom1.DataPropertyName = "idBarang";
            this.Kolom1.HeaderText = "ID Barang";
            this.Kolom1.Name = "Kolom1";
            this.Kolom1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaBarang";
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "stokBarang";
            this.Column3.HeaderText = "Stok Barang";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.BorderRadius = 4;
            this.txtIdBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBarang.DefaultText = "";
            this.txtIdBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBarang.DisabledState.Parent = this.txtIdBarang;
            this.txtIdBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBarang.Enabled = false;
            this.txtIdBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBarang.FocusedState.Parent = this.txtIdBarang;
            this.txtIdBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBarang.HoverState.Parent = this.txtIdBarang;
            this.txtIdBarang.Location = new System.Drawing.Point(65, 47);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.PasswordChar = '\0';
            this.txtIdBarang.PlaceholderText = "";
            this.txtIdBarang.SelectedText = "";
            this.txtIdBarang.ShadowDecoration.Parent = this.txtIdBarang;
            this.txtIdBarang.Size = new System.Drawing.Size(220, 36);
            this.txtIdBarang.TabIndex = 30;
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.BorderRadius = 4;
            this.txtJumlahBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlahBarang.DefaultText = "";
            this.txtJumlahBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlahBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlahBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahBarang.DisabledState.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlahBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahBarang.FocusedState.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlahBarang.HoverState.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.Location = new System.Drawing.Point(65, 136);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.PasswordChar = '\0';
            this.txtJumlahBarang.PlaceholderText = "";
            this.txtJumlahBarang.SelectedText = "";
            this.txtJumlahBarang.ShadowDecoration.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.Size = new System.Drawing.Size(220, 36);
            this.txtJumlahBarang.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Jumlah Barang";
            // 
            // keranjangBarang
            // 
            this.keranjangBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.keranjangBarang.FullRowSelect = true;
            this.keranjangBarang.HideSelection = false;
            this.keranjangBarang.Location = new System.Drawing.Point(65, 212);
            this.keranjangBarang.Name = "keranjangBarang";
            this.keranjangBarang.Size = new System.Drawing.Size(316, 120);
            this.keranjangBarang.TabIndex = 33;
            this.keranjangBarang.UseCompatibleStateImageBehavior = false;
            this.keranjangBarang.View = System.Windows.Forms.View.Details;
            this.keranjangBarang.SelectedIndexChanged += new System.EventHandler(this.keranjangBarang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Peminjaman";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Barang";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nama Barang";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 80;
            // 
            // btnPinjam
            // 
            this.btnPinjam.BorderRadius = 4;
            this.btnPinjam.CheckedState.Parent = this.btnPinjam;
            this.btnPinjam.CustomImages.Parent = this.btnPinjam;
            this.btnPinjam.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPinjam.ForeColor = System.Drawing.Color.White;
            this.btnPinjam.HoverState.Parent = this.btnPinjam;
            this.btnPinjam.Location = new System.Drawing.Point(480, 400);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.ShadowDecoration.Parent = this.btnPinjam;
            this.btnPinjam.Size = new System.Drawing.Size(102, 36);
            this.btnPinjam.TabIndex = 34;
            this.btnPinjam.Text = "Pinjam";
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data Barang";
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.BorderRadius = 4;
            this.txtCariBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariBarang.DefaultText = "";
            this.txtCariBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariBarang.DisabledState.Parent = this.txtCariBarang;
            this.txtCariBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariBarang.FocusedState.Parent = this.txtCariBarang;
            this.txtCariBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariBarang.HoverState.Parent = this.txtCariBarang;
            this.txtCariBarang.Location = new System.Drawing.Point(480, 193);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.PasswordChar = '\0';
            this.txtCariBarang.PlaceholderText = "Cari Nama Barang";
            this.txtCariBarang.SelectedText = "";
            this.txtCariBarang.ShadowDecoration.Parent = this.txtCariBarang;
            this.txtCariBarang.Size = new System.Drawing.Size(221, 36);
            this.txtCariBarang.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Lama Peminjaman (Hari)";
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
            this.txtLamaPeminjaman.Location = new System.Drawing.Point(481, 349);
            this.txtLamaPeminjaman.Name = "txtLamaPeminjaman";
            this.txtLamaPeminjaman.PasswordChar = '\0';
            this.txtLamaPeminjaman.PlaceholderText = "";
            this.txtLamaPeminjaman.SelectedText = "";
            this.txtLamaPeminjaman.ShadowDecoration.Parent = this.txtLamaPeminjaman;
            this.txtLamaPeminjaman.Size = new System.Drawing.Size(220, 36);
            this.txtLamaPeminjaman.TabIndex = 40;
            // 
            // btnUbah
            // 
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.Image = global::SpaceSolutions.Properties.Resources.EDIT_2;
            this.btnUbah.Location = new System.Drawing.Point(186, 349);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(35, 35);
            this.btnUbah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUbah.TabIndex = 48;
            this.btnUbah.TabStop = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Image = global::SpaceSolutions.Properties.Resources.Hapus_2;
            this.btnHapus.Location = new System.Drawing.Point(126, 349);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(35, 35);
            this.btnHapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHapus.TabIndex = 47;
            this.btnHapus.TabStop = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(718, 194);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 46;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Image = global::SpaceSolutions.Properties.Resources.Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(766, 194);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(33, 33);
            this.btnRefesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefesh.TabIndex = 45;
            this.btnRefesh.TabStop = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Image = global::SpaceSolutions.Properties.Resources.Add;
            this.btnTambah.Location = new System.Drawing.Point(65, 349);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(35, 35);
            this.btnTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTambah.TabIndex = 44;
            this.btnTambah.TabStop = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // PeminjamanBarangUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 562);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLamaPeminjaman);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.keranjangBarang);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdBarang);
            this.Controls.Add(this.dgvTabelBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeminjamanBarangUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeminjamanBarangUser";
            this.Load += new System.EventHandler(this.PeminjamanBarangUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUbah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private System.Windows.Forms.DataGridView dgvTabelBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView keranjangBarang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPinjam;
        private Guna.UI2.WinForms.Guna2TextBox txtCariBarang;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtLamaPeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnTambah;
        private System.Windows.Forms.PictureBox btnUbah;
        private System.Windows.Forms.PictureBox btnHapus;
    }
}