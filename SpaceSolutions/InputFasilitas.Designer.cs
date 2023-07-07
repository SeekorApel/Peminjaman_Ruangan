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
            this.idBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.BarangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTambahIDBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCariNamaBarang = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.keranjangDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtJumlahBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnRemoveKeranjang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahKeranjang = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
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
            this.txtNamaFasilitas.Location = new System.Drawing.Point(100, 87);
            this.txtNamaFasilitas.Name = "txtNamaFasilitas";
            this.txtNamaFasilitas.PasswordChar = '\0';
            this.txtNamaFasilitas.PlaceholderText = "";
            this.txtNamaFasilitas.SelectedText = "";
            this.txtNamaFasilitas.ShadowDecoration.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.Size = new System.Drawing.Size(250, 36);
            this.txtNamaFasilitas.TabIndex = 2;
            // 
            // dgvTabelBarang
            // 
            this.dgvTabelBarang.AllowUserToAddRows = false;
            this.dgvTabelBarang.AllowUserToDeleteRows = false;
            this.dgvTabelBarang.AutoGenerateColumns = false;
            this.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn});
            this.dgvTabelBarang.DataSource = this.barangBindingSource;
            this.dgvTabelBarang.Location = new System.Drawing.Point(372, 290);
            this.dgvTabelBarang.Name = "dgvTabelBarang";
            this.dgvTabelBarang.ReadOnly = true;
            this.dgvTabelBarang.RowHeadersVisible = false;
            this.dgvTabelBarang.Size = new System.Drawing.Size(243, 137);
            this.dgvTabelBarang.TabIndex = 4;
            // 
            // idBarangDataGridViewTextBoxColumn
            // 
            this.idBarangDataGridViewTextBoxColumn.DataPropertyName = "IdBarang";
            this.idBarangDataGridViewTextBoxColumn.HeaderText = "IdBarang";
            this.idBarangDataGridViewTextBoxColumn.Name = "idBarangDataGridViewTextBoxColumn";
            this.idBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Fasilitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barang";
            // 
            // txtTambahIDBarang
            // 
            this.txtTambahIDBarang.BorderRadius = 4;
            this.txtTambahIDBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTambahIDBarang.DefaultText = "";
            this.txtTambahIDBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTambahIDBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTambahIDBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTambahIDBarang.DisabledState.Parent = this.txtTambahIDBarang;
            this.txtTambahIDBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTambahIDBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTambahIDBarang.FocusedState.Parent = this.txtTambahIDBarang;
            this.txtTambahIDBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTambahIDBarang.HoverState.Parent = this.txtTambahIDBarang;
            this.txtTambahIDBarang.Location = new System.Drawing.Point(100, 150);
            this.txtTambahIDBarang.Name = "txtTambahIDBarang";
            this.txtTambahIDBarang.PasswordChar = '\0';
            this.txtTambahIDBarang.PlaceholderText = "Masukan ID Barang";
            this.txtTambahIDBarang.SelectedText = "";
            this.txtTambahIDBarang.ShadowDecoration.Parent = this.txtTambahIDBarang;
            this.txtTambahIDBarang.Size = new System.Drawing.Size(250, 36);
            this.txtTambahIDBarang.TabIndex = 10;
            this.txtTambahIDBarang.TextChanged += new System.EventHandler(this.txtTambahIDBarang_TextChanged);
            // 
            // btnCariNamaBarang
            // 
            this.btnCariNamaBarang.BorderRadius = 6;
            this.btnCariNamaBarang.CheckedState.Parent = this.btnCariNamaBarang;
            this.btnCariNamaBarang.CustomImages.Parent = this.btnCariNamaBarang;
            this.btnCariNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCariNamaBarang.ForeColor = System.Drawing.Color.White;
            this.btnCariNamaBarang.HoverState.Parent = this.btnCariNamaBarang;
            this.btnCariNamaBarang.Location = new System.Drawing.Point(100, 346);
            this.btnCariNamaBarang.Name = "btnCariNamaBarang";
            this.btnCariNamaBarang.ShadowDecoration.Parent = this.btnCariNamaBarang;
            this.btnCariNamaBarang.Size = new System.Drawing.Size(83, 30);
            this.btnCariNamaBarang.TabIndex = 13;
            this.btnCariNamaBarang.Text = "Search";
            this.btnCariNamaBarang.Click += new System.EventHandler(this.btnCariNamaBarang_Click);
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
            this.txtCariBarang.Location = new System.Drawing.Point(99, 279);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.PasswordChar = '\0';
            this.txtCariBarang.PlaceholderText = "Cari Nama Barang";
            this.txtCariBarang.SelectedText = "";
            this.txtCariBarang.ShadowDecoration.Parent = this.txtCariBarang;
            this.txtCariBarang.Size = new System.Drawing.Size(250, 36);
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
            this.keranjangDetail.Location = new System.Drawing.Point(372, 79);
            this.keranjangDetail.Name = "keranjangDetail";
            this.keranjangDetail.Size = new System.Drawing.Size(328, 126);
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
            this.txtJumlahBarang.Location = new System.Drawing.Point(100, 221);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.PasswordChar = '\0';
            this.txtJumlahBarang.PlaceholderText = "Masukan Jumlah Barang";
            this.txtJumlahBarang.SelectedText = "";
            this.txtJumlahBarang.ShadowDecoration.Parent = this.txtJumlahBarang;
            this.txtJumlahBarang.Size = new System.Drawing.Size(250, 36);
            this.txtJumlahBarang.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jumlah Barang";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(769, 14);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 24;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnRemoveKeranjang
            // 
            this.btnRemoveKeranjang.BorderRadius = 5;
            this.btnRemoveKeranjang.CheckedState.Parent = this.btnRemoveKeranjang;
            this.btnRemoveKeranjang.CustomImages.Parent = this.btnRemoveKeranjang;
            this.btnRemoveKeranjang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnRemoveKeranjang.HoverState.Parent = this.btnRemoveKeranjang;
            this.btnRemoveKeranjang.Location = new System.Drawing.Point(487, 221);
            this.btnRemoveKeranjang.Name = "btnRemoveKeranjang";
            this.btnRemoveKeranjang.ShadowDecoration.Parent = this.btnRemoveKeranjang;
            this.btnRemoveKeranjang.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveKeranjang.TabIndex = 25;
            this.btnRemoveKeranjang.Text = "Remove";
            this.btnRemoveKeranjang.Click += new System.EventHandler(this.btnRemoveKeranjang_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderRadius = 5;
            this.btnSimpan.CheckedState.Parent = this.btnSimpan;
            this.btnSimpan.CustomImages.Parent = this.btnSimpan;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.HoverState.Parent = this.btnSimpan;
            this.btnSimpan.Location = new System.Drawing.Point(600, 221);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.ShadowDecoration.Parent = this.btnSimpan;
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 26;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(215, 346);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(83, 30);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTambahKeranjang
            // 
            this.btnTambahKeranjang.BorderRadius = 5;
            this.btnTambahKeranjang.CheckedState.Parent = this.btnTambahKeranjang;
            this.btnTambahKeranjang.CustomImages.Parent = this.btnTambahKeranjang;
            this.btnTambahKeranjang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambahKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnTambahKeranjang.HoverState.Parent = this.btnTambahKeranjang;
            this.btnTambahKeranjang.Location = new System.Drawing.Point(372, 221);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.ShadowDecoration.Parent = this.btnTambahKeranjang;
            this.btnTambahKeranjang.Size = new System.Drawing.Size(100, 30);
            this.btnTambahKeranjang.TabIndex = 28;
            this.btnTambahKeranjang.Text = "Tambah";
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Data Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Detail Barang";
            // 
            // InputFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTambahKeranjang);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnRemoveKeranjang);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.keranjangDetail);
            this.Controls.Add(this.btnCariNamaBarang);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.txtTambahIDBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabelBarang);
            this.Controls.Add(this.txtNamaFasilitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputFasilitas";
            this.Load += new System.EventHandler(this.InputFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtTambahIDBarang;
        private Guna.UI2.WinForms.Guna2Button btnCariNamaBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtCariBarang;
        private System.Windows.Forms.ListView keranjangDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahBarang;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnRemoveKeranjang;
        private Guna.UI2.WinForms.Guna2Button btnTambahKeranjang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}