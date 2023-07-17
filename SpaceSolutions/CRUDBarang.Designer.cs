namespace SpaceSolutions
{
    partial class CRUDBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTabelBarang = new System.Windows.Forms.DataGridView();
            this.txtCariidBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.idBarangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriBarangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnTambah = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelBarang
            // 
            this.dgvTabelBarang.AllowUserToAddRows = false;
            this.dgvTabelBarang.AllowUserToDeleteRows = false;
            this.dgvTabelBarang.AllowUserToResizeColumns = false;
            this.dgvTabelBarang.AllowUserToResizeRows = false;
            this.dgvTabelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarangColumn,
            this.namaBarangColumn,
            this.kategoriBarangColumn,
            this.stokBarangColumn,
            this.statusColumn,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelBarang.DefaultCellStyle = dataGridViewCellStyle52;
            this.dgvTabelBarang.GridColor = System.Drawing.Color.White;
            this.dgvTabelBarang.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelBarang.MultiSelect = false;
            this.dgvTabelBarang.Name = "dgvTabelBarang";
            this.dgvTabelBarang.ReadOnly = true;
            this.dgvTabelBarang.RowHeadersVisible = false;
            this.dgvTabelBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelBarang.RowTemplate.Height = 35;
            this.dgvTabelBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelBarang.ShowEditingIcon = false;
            this.dgvTabelBarang.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelBarang.TabIndex = 5;
            this.dgvTabelBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelBarang_CellClick);
            // 
            // txtCariidBarang
            // 
            this.txtCariidBarang.BorderRadius = 5;
            this.txtCariidBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidBarang.DefaultText = "";
            this.txtCariidBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidBarang.DisabledState.Parent = this.txtCariidBarang;
            this.txtCariidBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidBarang.FocusedState.Parent = this.txtCariidBarang;
            this.txtCariidBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidBarang.HoverState.Parent = this.txtCariidBarang;
            this.txtCariidBarang.Location = new System.Drawing.Point(54, 143);
            this.txtCariidBarang.Name = "txtCariidBarang";
            this.txtCariidBarang.PasswordChar = '\0';
            this.txtCariidBarang.PlaceholderText = "Cari Berdasakan ID";
            this.txtCariidBarang.SelectedText = "";
            this.txtCariidBarang.ShadowDecoration.Parent = this.txtCariidBarang;
            this.txtCariidBarang.ShortcutsEnabled = false;
            this.txtCariidBarang.Size = new System.Drawing.Size(371, 37);
            this.txtCariidBarang.TabIndex = 6;
            // 
            // idBarangColumn
            // 
            this.idBarangColumn.DataPropertyName = "IdBarang";
            this.idBarangColumn.HeaderText = "ID Barang";
            this.idBarangColumn.Name = "idBarangColumn";
            this.idBarangColumn.ReadOnly = true;
            // 
            // namaBarangColumn
            // 
            this.namaBarangColumn.DataPropertyName = "namaBarang";
            this.namaBarangColumn.HeaderText = "Nama Barang";
            this.namaBarangColumn.Name = "namaBarangColumn";
            this.namaBarangColumn.ReadOnly = true;
            // 
            // kategoriBarangColumn
            // 
            this.kategoriBarangColumn.DataPropertyName = "kategoriBarang";
            this.kategoriBarangColumn.HeaderText = "Kategori Barang";
            this.kategoriBarangColumn.Name = "kategoriBarangColumn";
            this.kategoriBarangColumn.ReadOnly = true;
            // 
            // stokBarangColumn
            // 
            this.stokBarangColumn.DataPropertyName = "stokBarang";
            this.stokBarangColumn.HeaderText = "Stok Barang";
            this.stokBarangColumn.Name = "stokBarangColumn";
            this.stokBarangColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "status";
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Visible = false;
            // 
            // Column9
            // 
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle50.NullValue")));
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle50;
            this.Column9.FillWeight = 60F;
            this.Column9.HeaderText = "";
            this.Column9.Image = global::SpaceSolutions.Properties.Resources.Edit_CRUD_;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column10
            // 
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle51.NullValue")));
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle51;
            this.Column10.FillWeight = 60F;
            this.Column10.HeaderText = "";
            this.Column10.Image = global::SpaceSolutions.Properties.Resources.delete_CRUD;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(442, 146);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 27;
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
            this.btnRefesh.TabIndex = 26;
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
            this.btnTambah.TabIndex = 25;
            this.btnTambah.TabStop = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // CRUDBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTabelBarang);
            this.Controls.Add(this.txtCariidBarang);
            this.Name = "CRUDBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDBarang";
            this.Load += new System.EventHandler(this.CRUDBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTabelBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriBarangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokBarangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnTambah;
    }
}