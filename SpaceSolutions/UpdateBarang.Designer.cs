namespace SpaceSolutions
{
    partial class UpdateBarang
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHargaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(335, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 40;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(125, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(140, 36);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Stok Barang";
            // 
            // txtStokBarang
            // 
            this.txtStokBarang.BorderRadius = 5;
            this.txtStokBarang.BorderThickness = 2;
            this.txtStokBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStokBarang.DefaultText = "";
            this.txtStokBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStokBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStokBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokBarang.DisabledState.Parent = this.txtStokBarang;
            this.txtStokBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokBarang.FocusedState.Parent = this.txtStokBarang;
            this.txtStokBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokBarang.HoverState.Parent = this.txtStokBarang;
            this.txtStokBarang.Location = new System.Drawing.Point(72, 266);
            this.txtStokBarang.Name = "txtStokBarang";
            this.txtStokBarang.PasswordChar = '\0';
            this.txtStokBarang.PlaceholderText = "";
            this.txtStokBarang.SelectedText = "";
            this.txtStokBarang.ShadowDecoration.Parent = this.txtStokBarang;
            this.txtStokBarang.Size = new System.Drawing.Size(250, 36);
            this.txtStokBarang.TabIndex = 37;
            this.txtStokBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokBarang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Harga Barang";
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.BorderRadius = 5;
            this.txtHargaBarang.BorderThickness = 2;
            this.txtHargaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHargaBarang.DefaultText = "";
            this.txtHargaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHargaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHargaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHargaBarang.DisabledState.Parent = this.txtHargaBarang;
            this.txtHargaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHargaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHargaBarang.FocusedState.Parent = this.txtHargaBarang;
            this.txtHargaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHargaBarang.HoverState.Parent = this.txtHargaBarang;
            this.txtHargaBarang.Location = new System.Drawing.Point(72, 192);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.PasswordChar = '\0';
            this.txtHargaBarang.PlaceholderText = "";
            this.txtHargaBarang.SelectedText = "";
            this.txtHargaBarang.ShadowDecoration.Parent = this.txtHargaBarang;
            this.txtHargaBarang.Size = new System.Drawing.Size(250, 36);
            this.txtHargaBarang.TabIndex = 35;
            this.txtHargaBarang.TextChanged += new System.EventHandler(this.txtHargaBarang_TextChanged);
            this.txtHargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBarang_KeyPress);
            this.txtHargaBarang.Leave += new System.EventHandler(this.txtHargaBarang_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BorderRadius = 5;
            this.txtNamaBarang.BorderThickness = 2;
            this.txtNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaBarang.DefaultText = "";
            this.txtNamaBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.DisabledState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.FocusedState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.HoverState.Parent = this.txtNamaBarang;
            this.txtNamaBarang.Location = new System.Drawing.Point(72, 117);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.PasswordChar = '\0';
            this.txtNamaBarang.PlaceholderText = "";
            this.txtNamaBarang.SelectedText = "";
            this.txtNamaBarang.ShadowDecoration.Parent = this.txtNamaBarang;
            this.txtNamaBarang.Size = new System.Drawing.Size(250, 36);
            this.txtNamaBarang.TabIndex = 33;
            this.txtNamaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaBarang_KeyPress);
            // 
            // UpdateBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStokBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHargaBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamaBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBarang";
            this.Load += new System.EventHandler(this.UpdateBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtStokBarang;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtHargaBarang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaBarang;
    }
}