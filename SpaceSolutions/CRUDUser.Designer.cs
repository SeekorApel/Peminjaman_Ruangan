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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCariidUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvTabelUser = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.btnRefesh = new System.Windows.Forms.PictureBox();
            this.btnTambah = new System.Windows.Forms.PictureBox();
            this.idUserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).BeginInit();
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
            this.txtCariidUser.PlaceholderText = "Cari Berdasarkan ID";
            this.txtCariidUser.SelectedText = "";
            this.txtCariidUser.ShadowDecoration.Parent = this.txtCariidUser;
            this.txtCariidUser.Size = new System.Drawing.Size(371, 37);
            this.txtCariidUser.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelUser.GridColor = System.Drawing.Color.White;
            this.dgvTabelUser.Location = new System.Drawing.Point(54, 196);
            this.dgvTabelUser.MultiSelect = false;
            this.dgvTabelUser.Name = "dgvTabelUser";
            this.dgvTabelUser.ReadOnly = true;
            this.dgvTabelUser.RowHeadersVisible = false;
            this.dgvTabelUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTabelUser.RowTemplate.Height = 35;
            this.dgvTabelUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelUser.ShowEditingIcon = false;
            this.dgvTabelUser.Size = new System.Drawing.Size(869, 384);
            this.dgvTabelUser.TabIndex = 0;
            this.dgvTabelUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelUser_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(135)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SpaceSolutions.Properties.Resources.Edit_CRUD_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 109;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::SpaceSolutions.Properties.Resources.delete_CRUD;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 108;
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(442, 146);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 7;
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
            this.btnRefesh.TabIndex = 6;
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
            this.btnTambah.TabIndex = 5;
            this.btnTambah.TabStop = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.passwordColumn.Visible = false;
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
            this.roleColumn.HeaderText = "Hak Akses";
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
            // CRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTabelUser);
            this.Controls.Add(this.txtCariidUser);
            this.Name = "CRUDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formCRUDUser";
            this.Load += new System.EventHandler(this.formCRUDUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCariidUser;
        private System.Windows.Forms.DataGridView dgvTabelUser;
        private System.Windows.Forms.PictureBox btnTambah;
        private System.Windows.Forms.PictureBox btnRefesh;
        private System.Windows.Forms.PictureBox btnCari;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
    }
}