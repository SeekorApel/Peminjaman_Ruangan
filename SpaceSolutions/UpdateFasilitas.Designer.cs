namespace SpaceSolutions
{
    partial class UpdateFasilitas
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
            this.txtJumlahBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.keranjangDetail = new System.Windows.Forms.ListView();
            this.idFasilitascolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idBarangcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namaBarangcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtycolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIDBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTabelBarang = new System.Windows.Forms.DataGridView();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.txtNamaFasilitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.barangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.BarangTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.PictureBox();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.txtCariBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.idBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJumlahBarang
            // 
            this.txtJumlahBarang.BorderRadius = 3;
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
            this.txtJumlahBarang.TabIndex = 34;
            this.txtJumlahBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBarang_KeyPress);
            this.txtJumlahBarang.Leave += new System.EventHandler(this.txtJumlahBarang_Leave);
            // 
            // keranjangDetail
            // 
            this.keranjangDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idFasilitascolumn,
            this.idBarangcolumn,
            this.namaBarangcolumn,
            this.qtycolumn});
            this.keranjangDetail.FullRowSelect = true;
            this.keranjangDetail.HideSelection = false;
            this.keranjangDetail.Location = new System.Drawing.Point(372, 79);
            this.keranjangDetail.Name = "keranjangDetail";
            this.keranjangDetail.Size = new System.Drawing.Size(327, 126);
            this.keranjangDetail.TabIndex = 32;
            this.keranjangDetail.UseCompatibleStateImageBehavior = false;
            this.keranjangDetail.View = System.Windows.Forms.View.Details;
            this.keranjangDetail.SelectedIndexChanged += new System.EventHandler(this.keranjangDetail_SelectedIndexChanged);
            this.keranjangDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keranjangDetail_MouseDoubleClick);
            // 
            // idFasilitascolumn
            // 
            this.idFasilitascolumn.Text = "ID Fasilitas";
            this.idFasilitascolumn.Width = 80;
            // 
            // idBarangcolumn
            // 
            this.idBarangcolumn.Text = "ID Barang";
            this.idBarangcolumn.Width = 80;
            // 
            // namaBarangcolumn
            // 
            this.namaBarangcolumn.Text = "Nama Barang";
            this.namaBarangcolumn.Width = 100;
            // 
            // qtycolumn
            // 
            this.qtycolumn.Text = "Qty";
            // 
            // txtIDBarang
            // 
            this.txtIDBarang.BorderRadius = 3;
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
            this.txtIDBarang.Location = new System.Drawing.Point(100, 150);
            this.txtIDBarang.Name = "txtIDBarang";
            this.txtIDBarang.PasswordChar = '\0';
            this.txtIDBarang.PlaceholderText = "Masukan ID Barang";
            this.txtIDBarang.SelectedText = "";
            this.txtIDBarang.ShadowDecoration.Parent = this.txtIDBarang;
            this.txtIDBarang.Size = new System.Drawing.Size(250, 36);
            this.txtIDBarang.TabIndex = 27;
            this.txtIDBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDBarang_KeyPress);
            this.txtIDBarang.Leave += new System.EventHandler(this.txtTambahIDBarang_Leave);
            // 
            // dgvTabelBarang
            // 
            this.dgvTabelBarang.AllowUserToAddRows = false;
            this.dgvTabelBarang.AllowUserToDeleteRows = false;
            this.dgvTabelBarang.AutoGenerateColumns = false;
            this.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.hargaBarangDataGridViewTextBoxColumn,
            this.stokBarangDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvTabelBarang.DataSource = this.barangBindingSource;
            this.dgvTabelBarang.Location = new System.Drawing.Point(100, 301);
            this.dgvTabelBarang.Name = "dgvTabelBarang";
            this.dgvTabelBarang.ReadOnly = true;
            this.dgvTabelBarang.RowHeadersVisible = false;
            this.dgvTabelBarang.Size = new System.Drawing.Size(304, 150);
            this.dgvTabelBarang.TabIndex = 23;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNamaFasilitas
            // 
            this.txtNamaFasilitas.BorderRadius = 3;
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
            this.txtNamaFasilitas.PlaceholderText = "Masukan Nama Fasilitas";
            this.txtNamaFasilitas.SelectedText = "";
            this.txtNamaFasilitas.ShadowDecoration.Parent = this.txtNamaFasilitas;
            this.txtNamaFasilitas.Size = new System.Drawing.Size(250, 36);
            this.txtNamaFasilitas.TabIndex = 22;
            this.txtNamaFasilitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaFasilitas_KeyPress);
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.Location = new System.Drawing.Point(99, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Jumlah Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F);
            this.label5.Location = new System.Drawing.Point(97, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F);
            this.label6.Location = new System.Drawing.Point(97, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nama Fasilitas";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(371, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Detail Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.Location = new System.Drawing.Point(99, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data Barang";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Image = global::SpaceSolutions.Properties.Resources.Save_2;
            this.btnSimpan.Location = new System.Drawing.Point(376, 222);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(35, 35);
            this.btnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSimpan.TabIndex = 53;
            this.btnSimpan.TabStop = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(637, 302);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(30, 30);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 52;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Image = global::SpaceSolutions.Properties.Resources.Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(439, 222);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(35, 35);
            this.btnRefesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefesh.TabIndex = 51;
            this.btnRefesh.TabStop = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
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
            this.txtCariBarang.Location = new System.Drawing.Point(425, 301);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.PasswordChar = '\0';
            this.txtCariBarang.PlaceholderText = "Cari Nama Barang";
            this.txtCariBarang.SelectedText = "";
            this.txtCariBarang.ShadowDecoration.Parent = this.txtCariBarang;
            this.txtCariBarang.Size = new System.Drawing.Size(196, 36);
            this.txtCariBarang.TabIndex = 54;
            // 
            // idBarangDataGridViewTextBoxColumn
            // 
            this.idBarangDataGridViewTextBoxColumn.DataPropertyName = "IdBarang";
            this.idBarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.idBarangDataGridViewTextBoxColumn.Name = "idBarangDataGridViewTextBoxColumn";
            this.idBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaBarangDataGridViewTextBoxColumn
            // 
            this.hargaBarangDataGridViewTextBoxColumn.DataPropertyName = "hargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.HeaderText = "hargaBarang";
            this.hargaBarangDataGridViewTextBoxColumn.Name = "hargaBarangDataGridViewTextBoxColumn";
            this.hargaBarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargaBarangDataGridViewTextBoxColumn.Visible = false;
            // 
            // stokBarangDataGridViewTextBoxColumn
            // 
            this.stokBarangDataGridViewTextBoxColumn.DataPropertyName = "stokBarang";
            this.stokBarangDataGridViewTextBoxColumn.HeaderText = "Stok Barang";
            this.stokBarangDataGridViewTextBoxColumn.Name = "stokBarangDataGridViewTextBoxColumn";
            this.stokBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // UpdateFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 500);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJumlahBarang);
            this.Controls.Add(this.keranjangDetail);
            this.Controls.Add(this.txtIDBarang);
            this.Controls.Add(this.dgvTabelBarang);
            this.Controls.Add(this.txtNamaFasilitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFasilitas";
            this.Load += new System.EventHandler(this.UpdateFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtJumlahBarang;
        private System.Windows.Forms.ListView keranjangDetail;
        private System.Windows.Forms.ColumnHeader idFasilitascolumn;
        private System.Windows.Forms.ColumnHeader idBarangcolumn;
        private System.Windows.Forms.ColumnHeader namaBarangcolumn;
        private System.Windows.Forms.ColumnHeader qtycolumn;
        private Guna.UI2.WinForms.Guna2TextBox txtIDBarang;
        private System.Windows.Forms.DataGridView dgvTabelBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaFasilitas;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private DSSpaceSolutionsTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSimpan;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private Guna.UI2.WinForms.Guna2TextBox txtCariBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}