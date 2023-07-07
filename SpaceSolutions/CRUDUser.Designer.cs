namespace SpaceSolutions.Page
{
    partial class CRUDUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCariidUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdduser = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTabelUser = new System.Windows.Forms.DataGridView();
            this.idUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCariidUser
            // 
            this.txtCariidUser.BorderRadius = 5;
            this.txtCariidUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidUser.DefaultText = "";
            this.txtCariidUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidUser.DisabledState.Parent = this.txtCariidUser;
            this.txtCariidUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidUser.FocusedState.Parent = this.txtCariidUser;
            this.txtCariidUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidUser.HoverState.Parent = this.txtCariidUser;
            this.txtCariidUser.Location = new System.Drawing.Point(54, 143);
            this.txtCariidUser.Name = "txtCariidUser";
            this.txtCariidUser.PasswordChar = '\0';
            this.txtCariidUser.PlaceholderText = "Search by ID";
            this.txtCariidUser.SelectedText = "";
            this.txtCariidUser.ShadowDecoration.Parent = this.txtCariidUser;
            this.txtCariidUser.Size = new System.Drawing.Size(371, 30);
            this.txtCariidUser.TabIndex = 0;
            // 
            // btnAdduser
            // 
            this.btnAdduser.BorderRadius = 5;
            this.btnAdduser.CheckedState.Parent = this.btnAdduser;
            this.btnAdduser.CustomImages.Parent = this.btnAdduser;
            this.btnAdduser.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.HoverState.Parent = this.btnAdduser;
            this.btnAdduser.Location = new System.Drawing.Point(840, 143);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.ShadowDecoration.Parent = this.btnAdduser;
            this.btnAdduser.Size = new System.Drawing.Size(80, 30);
            this.btnAdduser.TabIndex = 2;
            this.btnAdduser.Text = "Add";
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // dgvTabelUser
            // 
            this.dgvTabelUser.AllowUserToAddRows = false;
            this.dgvTabelUser.AllowUserToDeleteRows = false;
            this.dgvTabelUser.AllowUserToResizeColumns = false;
            this.dgvTabelUser.AllowUserToResizeRows = false;
            this.dgvTabelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabelUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabelUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabelUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabelUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserColumn,
            this.namaColumn,
            this.usernameColumn,
            this.passwordColumn,
            this.noTelpColumn,
            this.jabatanColumn,
            this.roleColumn,
            this.statusColumn,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelUser.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTabelUser.GridColor = System.Drawing.Color.White;
            this.dgvTabelUser.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelUser.MultiSelect = false;
            this.dgvTabelUser.Name = "dgvTabelUser";
            this.dgvTabelUser.ReadOnly = true;
            this.dgvTabelUser.RowHeadersVisible = false;
            this.dgvTabelUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelUser.ShowEditingIcon = false;
            this.dgvTabelUser.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelUser.TabIndex = 0;
            this.dgvTabelUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelUser_CellClick);
            // 
            // idUserColumn
            // 
            this.idUserColumn.DataPropertyName = "idUser";
            this.idUserColumn.HeaderText = "ID User";
            this.idUserColumn.Name = "idUserColumn";
            this.idUserColumn.ReadOnly = true;
            // 
            // namaColumn
            // 
            this.namaColumn.DataPropertyName = "nama";
            this.namaColumn.HeaderText = "Nama";
            this.namaColumn.Name = "namaColumn";
            this.namaColumn.ReadOnly = true;
            // 
            // usernameColumn
            // 
            this.usernameColumn.DataPropertyName = "username";
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            this.passwordColumn.DataPropertyName = "password";
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            // 
            // noTelpColumn
            // 
            this.noTelpColumn.DataPropertyName = "noTelp";
            this.noTelpColumn.HeaderText = "No telp";
            this.noTelpColumn.Name = "noTelpColumn";
            this.noTelpColumn.ReadOnly = true;
            // 
            // jabatanColumn
            // 
            this.jabatanColumn.DataPropertyName = "jabatan";
            this.jabatanColumn.HeaderText = "Jabatan";
            this.jabatanColumn.Name = "jabatanColumn";
            this.jabatanColumn.ReadOnly = true;
            // 
            // roleColumn
            // 
            this.roleColumn.DataPropertyName = "role";
            this.roleColumn.HeaderText = "Role";
            this.roleColumn.Name = "roleColumn";
            this.roleColumn.ReadOnly = true;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Text = "Update";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Text = "Delete";
            this.Column10.UseColumnTextForButtonValue = true;
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
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(440, 143);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(80, 30);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvTabelUser);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.txtCariidUser);
            this.Name = "CRUDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formCRUDUser";
            this.Load += new System.EventHandler(this.formCRUDUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCariidUser;
        private Guna.UI2.WinForms.Guna2Button btnAdduser;
        private System.Windows.Forms.DataGridView dgvTabelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}