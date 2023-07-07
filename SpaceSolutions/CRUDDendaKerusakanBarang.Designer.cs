namespace SpaceSolutions
{
    partial class CRUDDendaKerusakanBarang
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
            this.dgvTabelDendaKerusakanBarang = new System.Windows.Forms.DataGridView();
            this.idDendaKerusakanBarangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiKerusakanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biayaDendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddBarang = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariidDendaKerusakanBarang = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelDendaKerusakanBarang)).BeginInit();
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
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTabelDendaKerusakanBarang
            // 
            this.dgvTabelDendaKerusakanBarang.AllowUserToAddRows = false;
            this.dgvTabelDendaKerusakanBarang.AllowUserToDeleteRows = false;
            this.dgvTabelDendaKerusakanBarang.AllowUserToResizeColumns = false;
            this.dgvTabelDendaKerusakanBarang.AllowUserToResizeRows = false;
            this.dgvTabelDendaKerusakanBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelDendaKerusakanBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelDendaKerusakanBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelDendaKerusakanBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelDendaKerusakanBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelDendaKerusakanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelDendaKerusakanBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDendaKerusakanBarangColumn,
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
            this.dgvTabelDendaKerusakanBarang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelDendaKerusakanBarang.GridColor = System.Drawing.Color.White;
            this.dgvTabelDendaKerusakanBarang.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelDendaKerusakanBarang.MultiSelect = false;
            this.dgvTabelDendaKerusakanBarang.Name = "dgvTabelDendaKerusakanBarang";
            this.dgvTabelDendaKerusakanBarang.ReadOnly = true;
            this.dgvTabelDendaKerusakanBarang.RowHeadersVisible = false;
            this.dgvTabelDendaKerusakanBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelDendaKerusakanBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelDendaKerusakanBarang.ShowEditingIcon = false;
            this.dgvTabelDendaKerusakanBarang.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelDendaKerusakanBarang.TabIndex = 10;
            this.dgvTabelDendaKerusakanBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelDendaKerusakanBarang_CellClick);
            // 
            // idDendaKerusakanBarangColumn
            // 
            this.idDendaKerusakanBarangColumn.DataPropertyName = "idDendaKerusakanBarang";
            this.idDendaKerusakanBarangColumn.HeaderText = "ID Denda";
            this.idDendaKerusakanBarangColumn.Name = "idDendaKerusakanBarangColumn";
            this.idDendaKerusakanBarangColumn.ReadOnly = true;
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
            this.btnAddBarang.TabIndex = 12;
            this.btnAddBarang.Text = "Add";
            this.btnAddBarang.Click += new System.EventHandler(this.btnAddBarang_Click);
            // 
            // txtCariidDendaKerusakanBarang
            // 
            this.txtCariidDendaKerusakanBarang.BorderRadius = 5;
            this.txtCariidDendaKerusakanBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidDendaKerusakanBarang.DefaultText = "";
            this.txtCariidDendaKerusakanBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidDendaKerusakanBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidDendaKerusakanBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidDendaKerusakanBarang.DisabledState.Parent = this.txtCariidDendaKerusakanBarang;
            this.txtCariidDendaKerusakanBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidDendaKerusakanBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidDendaKerusakanBarang.FocusedState.Parent = this.txtCariidDendaKerusakanBarang;
            this.txtCariidDendaKerusakanBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidDendaKerusakanBarang.HoverState.Parent = this.txtCariidDendaKerusakanBarang;
            this.txtCariidDendaKerusakanBarang.Location = new System.Drawing.Point(54, 143);
            this.txtCariidDendaKerusakanBarang.Name = "txtCariidDendaKerusakanBarang";
            this.txtCariidDendaKerusakanBarang.PasswordChar = '\0';
            this.txtCariidDendaKerusakanBarang.PlaceholderText = "Search by ID";
            this.txtCariidDendaKerusakanBarang.SelectedText = "";
            this.txtCariidDendaKerusakanBarang.ShadowDecoration.Parent = this.txtCariidDendaKerusakanBarang;
            this.txtCariidDendaKerusakanBarang.Size = new System.Drawing.Size(371, 30);
            this.txtCariidDendaKerusakanBarang.TabIndex = 11;
            // 
            // CRUDDendaKerusakanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTabelDendaKerusakanBarang);
            this.Controls.Add(this.btnAddBarang);
            this.Controls.Add(this.txtCariidDendaKerusakanBarang);
            this.Name = "CRUDDendaKerusakanBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDDendaKerusakanBarang";
            this.Load += new System.EventHandler(this.CRUDDendaKerusakanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelDendaKerusakanBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTabelDendaKerusakanBarang;
        private Guna.UI2.WinForms.Guna2Button btnAddBarang;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidDendaKerusakanBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDendaKerusakanBarangColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiKerusakanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biayaDendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}