namespace SpaceSolutions
{
    partial class CRUDDendaKerusakanRuangan
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
            this.dgvTabelDendaKerusakanRuangan = new System.Windows.Forms.DataGridView();
            this.idDendaKerusakanRuanganColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiKerusakanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biayaDendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddBarang = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariidDendaKerusakanRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelDendaKerusakanRuangan)).BeginInit();
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
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTabelDendaKerusakanRuangan
            // 
            this.dgvTabelDendaKerusakanRuangan.AllowUserToAddRows = false;
            this.dgvTabelDendaKerusakanRuangan.AllowUserToDeleteRows = false;
            this.dgvTabelDendaKerusakanRuangan.AllowUserToResizeColumns = false;
            this.dgvTabelDendaKerusakanRuangan.AllowUserToResizeRows = false;
            this.dgvTabelDendaKerusakanRuangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelDendaKerusakanRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelDendaKerusakanRuangan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelDendaKerusakanRuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelDendaKerusakanRuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelDendaKerusakanRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelDendaKerusakanRuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDendaKerusakanRuanganColumn,
            this.deskripsiKerusakanColumn,
            this.biayaDendaColumn,
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
            this.dgvTabelDendaKerusakanRuangan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelDendaKerusakanRuangan.GridColor = System.Drawing.Color.White;
            this.dgvTabelDendaKerusakanRuangan.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelDendaKerusakanRuangan.MultiSelect = false;
            this.dgvTabelDendaKerusakanRuangan.Name = "dgvTabelDendaKerusakanRuangan";
            this.dgvTabelDendaKerusakanRuangan.ReadOnly = true;
            this.dgvTabelDendaKerusakanRuangan.RowHeadersVisible = false;
            this.dgvTabelDendaKerusakanRuangan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelDendaKerusakanRuangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelDendaKerusakanRuangan.ShowEditingIcon = false;
            this.dgvTabelDendaKerusakanRuangan.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelDendaKerusakanRuangan.TabIndex = 15;
            this.dgvTabelDendaKerusakanRuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelDendaKerusakanRuangan_CellClick);
            // 
            // idDendaKerusakanRuanganColumn
            // 
            this.idDendaKerusakanRuanganColumn.DataPropertyName = "idDendaKerusakanRuangan";
            this.idDendaKerusakanRuanganColumn.HeaderText = "ID Denda";
            this.idDendaKerusakanRuanganColumn.Name = "idDendaKerusakanRuanganColumn";
            this.idDendaKerusakanRuanganColumn.ReadOnly = true;
            // 
            // deskripsiKerusakanColumn
            // 
            this.deskripsiKerusakanColumn.DataPropertyName = "deskripsiKerusakan";
            this.deskripsiKerusakanColumn.HeaderText = "Deskripsi Kerusakan";
            this.deskripsiKerusakanColumn.Name = "deskripsiKerusakanColumn";
            this.deskripsiKerusakanColumn.ReadOnly = true;
            // 
            // biayaDendaColumn
            // 
            this.biayaDendaColumn.DataPropertyName = "biayaDenda";
            this.biayaDendaColumn.HeaderText = "Biaya Denda";
            this.biayaDendaColumn.Name = "biayaDendaColumn";
            this.biayaDendaColumn.ReadOnly = true;
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
            // btnAddBarang
            // 
            this.btnAddBarang.BorderRadius = 5;
            this.btnAddBarang.CheckedState.Parent = this.btnAddBarang;
            this.btnAddBarang.CustomImages.Parent = this.btnAddBarang;
            this.btnAddBarang.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBarang.ForeColor = System.Drawing.Color.White;
            this.btnAddBarang.HoverState.Parent = this.btnAddBarang;
            this.btnAddBarang.Location = new System.Drawing.Point(840, 143);
            this.btnAddBarang.Name = "btnAddBarang";
            this.btnAddBarang.ShadowDecoration.Parent = this.btnAddBarang;
            this.btnAddBarang.Size = new System.Drawing.Size(80, 30);
            this.btnAddBarang.TabIndex = 17;
            this.btnAddBarang.Text = "Add";
            this.btnAddBarang.Click += new System.EventHandler(this.btnAddBarang_Click);
            // 
            // txtCariidDendaKerusakanRuangan
            // 
            this.txtCariidDendaKerusakanRuangan.BorderRadius = 5;
            this.txtCariidDendaKerusakanRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidDendaKerusakanRuangan.DefaultText = "";
            this.txtCariidDendaKerusakanRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidDendaKerusakanRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidDendaKerusakanRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidDendaKerusakanRuangan.DisabledState.Parent = this.txtCariidDendaKerusakanRuangan;
            this.txtCariidDendaKerusakanRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidDendaKerusakanRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidDendaKerusakanRuangan.FocusedState.Parent = this.txtCariidDendaKerusakanRuangan;
            this.txtCariidDendaKerusakanRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidDendaKerusakanRuangan.HoverState.Parent = this.txtCariidDendaKerusakanRuangan;
            this.txtCariidDendaKerusakanRuangan.Location = new System.Drawing.Point(54, 143);
            this.txtCariidDendaKerusakanRuangan.Name = "txtCariidDendaKerusakanRuangan";
            this.txtCariidDendaKerusakanRuangan.PasswordChar = '\0';
            this.txtCariidDendaKerusakanRuangan.PlaceholderText = "Search by ID";
            this.txtCariidDendaKerusakanRuangan.SelectedText = "";
            this.txtCariidDendaKerusakanRuangan.ShadowDecoration.Parent = this.txtCariidDendaKerusakanRuangan;
            this.txtCariidDendaKerusakanRuangan.Size = new System.Drawing.Size(371, 30);
            this.txtCariidDendaKerusakanRuangan.TabIndex = 16;
            // 
            // CRUDDendaKerusakanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTabelDendaKerusakanRuangan);
            this.Controls.Add(this.btnAddBarang);
            this.Controls.Add(this.txtCariidDendaKerusakanRuangan);
            this.Name = "CRUDDendaKerusakanRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDDendaKerusakanRuangan";
            this.Load += new System.EventHandler(this.CRUDDendaKerusakanRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelDendaKerusakanRuangan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTabelDendaKerusakanRuangan;
        private Guna.UI2.WinForms.Guna2Button btnAddBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidDendaKerusakanRuangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDendaKerusakanRuanganColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiKerusakanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biayaDendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}