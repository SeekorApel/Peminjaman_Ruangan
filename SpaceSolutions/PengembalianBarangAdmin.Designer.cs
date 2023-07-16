namespace SpaceSolutions
{
    partial class PengembalianBarangAdmin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPeminjaman = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtTanggalPengembalian = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtTanggalPeminjaman = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvTabelPeminjamanBarang = new System.Windows.Forms.DataGridView();
            this.btnHapusKerusakan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahDenda = new Guna.UI2.WinForms.Guna2Button();
            this.KeranjangKerusakan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbKerusakanRuangan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTidakRusak = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbRusak = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbHilang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.keranjangBarang = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolom6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKembalikan = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalDenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.Denda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalTelatPengembalian = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalDendaKerusakan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelPeminjamanBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID Peminjmanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tanggal Peminjaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tanggal Pengembalian";
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
            this.txtIdPeminjaman.Enabled = false;
            this.txtIdPeminjaman.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPeminjaman.FocusedState.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPeminjaman.HoverState.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.Location = new System.Drawing.Point(102, 194);
            this.txtIdPeminjaman.Name = "txtIdPeminjaman";
            this.txtIdPeminjaman.PasswordChar = '\0';
            this.txtIdPeminjaman.PlaceholderText = "";
            this.txtIdPeminjaman.SelectedText = "";
            this.txtIdPeminjaman.ShadowDecoration.Parent = this.txtIdPeminjaman;
            this.txtIdPeminjaman.Size = new System.Drawing.Size(220, 36);
            this.txtIdPeminjaman.TabIndex = 40;
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
            this.dtTanggalPengembalian.Location = new System.Drawing.Point(98, 339);
            this.dtTanggalPengembalian.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPengembalian.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPengembalian.Name = "dtTanggalPengembalian";
            this.dtTanggalPengembalian.ShadowDecoration.Parent = this.dtTanggalPengembalian;
            this.dtTanggalPengembalian.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPengembalian.TabIndex = 39;
            this.dtTanggalPengembalian.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            this.dtTanggalPengembalian.ValueChanged += new System.EventHandler(this.dtTanggalPengembalian_ValueChanged);
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
            this.dtTanggalPeminjaman.Location = new System.Drawing.Point(98, 264);
            this.dtTanggalPeminjaman.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalPeminjaman.Name = "dtTanggalPeminjaman";
            this.dtTanggalPeminjaman.ShadowDecoration.Parent = this.dtTanggalPeminjaman;
            this.dtTanggalPeminjaman.Size = new System.Drawing.Size(221, 36);
            this.dtTanggalPeminjaman.TabIndex = 38;
            this.dtTanggalPeminjaman.Value = new System.DateTime(2023, 7, 7, 19, 26, 24, 90);
            // 
            // dgvTabelPeminjamanBarang
            // 
            this.dgvTabelPeminjamanBarang.AllowUserToAddRows = false;
            this.dgvTabelPeminjamanBarang.AllowUserToDeleteRows = false;
            this.dgvTabelPeminjamanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelPeminjamanBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kolom1,
            this.Kolom2,
            this.Kolom3,
            this.Kolom4,
            this.Kolom5,
            this.Kolom6});
            this.dgvTabelPeminjamanBarang.Location = new System.Drawing.Point(445, 142);
            this.dgvTabelPeminjamanBarang.Name = "dgvTabelPeminjamanBarang";
            this.dgvTabelPeminjamanBarang.ReadOnly = true;
            this.dgvTabelPeminjamanBarang.RowHeadersVisible = false;
            this.dgvTabelPeminjamanBarang.Size = new System.Drawing.Size(445, 150);
            this.dgvTabelPeminjamanBarang.TabIndex = 44;
            this.dgvTabelPeminjamanBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelPeminjamanBarang_CellClick);
            // 
            // btnHapusKerusakan
            // 
            this.btnHapusKerusakan.BorderRadius = 5;
            this.btnHapusKerusakan.CheckedState.Parent = this.btnHapusKerusakan;
            this.btnHapusKerusakan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusKerusakan.CustomImages.Parent = this.btnHapusKerusakan;
            this.btnHapusKerusakan.Font = new System.Drawing.Font("Gilmer Bold", 16F, System.Drawing.FontStyle.Bold);
            this.btnHapusKerusakan.ForeColor = System.Drawing.Color.White;
            this.btnHapusKerusakan.HoverState.Parent = this.btnHapusKerusakan;
            this.btnHapusKerusakan.Location = new System.Drawing.Point(359, 468);
            this.btnHapusKerusakan.Name = "btnHapusKerusakan";
            this.btnHapusKerusakan.ShadowDecoration.Parent = this.btnHapusKerusakan;
            this.btnHapusKerusakan.Size = new System.Drawing.Size(34, 36);
            this.btnHapusKerusakan.TabIndex = 52;
            this.btnHapusKerusakan.Text = "-";
            // 
            // btnTambahDenda
            // 
            this.btnTambahDenda.BorderRadius = 5;
            this.btnTambahDenda.CheckedState.Parent = this.btnTambahDenda;
            this.btnTambahDenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahDenda.CustomImages.Parent = this.btnTambahDenda;
            this.btnTambahDenda.Font = new System.Drawing.Font("Gilmer Bold", 16F, System.Drawing.FontStyle.Bold);
            this.btnTambahDenda.ForeColor = System.Drawing.Color.White;
            this.btnTambahDenda.HoverState.Parent = this.btnTambahDenda;
            this.btnTambahDenda.Location = new System.Drawing.Point(314, 468);
            this.btnTambahDenda.Name = "btnTambahDenda";
            this.btnTambahDenda.ShadowDecoration.Parent = this.btnTambahDenda;
            this.btnTambahDenda.Size = new System.Drawing.Size(33, 36);
            this.btnTambahDenda.TabIndex = 51;
            this.btnTambahDenda.Text = "+";
            // 
            // KeranjangKerusakan
            // 
            this.KeranjangKerusakan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.KeranjangKerusakan.FullRowSelect = true;
            this.KeranjangKerusakan.HideSelection = false;
            this.KeranjangKerusakan.Location = new System.Drawing.Point(98, 552);
            this.KeranjangKerusakan.Name = "KeranjangKerusakan";
            this.KeranjangKerusakan.Size = new System.Drawing.Size(393, 106);
            this.KeranjangKerusakan.TabIndex = 50;
            this.KeranjangKerusakan.UseCompatibleStateImageBehavior = false;
            this.KeranjangKerusakan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Peminjaman";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Denda";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jenis Kerusakan";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Harga Denda";
            this.columnHeader4.Width = 100;
            // 
            // cbKerusakanRuangan
            // 
            this.cbKerusakanRuangan.BackColor = System.Drawing.Color.Transparent;
            this.cbKerusakanRuangan.DisplayMember = "deskripsiKerusakan";
            this.cbKerusakanRuangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKerusakanRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKerusakanRuangan.FocusedColor = System.Drawing.Color.Empty;
            this.cbKerusakanRuangan.FocusedState.Parent = this.cbKerusakanRuangan;
            this.cbKerusakanRuangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKerusakanRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKerusakanRuangan.FormattingEnabled = true;
            this.cbKerusakanRuangan.HoverState.Parent = this.cbKerusakanRuangan;
            this.cbKerusakanRuangan.ItemHeight = 30;
            this.cbKerusakanRuangan.ItemsAppearance.Parent = this.cbKerusakanRuangan;
            this.cbKerusakanRuangan.Location = new System.Drawing.Point(98, 468);
            this.cbKerusakanRuangan.Name = "cbKerusakanRuangan";
            this.cbKerusakanRuangan.ShadowDecoration.Parent = this.cbKerusakanRuangan;
            this.cbKerusakanRuangan.Size = new System.Drawing.Size(210, 36);
            this.cbKerusakanRuangan.TabIndex = 49;
            this.cbKerusakanRuangan.ValueMember = "idDendaKerusakanRuangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kondisi Barang";
            // 
            // rbTidakRusak
            // 
            this.rbTidakRusak.AutoSize = true;
            this.rbTidakRusak.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakRusak.CheckedState.BorderThickness = 0;
            this.rbTidakRusak.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakRusak.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTidakRusak.CheckedState.InnerOffset = -4;
            this.rbTidakRusak.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.rbTidakRusak.Location = new System.Drawing.Point(189, 428);
            this.rbTidakRusak.Name = "rbTidakRusak";
            this.rbTidakRusak.Size = new System.Drawing.Size(119, 30);
            this.rbTidakRusak.TabIndex = 47;
            this.rbTidakRusak.TabStop = true;
            this.rbTidakRusak.Text = "Tidak Rusak";
            this.rbTidakRusak.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTidakRusak.UncheckedState.BorderThickness = 2;
            this.rbTidakRusak.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTidakRusak.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTidakRusak.UseVisualStyleBackColor = true;
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
            this.rbRusak.Location = new System.Drawing.Point(98, 428);
            this.rbRusak.Name = "rbRusak";
            this.rbRusak.Size = new System.Drawing.Size(75, 30);
            this.rbRusak.TabIndex = 46;
            this.rbRusak.TabStop = true;
            this.rbRusak.Text = "Rusak";
            this.rbRusak.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbRusak.UncheckedState.BorderThickness = 2;
            this.rbRusak.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRusak.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbRusak.UseVisualStyleBackColor = true;
            // 
            // rbHilang
            // 
            this.rbHilang.AutoSize = true;
            this.rbHilang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbHilang.CheckedState.BorderThickness = 0;
            this.rbHilang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbHilang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbHilang.CheckedState.InnerOffset = -4;
            this.rbHilang.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.rbHilang.Location = new System.Drawing.Point(324, 428);
            this.rbHilang.Name = "rbHilang";
            this.rbHilang.Size = new System.Drawing.Size(78, 30);
            this.rbHilang.TabIndex = 53;
            this.rbHilang.TabStop = true;
            this.rbHilang.Text = "Hilang";
            this.rbHilang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbHilang.UncheckedState.BorderThickness = 2;
            this.rbHilang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbHilang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbHilang.UseVisualStyleBackColor = true;
            // 
            // keranjangBarang
            // 
            this.keranjangBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.keranjangBarang.FullRowSelect = true;
            this.keranjangBarang.HideSelection = false;
            this.keranjangBarang.Location = new System.Drawing.Point(445, 337);
            this.keranjangBarang.Name = "keranjangBarang";
            this.keranjangBarang.Size = new System.Drawing.Size(393, 120);
            this.keranjangBarang.TabIndex = 54;
            this.keranjangBarang.UseCompatibleStateImageBehavior = false;
            this.keranjangBarang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID Peminjaman";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID Barang";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nama Barang";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Qty";
            this.columnHeader8.Width = 80;
            // 
            // Kolom1
            // 
            this.Kolom1.DataPropertyName = "idPeminjamanBarang";
            this.Kolom1.HeaderText = "ID Peminjaman";
            this.Kolom1.Name = "Kolom1";
            this.Kolom1.ReadOnly = true;
            // 
            // Kolom2
            // 
            this.Kolom2.DataPropertyName = "idUser";
            this.Kolom2.HeaderText = "idUser";
            this.Kolom2.Name = "Kolom2";
            this.Kolom2.ReadOnly = true;
            this.Kolom2.Visible = false;
            // 
            // Kolom3
            // 
            this.Kolom3.DataPropertyName = "namaUser";
            this.Kolom3.HeaderText = "Nama Peminjam";
            this.Kolom3.Name = "Kolom3";
            this.Kolom3.ReadOnly = true;
            // 
            // Kolom4
            // 
            this.Kolom4.DataPropertyName = "tanggalPeminjaman";
            this.Kolom4.HeaderText = "Tanggal Peminjaman";
            this.Kolom4.Name = "Kolom4";
            this.Kolom4.ReadOnly = true;
            // 
            // Kolom5
            // 
            this.Kolom5.DataPropertyName = "statusPeminjaman";
            this.Kolom5.HeaderText = "Status";
            this.Kolom5.Name = "Kolom5";
            this.Kolom5.ReadOnly = true;
            // 
            // Kolom6
            // 
            this.Kolom6.DataPropertyName = "lamaPeminjaman";
            this.Kolom6.HeaderText = "Lama Peminjaman (Hari)";
            this.Kolom6.Name = "Kolom6";
            this.Kolom6.ReadOnly = true;
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
            this.btnKembalikan.Location = new System.Drawing.Point(698, 500);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.ShadowDecoration.Parent = this.btnKembalikan;
            this.btnKembalikan.Size = new System.Drawing.Size(140, 36);
            this.btnKembalikan.TabIndex = 55;
            this.btnKembalikan.Text = "Kembalikan";
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
            this.txtTotalDenda.Location = new System.Drawing.Point(445, 500);
            this.txtTotalDenda.Name = "txtTotalDenda";
            this.txtTotalDenda.PasswordChar = '\0';
            this.txtTotalDenda.PlaceholderText = "";
            this.txtTotalDenda.SelectedText = "";
            this.txtTotalDenda.ShadowDecoration.Parent = this.txtTotalDenda;
            this.txtTotalDenda.Size = new System.Drawing.Size(170, 36);
            this.txtTotalDenda.TabIndex = 56;
            // 
            // Denda
            // 
            this.Denda.AutoSize = true;
            this.Denda.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Denda.Location = new System.Drawing.Point(440, 471);
            this.Denda.Name = "Denda";
            this.Denda.Size = new System.Drawing.Size(103, 26);
            this.Denda.TabIndex = 57;
            this.Denda.Text = "Total Denda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Data Peminjaman Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 26);
            this.label6.TabIndex = 59;
            this.label6.Text = "Detail Peminjaman Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Detail Denda";
            // 
            // txtTotalTelatPengembalian
            // 
            this.txtTotalTelatPengembalian.BorderRadius = 4;
            this.txtTotalTelatPengembalian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalTelatPengembalian.DefaultText = "";
            this.txtTotalTelatPengembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalTelatPengembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalTelatPengembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTelatPengembalian.DisabledState.Parent = this.txtTotalTelatPengembalian;
            this.txtTotalTelatPengembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalTelatPengembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTelatPengembalian.FocusedState.Parent = this.txtTotalTelatPengembalian;
            this.txtTotalTelatPengembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalTelatPengembalian.HoverState.Parent = this.txtTotalTelatPengembalian;
            this.txtTotalTelatPengembalian.Location = new System.Drawing.Point(512, 579);
            this.txtTotalTelatPengembalian.Name = "txtTotalTelatPengembalian";
            this.txtTotalTelatPengembalian.PasswordChar = '\0';
            this.txtTotalTelatPengembalian.PlaceholderText = "";
            this.txtTotalTelatPengembalian.SelectedText = "";
            this.txtTotalTelatPengembalian.ShadowDecoration.Parent = this.txtTotalTelatPengembalian;
            this.txtTotalTelatPengembalian.Size = new System.Drawing.Size(170, 36);
            this.txtTotalTelatPengembalian.TabIndex = 61;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 4;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(720, 579);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(170, 36);
            this.guna2TextBox2.TabIndex = 62;
            // 
            // txtTotalDendaKerusakan
            // 
            this.txtTotalDendaKerusakan.BorderRadius = 4;
            this.txtTotalDendaKerusakan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDendaKerusakan.DefaultText = "";
            this.txtTotalDendaKerusakan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalDendaKerusakan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalDendaKerusakan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDendaKerusakan.DisabledState.Parent = this.txtTotalDendaKerusakan;
            this.txtTotalDendaKerusakan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalDendaKerusakan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDendaKerusakan.FocusedState.Parent = this.txtTotalDendaKerusakan;
            this.txtTotalDendaKerusakan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalDendaKerusakan.HoverState.Parent = this.txtTotalDendaKerusakan;
            this.txtTotalDendaKerusakan.Location = new System.Drawing.Point(512, 652);
            this.txtTotalDendaKerusakan.Name = "txtTotalDendaKerusakan";
            this.txtTotalDendaKerusakan.PasswordChar = '\0';
            this.txtTotalDendaKerusakan.PlaceholderText = "";
            this.txtTotalDendaKerusakan.SelectedText = "";
            this.txtTotalDendaKerusakan.ShadowDecoration.Parent = this.txtTotalDendaKerusakan;
            this.txtTotalDendaKerusakan.Size = new System.Drawing.Size(170, 36);
            this.txtTotalDendaKerusakan.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.Location = new System.Drawing.Point(512, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 64;
            this.label8.Text = "Total Telat Pengembalian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F);
            this.label9.Location = new System.Drawing.Point(513, 628);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "Total Telat Denda Kerusakan";
            // 
            // PengembalianBarangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 720);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalDendaKerusakan);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.txtTotalTelatPengembalian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Denda);
            this.Controls.Add(this.txtTotalDenda);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.keranjangBarang);
            this.Controls.Add(this.rbHilang);
            this.Controls.Add(this.btnHapusKerusakan);
            this.Controls.Add(this.btnTambahDenda);
            this.Controls.Add(this.KeranjangKerusakan);
            this.Controls.Add(this.cbKerusakanRuangan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTidakRusak);
            this.Controls.Add(this.rbRusak);
            this.Controls.Add(this.dgvTabelPeminjamanBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPeminjaman);
            this.Controls.Add(this.dtTanggalPengembalian);
            this.Controls.Add(this.dtTanggalPeminjaman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PengembalianBarangAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PengembalianBarangAdmin";
            this.Load += new System.EventHandler(this.PengembalianBarangAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelPeminjamanBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPeminjaman;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPengembalian;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTanggalPeminjaman;
        private System.Windows.Forms.DataGridView dgvTabelPeminjamanBarang;
        private Guna.UI2.WinForms.Guna2Button btnHapusKerusakan;
        private Guna.UI2.WinForms.Guna2Button btnTambahDenda;
        private System.Windows.Forms.ListView KeranjangKerusakan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2ComboBox cbKerusakanRuangan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rbTidakRusak;
        private Guna.UI2.WinForms.Guna2RadioButton rbRusak;
        private Guna.UI2.WinForms.Guna2RadioButton rbHilang;
        private System.Windows.Forms.ListView keranjangBarang;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolom6;
        private Guna.UI2.WinForms.Guna2Button btnKembalikan;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDenda;
        private System.Windows.Forms.Label Denda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalTelatPengembalian;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalDendaKerusakan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}