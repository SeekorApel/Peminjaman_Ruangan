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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTabelFasilitas = new System.Windows.Forms.DataGridView();
            this.btnAddFasilitas = new Guna.UI2.WinForms.Guna2Button();
            this.txtCariidFasilitas = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdFasilitasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaFasilitasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelFasilitas)).BeginInit();
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
            this.dgvTabelFasilitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelFasilitas.ShowEditingIcon = false;
            this.dgvTabelFasilitas.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelFasilitas.TabIndex = 10;
            this.dgvTabelFasilitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelFasilitas_CellClick);
            // 
            // btnAddFasilitas
            // 
            this.btnAddFasilitas.BorderRadius = 5;
            this.btnAddFasilitas.CheckedState.Parent = this.btnAddFasilitas;
            this.btnAddFasilitas.CustomImages.Parent = this.btnAddFasilitas;
            this.btnAddFasilitas.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFasilitas.ForeColor = System.Drawing.Color.White;
            this.btnAddFasilitas.HoverState.Parent = this.btnAddFasilitas;
            this.btnAddFasilitas.Location = new System.Drawing.Point(840, 143);
            this.btnAddFasilitas.Name = "btnAddFasilitas";
            this.btnAddFasilitas.ShadowDecoration.Parent = this.btnAddFasilitas;
            this.btnAddFasilitas.Size = new System.Drawing.Size(80, 30);
            this.btnAddFasilitas.TabIndex = 12;
            this.btnAddFasilitas.Text = "Add";
            this.btnAddFasilitas.Click += new System.EventHandler(this.btnAddFasilitas_Click);
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
            this.txtCariidFasilitas.PlaceholderText = "Search by ID";
            this.txtCariidFasilitas.SelectedText = "";
            this.txtCariidFasilitas.ShadowDecoration.Parent = this.txtCariidFasilitas;
            this.txtCariidFasilitas.Size = new System.Drawing.Size(371, 30);
            this.txtCariidFasilitas.TabIndex = 11;
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
            // CRUDFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTabelFasilitas);
            this.Controls.Add(this.btnAddFasilitas);
            this.Controls.Add(this.txtCariidFasilitas);
            this.Name = "CRUDFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDFasilitas";
            this.Load += new System.EventHandler(this.CRUDFasilitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelFasilitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTabelFasilitas;
        private Guna.UI2.WinForms.Guna2Button btnAddFasilitas;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidFasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFasilitasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaFasilitasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}