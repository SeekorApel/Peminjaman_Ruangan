namespace SpaceSolutions
{
    partial class CRUDRuangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDRuangan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCariidRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTabelRuangan = new System.Windows.Forms.DataGridView();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnTambah = new System.Windows.Forms.PictureBox();
            this.idRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaJenisRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaFasilitasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketersediaanRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelRuangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCariidRuangan
            // 
            this.txtCariidRuangan.BorderRadius = 5;
            this.txtCariidRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidRuangan.DefaultText = "";
            this.txtCariidRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidRuangan.DisabledState.Parent = this.txtCariidRuangan;
            this.txtCariidRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidRuangan.FocusedState.Parent = this.txtCariidRuangan;
            this.txtCariidRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidRuangan.HoverState.Parent = this.txtCariidRuangan;
            this.txtCariidRuangan.Location = new System.Drawing.Point(54, 143);
            this.txtCariidRuangan.Name = "txtCariidRuangan";
            this.txtCariidRuangan.PasswordChar = '\0';
            this.txtCariidRuangan.PlaceholderText = "Cari Berdasarkan ID";
            this.txtCariidRuangan.SelectedText = "";
            this.txtCariidRuangan.ShadowDecoration.Parent = this.txtCariidRuangan;
            this.txtCariidRuangan.ShortcutsEnabled = false;
            this.txtCariidRuangan.Size = new System.Drawing.Size(371, 37);
            this.txtCariidRuangan.TabIndex = 11;
            // 
            // dgvTabelRuangan
            // 
            this.dgvTabelRuangan.AllowUserToAddRows = false;
            this.dgvTabelRuangan.AllowUserToDeleteRows = false;
            this.dgvTabelRuangan.AllowUserToResizeColumns = false;
            this.dgvTabelRuangan.AllowUserToResizeRows = false;
            this.dgvTabelRuangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelRuangan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelRuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelRuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelRuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRuanganColumn,
            this.namaRuanganColumn,
            this.namaJenisRuanganColumn,
            this.namaFasilitasColumn,
            this.ketersediaanRuanganColumn,
            this.lokasiRuanganColumn,
            this.Column2,
            this.Column1,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelRuangan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelRuangan.GridColor = System.Drawing.Color.White;
            this.dgvTabelRuangan.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelRuangan.MultiSelect = false;
            this.dgvTabelRuangan.Name = "dgvTabelRuangan";
            this.dgvTabelRuangan.ReadOnly = true;
            this.dgvTabelRuangan.RowHeadersVisible = false;
            this.dgvTabelRuangan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelRuangan.RowTemplate.Height = 35;
            this.dgvTabelRuangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelRuangan.ShowEditingIcon = false;
            this.dgvTabelRuangan.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelRuangan.TabIndex = 15;
            this.dgvTabelRuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelRuangan_CellClick);
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(442, 146);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 18;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Image = global::SpaceSolutions.Properties.Resources.Refresh;
            this.btnRefesh.Location = new System.Drawing.Point(815, 145);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(35, 35);
            this.btnRefesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefesh.TabIndex = 17;
            this.btnRefesh.TabStop = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Image = global::SpaceSolutions.Properties.Resources.Add;
            this.btnTambah.Location = new System.Drawing.Point(873, 145);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(35, 35);
            this.btnTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTambah.TabIndex = 16;
            this.btnTambah.TabStop = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // idRuanganColumn
            // 
            this.idRuanganColumn.DataPropertyName = "idRuangan";
            this.idRuanganColumn.HeaderText = "ID Ruangan";
            this.idRuanganColumn.Name = "idRuanganColumn";
            this.idRuanganColumn.ReadOnly = true;
            // 
            // namaRuanganColumn
            // 
            this.namaRuanganColumn.DataPropertyName = "namaRuangan";
            this.namaRuanganColumn.HeaderText = "Nama Ruangan";
            this.namaRuanganColumn.Name = "namaRuanganColumn";
            this.namaRuanganColumn.ReadOnly = true;
            // 
            // namaJenisRuanganColumn
            // 
            this.namaJenisRuanganColumn.DataPropertyName = "namaJenisRuangan";
            this.namaJenisRuanganColumn.HeaderText = "Jenis Ruangan";
            this.namaJenisRuanganColumn.Name = "namaJenisRuanganColumn";
            this.namaJenisRuanganColumn.ReadOnly = true;
            // 
            // namaFasilitasColumn
            // 
            this.namaFasilitasColumn.DataPropertyName = "namaFasilitas";
            this.namaFasilitasColumn.HeaderText = "Fasilitas";
            this.namaFasilitasColumn.Name = "namaFasilitasColumn";
            this.namaFasilitasColumn.ReadOnly = true;
            // 
            // ketersediaanRuanganColumn
            // 
            this.ketersediaanRuanganColumn.DataPropertyName = "ketersediaanRuangan";
            this.ketersediaanRuanganColumn.HeaderText = "Ketersediaan Ruangan";
            this.ketersediaanRuanganColumn.Name = "ketersediaanRuanganColumn";
            this.ketersediaanRuanganColumn.ReadOnly = true;
            // 
            // lokasiRuanganColumn
            // 
            this.lokasiRuanganColumn.DataPropertyName = "lokasiRuangan";
            this.lokasiRuanganColumn.HeaderText = "Lokasi Ruangan";
            this.lokasiRuanganColumn.Name = "lokasiRuanganColumn";
            this.lokasiRuanganColumn.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "kapasitasRuangan";
            this.Column2.HeaderText = "Kapasitas Ruangan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "status";
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column9
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.FillWeight = 60F;
            this.Column9.HeaderText = "";
            this.Column9.Image = global::SpaceSolutions.Properties.Resources.Edit_CRUD_;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column10
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column10.FillWeight = 60F;
            this.Column10.HeaderText = "";
            this.Column10.Image = global::SpaceSolutions.Properties.Resources.delete_CRUD;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CRUDRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTabelRuangan);
            this.Controls.Add(this.txtCariidRuangan);
            this.Name = "CRUDRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDRuangan";
            this.Load += new System.EventHandler(this.CRUDRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtCariidRuangan;
        private System.Windows.Forms.DataGridView dgvTabelRuangan;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaJenisRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaFasilitasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketersediaanRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
    }
}