namespace SpaceSolutions
{
    partial class InputFasilitas
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
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.txtNamaFasilitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTabelBarang = new System.Windows.Forms.DataGridView();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.BarangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCariBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.keranjangDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtJumlahBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapusKeranjang = new System.Windows.Forms.PictureBox();
            this.btnTambahKeranjang = new System.Windows.Forms.PictureBox();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnSimpan = new System.Windows.Forms.PictureBox();
            this.Kolom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapusKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            this.SuspendLayout();
            // 
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "Barang";
            this.barangBindingSource1.DataSource = this.dSSpaceSolutionsBindingSource;
            // 
            // dSSpaceSolutionsBindingSource
            // 
            this.dSSpaceSolutionsBindingSource.DataSource = this.dSSpaceSolutions;
            this.dSSpaceSolutionsBindingSource.Position = 0;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNamaFasilitas
            // 
            this.txtNamaFasilitas.BorderRadius = 4;
            this.txtNamaFasilitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaFasilitas.DefaultText = "";
            this.txtNamaFasilitas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaFasilitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaFasilitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaFasilitas.DisabledState.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaFasilitas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaFasilitas.FocusedState.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaFasilitas.HoverState.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.Location = new System.Drawing.Point(101, 82);
            this.txtNamaFasilitas.Name = "txtNamaFasilitas";
            this.txtNamaFasilitas.PasswordChar = '\0';
            this.txtNamaFasilitas.PlaceholderText = "Masukan Nama Fasilitas";
            this.txtNamaFasilitas.SelectedText = "";
            this.txtNamaFasilitas.ShadowDecoration.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.Size = new System.Drawing.Size(250, 36);
            this.txtNamaFasilitas.TabIndex = 2;
            this.txtNamaFasilitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaFasilitas_KeyPress);
            // 
            // dgvTabelBarang
            // 
            this.dgvTabelBarang.AllowUserToAddRows = false;
            this.dgvTabelBarang.AllowUserToDeleteRows = false;
            this.dgvTabelBarang.AutoGenerateColumns = false;
            this.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kolom1,
            this.namaBarangDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvTabelBarang.DataSource = this.barangBindingSource;
            this.dgvTabelBarang.Location = new System.Drawing.Point(101, 305);
            this.dgvTabelBarang.Name = "dgvTabelBarang";
            this.dgvTabelBarang.ReadOnly = true;
            this.dgvTabelBarang.RowHeadersVisible = false;
            this.dgvTabelBarang.Size = new System.Drawing.Size(334, 136);
            this.dgvTabelBarang.TabIndex = 4;
            this.dgvTabelBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelBarang_CellClick);
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Fasilitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.Location = new System.Drawing.Point(98, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barang";
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.BorderRadius = 4;
            this.txtIDBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDBarang.DefaultText = "";
            this.txtIDBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBarang.DisabledState.Parent = this.txtIDBarang;
            this.txtIDBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBarang.FocusedState.Parent = this.txtIDBarang;
            this.txtIDBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDBarang.HoverState.Parent = this.txtIDBarang;
            this.txtIDBarang.Location = new System.Drawing.Point(101, 154);
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.PasswordChar = '\0';
            this.txtIDBarang.PlaceholderText = "Masukan ID Barang";
            this.txtIDBarang.SelectedText = "";
            this.txtIDBarang.ShadowDecoration.Parent = this.txtIDBarang;
            this.txtIDBarang.Size = new System.Drawing.Size(250, 36);
            this.txtIDBarang.TabIndex = 10;
            this.txtIDBarang.TextChanged += new System.EventHandler(this.txtTambahIDBarang_TextChanged);
            this.txtIDBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDBarang_KeyPress);
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
            this.txtCariBarang.Location = new System.Drawing.Point(469, 305);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.PasswordChar = '\0';
            this.txtCariBarang.PlaceholderText = "Cari Nama Barang";
            this.txtCariBarang.SelectedText = "";
            this.txtCariBarang.ShadowDecoration.Parent = this.txtCariBarang;
            this.txtCariBarang.Size = new System.Drawing.Size(196, 36);
            this.txtCariBarang.TabIndex = 12;
            // 
            // keranjangDetail
            // 
            this.keranjangDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.keranjangDetail.FullRowSelect = true;
            this.keranjangDetail.HideSelection = false;
            this.keranjangDetail.Location = new System.Drawing.Point(373, 74);
            this.keranjangDetail.Name = "keranjangDetail";
            this.keranjangDetail.Size = new System.Drawing.Size(328, 116);
            this.keranjangDetail.TabIndex = 17;
            this.keranjangDetail.UseCompatibleStateImageBehavior = false;
            this.keranjangDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Fasilitas";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Barang";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nama Barang";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
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
            this.txtJumlahBarang.Location = new System.Drawing.Point(101, 230);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.PasswordChar = '\0';
            this.txtJumlahBarang.PlaceholderText = "Masukan Jumlah Barang";
            this.txtJumlahBarang.SelectedText = "";
            this.txtJumlahBarang.ShadowDecoration.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.Size = new System.Drawing.Size(250, 36);
            this.txtJumlahBarang.TabIndex = 19;
            this.txtJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBarang_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(100, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jumlah Barang";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.Location = new System.Drawing.Point(101, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Data Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F);
            this.label5.Location = new System.Drawing.Point(369, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Detail Barang";
            // 
            // btnHapusKeranjang
            // 
            this.btnHapusKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusKeranjang.Image = global::SpaceSolutions.Properties.Resources.Hapus_2;
            this.btnHapusKeranjang.Location = new System.Drawing.Point(438, 211);
            this.btnHapusKeranjang.Name = "btnHapusKeranjang";
            this.btnHapusKeranjang.Size = new System.Drawing.Size(35, 35);
            this.btnHapusKeranjang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHapusKeranjang.TabIndex = 49;
            this.btnHapusKeranjang.TabStop = false;
            this.btnHapusKeranjang.Click += new System.EventHandler(this.btnHapusKeranjang_Click);
            // 
            // btnTambahKeranjang
            // 
            this.btnTambahKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahKeranjang.Image = global::SpaceSolutions.Properties.Resources.Add;
            this.btnTambahKeranjang.Location = new System.Drawing.Point(376, 210);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.Size = new System.Drawing.Size(35, 35);
            this.btnTambahKeranjang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTambahKeranjang.TabIndex = 48;
            this.btnTambahKeranjang.TabStop = false;
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(681, 307);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(30, 30);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 47;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Image = global::SpaceSolutions.Properties.Resources.Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(563, 212);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(35, 35);
            this.btnRefesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefesh.TabIndex = 46;
            this.btnRefesh.TabStop = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Image = global::SpaceSolutions.Properties.Resources.Save_2;
            this.btnSimpan.Location = new System.Drawing.Point(500, 212);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(35, 35);
            this.btnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSimpan.TabIndex = 50;
            this.btnSimpan.TabStop = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Kolom1
            // 
            this.Kolom1.DataPropertyName = "IdBarang";
            this.Kolom1.HeaderText = "IdBarang";
            this.Kolom1.Name = "Kolom1";
            this.Kolom1.ReadOnly = true;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaBarangDataGridViewTextBoxColumn.Width = 140;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stokBarang";
            this.Column1.HeaderText = "Stok Barang";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // InputFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHapusKeranjang);
            this.Controls.Add(this.btnTambahKeranjang);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.keranjangDetail);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.txtIDBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabelBarang);
            this.Controls.Add(this.txtNamaFasilitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputFasilitas";
            this.Load += new System.EventHandler(this.InputFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHapusKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambahKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNamaFasilitas;
        private System.Windows.Forms.DataGridView dgvTabelBarang;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DSSpaceSolutionsTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private System.Windows.Forms.BindingSource dSSpaceSolutionsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIDBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtCariBarang;
        private System.Windows.Forms.ListView keranjangDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahBarang;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnHapusKeranjang;
        private System.Windows.Forms.PictureBox btnTambahKeranjang;
        private System.Windows.Forms.PictureBox btnSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}