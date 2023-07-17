namespace SpaceSolutions
{
    partial class CRUDFasilitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDFasilitas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTabelFasilitas = new System.Windows.Forms.DataGridView();
            this.txtCariidFasilitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnTambah = new System.Windows.Forms.PictureBox();
            this.IdFasilitasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaFasilitasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelFasilitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelFasilitas
            // 
            this.dgvTabelFasilitas.AllowUserToAddRows = false;
            this.dgvTabelFasilitas.AllowUserToDeleteRows = false;
            this.dgvTabelFasilitas.AllowUserToResizeColumns = false;
            this.dgvTabelFasilitas.AllowUserToResizeRows = false;
            this.dgvTabelFasilitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelFasilitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelFasilitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelFasilitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelFasilitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelFasilitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFasilitasColumn,
            this.namaFasilitasColumn,
            this.statusColumn,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelFasilitas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelFasilitas.GridColor = System.Drawing.Color.White;
            this.dgvTabelFasilitas.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelFasilitas.MultiSelect = false;
            this.dgvTabelFasilitas.Name = "dgvTabelFasilitas";
            this.dgvTabelFasilitas.ReadOnly = true;
            this.dgvTabelFasilitas.RowHeadersVisible = false;
            this.dgvTabelFasilitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelFasilitas.RowTemplate.Height = 35;
            this.dgvTabelFasilitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelFasilitas.ShowEditingIcon = false;
            this.dgvTabelFasilitas.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelFasilitas.TabIndex = 10;
            this.dgvTabelFasilitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelFasilitas_CellClick);
            // 
            // txtCariidFasilitas
            // 
            this.txtCariidFasilitas.BorderRadius = 5;
            this.txtCariidFasilitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidFasilitas.DefaultText = "";
            this.txtCariidFasilitas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidFasilitas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidFasilitas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidFasilitas.DisabledState.Parent = this.txtCariidFasilitas;
            this.txtCariidFasilitas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidFasilitas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidFasilitas.FocusedState.Parent = this.txtCariidFasilitas;
            this.txtCariidFasilitas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidFasilitas.HoverState.Parent = this.txtCariidFasilitas;
            this.txtCariidFasilitas.Location = new System.Drawing.Point(54, 143);
            this.txtCariidFasilitas.Name = "txtCariidFasilitas";
            this.txtCariidFasilitas.PasswordChar = '\0';
            this.txtCariidFasilitas.PlaceholderText = "Cari Berdasarkan ID";
            this.txtCariidFasilitas.SelectedText = "";
            this.txtCariidFasilitas.ShadowDecoration.Parent = this.txtCariidFasilitas;
            this.txtCariidFasilitas.Size = new System.Drawing.Size(371, 37);
            this.txtCariidFasilitas.TabIndex = 11;
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(442, 146);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 24;
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
            this.btnRefesh.TabIndex = 23;
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
            this.btnTambah.TabIndex = 22;
            this.btnTambah.TabStop = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // IdFasilitasColumn
            // 
            this.IdFasilitasColumn.DataPropertyName = "IdFasilitas";
            this.IdFasilitasColumn.HeaderText = "ID Fasilitas";
            this.IdFasilitasColumn.Name = "IdFasilitasColumn";
            this.IdFasilitasColumn.ReadOnly = true;
            // 
            // namaFasilitasColumn
            // 
            this.namaFasilitasColumn.DataPropertyName = "namaFasilitas";
            this.namaFasilitasColumn.HeaderText = "Nama Fasilitas";
            this.namaFasilitasColumn.Name = "namaFasilitasColumn";
            this.namaFasilitasColumn.ReadOnly = true;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.FillWeight = 35F;
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
            this.Column10.FillWeight = 35F;
            this.Column10.HeaderText = "";
            this.Column10.Image = global::SpaceSolutions.Properties.Resources.delete_CRUD;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CRUDFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTabelFasilitas);
            this.Controls.Add(this.txtCariidFasilitas);
            this.Name = "CRUDFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDFasilitas";
            this.Load += new System.EventHandler(this.CRUDFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelFasilitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTabelFasilitas;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidFasilitas;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFasilitasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaFasilitasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
    }
}