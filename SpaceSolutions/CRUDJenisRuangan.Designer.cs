namespace SpaceSolutions
{
    partial class CRUDJenisRuangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTabelJenisRuangan = new System.Windows.Forms.DataGridView();
            this.idJenisRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaJenisRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapasitasRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddJenisRuangan = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariidJenisRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelJenisRuangan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(440, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 5;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(738, 143);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTabelJenisRuangan
            // 
            this.dgvTabelJenisRuangan.AllowUserToAddRows = false;
            this.dgvTabelJenisRuangan.AllowUserToDeleteRows = false;
            this.dgvTabelJenisRuangan.AllowUserToResizeColumns = false;
            this.dgvTabelJenisRuangan.AllowUserToResizeRows = false;
            this.dgvTabelJenisRuangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelJenisRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelJenisRuangan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelJenisRuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelJenisRuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelJenisRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelJenisRuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJenisRuanganColumn,
            this.namaJenisRuanganColumn,
            this.KapasitasRuanganColumn,
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
            this.dgvTabelJenisRuangan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelJenisRuangan.GridColor = System.Drawing.Color.White;
            this.dgvTabelJenisRuangan.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelJenisRuangan.MultiSelect = false;
            this.dgvTabelJenisRuangan.Name = "dgvTabelJenisRuangan";
            this.dgvTabelJenisRuangan.ReadOnly = true;
            this.dgvTabelJenisRuangan.RowHeadersVisible = false;
            this.dgvTabelJenisRuangan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelJenisRuangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelJenisRuangan.ShowEditingIcon = false;
            this.dgvTabelJenisRuangan.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelJenisRuangan.TabIndex = 10;
            this.dgvTabelJenisRuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelJenisRuangan_CellClick);
            // 
            // idJenisRuanganColumn
            // 
            this.idJenisRuanganColumn.DataPropertyName = "idJenisRuangan";
            this.idJenisRuanganColumn.HeaderText = "ID Jenis Ruangan";
            this.idJenisRuanganColumn.Name = "idJenisRuanganColumn";
            this.idJenisRuanganColumn.ReadOnly = true;
            // 
            // namaJenisRuanganColumn
            // 
            this.namaJenisRuanganColumn.DataPropertyName = "namaJenisRuangan";
            this.namaJenisRuanganColumn.HeaderText = "Nama Jenis Ruangan";
            this.namaJenisRuanganColumn.Name = "namaJenisRuanganColumn";
            this.namaJenisRuanganColumn.ReadOnly = true;
            // 
            // KapasitasRuanganColumn
            // 
            this.KapasitasRuanganColumn.DataPropertyName = "KapasitasRuangan";
            this.KapasitasRuanganColumn.HeaderText = "Kapasitas Ruangan";
            this.KapasitasRuanganColumn.Name = "KapasitasRuanganColumn";
            this.KapasitasRuanganColumn.ReadOnly = true;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Text = "Update";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Text = "Delete";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // btnAddJenisRuangan
            // 
            this.btnAddJenisRuangan.BorderRadius = 5;
            this.btnAddJenisRuangan.CheckedState.Parent = this.btnAddJenisRuangan;
            this.btnAddJenisRuangan.CustomImages.Parent = this.btnAddJenisRuangan;
            this.btnAddJenisRuangan.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJenisRuangan.ForeColor = System.Drawing.Color.White;
            this.btnAddJenisRuangan.HoverState.Parent = this.btnAddJenisRuangan;
            this.btnAddJenisRuangan.Location = new System.Drawing.Point(840, 143);
            this.btnAddJenisRuangan.Name = "btnAddJenisRuangan";
            this.btnAddJenisRuangan.ShadowDecoration.Parent = this.btnAddJenisRuangan;
            this.btnAddJenisRuangan.Size = new System.Drawing.Size(80, 30);
            this.btnAddJenisRuangan.TabIndex = 12;
            this.btnAddJenisRuangan.Text = "Add";
            this.btnAddJenisRuangan.Click += new System.EventHandler(this.btnAddJenisRuangan_Click);
            // 
            // txtCariidJenisRuangan
            // 
            this.txtCariidJenisRuangan.BorderRadius = 5;
            this.txtCariidJenisRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidJenisRuangan.DefaultText = "";
            this.txtCariidJenisRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidJenisRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidJenisRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidJenisRuangan.DisabledState.Parent = this.txtCariidJenisRuangan;
            this.txtCariidJenisRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidJenisRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidJenisRuangan.FocusedState.Parent = this.txtCariidJenisRuangan;
            this.txtCariidJenisRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidJenisRuangan.HoverState.Parent = this.txtCariidJenisRuangan;
            this.txtCariidJenisRuangan.Location = new System.Drawing.Point(53, 143);
            this.txtCariidJenisRuangan.Name = "txtCariidJenisRuangan";
            this.txtCariidJenisRuangan.PasswordChar = '\0';
            this.txtCariidJenisRuangan.PlaceholderText = "Search by ID";
            this.txtCariidJenisRuangan.SelectedText = "";
            this.txtCariidJenisRuangan.ShadowDecoration.Parent = this.txtCariidJenisRuangan;
            this.txtCariidJenisRuangan.Size = new System.Drawing.Size(371, 30);
            this.txtCariidJenisRuangan.TabIndex = 11;
            // 
            // CRUDJenisRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTabelJenisRuangan);
            this.Controls.Add(this.btnAddJenisRuangan);
            this.Controls.Add(this.txtCariidJenisRuangan);
            this.Name = "CRUDJenisRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDJenisRuangan";
            this.Load += new System.EventHandler(this.CRUDJenisRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelJenisRuangan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTabelJenisRuangan;
        private Guna.UI2.WinForms.Guna2Button btnAddJenisRuangan;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidJenisRuangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJenisRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaJenisRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapasitasRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}