namespace SpaceSolutions
{
    partial class UpdateRuangan
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLokasiRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbTidakTersedia = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTersedia = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbJenisRuangan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.jenisRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFasilitas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.fasilitasTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.FasilitasTableAdapter();
            this.jenisRuanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.JenisRuanganTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRuanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
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
            this.btnUpdate.Location = new System.Drawing.Point(131, 509);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(140, 36);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "Lokasi Ruangan";
            // 
            // txtLokasiRuangan
            // 
            this.txtLokasiRuangan.BorderRadius = 5;
            this.txtLokasiRuangan.BorderThickness = 2;
            this.txtLokasiRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLokasiRuangan.DefaultText = "";
            this.txtLokasiRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLokasiRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLokasiRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasiRuangan.DisabledState.Parent = this.txtLokasiRuangan;
            this.txtLokasiRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLokasiRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasiRuangan.FocusedState.Parent = this.txtLokasiRuangan;
            this.txtLokasiRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLokasiRuangan.HoverState.Parent = this.txtLokasiRuangan;
            this.txtLokasiRuangan.Location = new System.Drawing.Point(79, 419);
            this.txtLokasiRuangan.Name = "txtLokasiRuangan";
            this.txtLokasiRuangan.PasswordChar = '\0';
            this.txtLokasiRuangan.PlaceholderText = "";
            this.txtLokasiRuangan.SelectedText = "";
            this.txtLokasiRuangan.ShadowDecoration.Parent = this.txtLokasiRuangan;
            this.txtLokasiRuangan.Size = new System.Drawing.Size(250, 36);
            this.txtLokasiRuangan.TabIndex = 40;
            this.txtLokasiRuangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLokasiRuangan_KeyPress);
            // 
            // rbTidakTersedia
            // 
            this.rbTidakTersedia.AutoSize = true;
            this.rbTidakTersedia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakTersedia.CheckedState.BorderThickness = 0;
            this.rbTidakTersedia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTidakTersedia.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTidakTersedia.CheckedState.InnerOffset = -4;
            this.rbTidakTersedia.Font = new System.Drawing.Font("Poppins", 10F);
            this.rbTidakTersedia.Location = new System.Drawing.Point(194, 342);
            this.rbTidakTersedia.Name = "rbTidakTersedia";
            this.rbTidakTersedia.Size = new System.Drawing.Size(129, 29);
            this.rbTidakTersedia.TabIndex = 39;
            this.rbTidakTersedia.TabStop = true;
            this.rbTidakTersedia.Text = "Tidak Tersedia";
            this.rbTidakTersedia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTidakTersedia.UncheckedState.BorderThickness = 2;
            this.rbTidakTersedia.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTidakTersedia.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTidakTersedia.UseVisualStyleBackColor = true;
            // 
            // rbTersedia
            // 
            this.rbTersedia.AutoSize = true;
            this.rbTersedia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTersedia.CheckedState.BorderThickness = 0;
            this.rbTersedia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTersedia.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTersedia.CheckedState.InnerOffset = -4;
            this.rbTersedia.Font = new System.Drawing.Font("Poppins", 10F);
            this.rbTersedia.Location = new System.Drawing.Point(82, 342);
            this.rbTersedia.Name = "rbTersedia";
            this.rbTersedia.Size = new System.Drawing.Size(89, 29);
            this.rbTersedia.TabIndex = 38;
            this.rbTersedia.TabStop = true;
            this.rbTersedia.Text = "Tersedia";
            this.rbTersedia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTersedia.UncheckedState.BorderThickness = 2;
            this.rbTersedia.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTersedia.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTersedia.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ketersediaan Ruangan";
            // 
            // cbJenisRuangan
            // 
            this.cbJenisRuangan.BackColor = System.Drawing.Color.Transparent;
            this.cbJenisRuangan.BorderRadius = 5;
            this.cbJenisRuangan.BorderThickness = 2;
            this.cbJenisRuangan.DataSource = this.jenisRuanganBindingSource;
            this.cbJenisRuangan.DisplayMember = "namaJenisRuangan";
            this.cbJenisRuangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbJenisRuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisRuangan.FocusedColor = System.Drawing.Color.Empty;
            this.cbJenisRuangan.FocusedState.Parent = this.cbJenisRuangan;
            this.cbJenisRuangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbJenisRuangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbJenisRuangan.FormattingEnabled = true;
            this.cbJenisRuangan.HoverState.Parent = this.cbJenisRuangan;
            this.cbJenisRuangan.ItemHeight = 30;
            this.cbJenisRuangan.ItemsAppearance.Parent = this.cbJenisRuangan;
            this.cbJenisRuangan.Location = new System.Drawing.Point(76, 169);
            this.cbJenisRuangan.Name = "cbJenisRuangan";
            this.cbJenisRuangan.ShadowDecoration.Parent = this.cbJenisRuangan;
            this.cbJenisRuangan.Size = new System.Drawing.Size(250, 36);
            this.cbJenisRuangan.TabIndex = 36;
            this.cbJenisRuangan.ValueMember = "idJenisRuangan";
            // 
            // jenisRuanganBindingSource
            // 
            this.jenisRuanganBindingSource.DataMember = "JenisRuangan";
            this.jenisRuanganBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jenis Ruangan";
            // 
            // cbFasilitas
            // 
            this.cbFasilitas.BackColor = System.Drawing.Color.Transparent;
            this.cbFasilitas.BorderRadius = 5;
            this.cbFasilitas.BorderThickness = 2;
            this.cbFasilitas.DataSource = this.fasilitasBindingSource;
            this.cbFasilitas.DisplayMember = "namaFasilitas";
            this.cbFasilitas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFasilitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFasilitas.FocusedColor = System.Drawing.Color.Empty;
            this.cbFasilitas.FocusedState.Parent = this.cbFasilitas;
            this.cbFasilitas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFasilitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFasilitas.FormattingEnabled = true;
            this.cbFasilitas.HoverState.Parent = this.cbFasilitas;
            this.cbFasilitas.ItemHeight = 30;
            this.cbFasilitas.ItemsAppearance.Parent = this.cbFasilitas;
            this.cbFasilitas.Location = new System.Drawing.Point(73, 250);
            this.cbFasilitas.Name = "cbFasilitas";
            this.cbFasilitas.ShadowDecoration.Parent = this.cbFasilitas;
            this.cbFasilitas.Size = new System.Drawing.Size(250, 36);
            this.cbFasilitas.TabIndex = 34;
            this.cbFasilitas.ValueMember = "idFasilitas";
            // 
            // fasilitasBindingSource
            // 
            this.fasilitasBindingSource.DataMember = "Fasilitas";
            this.fasilitasBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fasilitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nama Ruangan";
            // 
            // txtNamaRuangan
            // 
            this.txtNamaRuangan.BorderRadius = 5;
            this.txtNamaRuangan.BorderThickness = 2;
            this.txtNamaRuangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaRuangan.DefaultText = "";
            this.txtNamaRuangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaRuangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaRuangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaRuangan.DisabledState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaRuangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaRuangan.FocusedState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaRuangan.HoverState.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.Location = new System.Drawing.Point(73, 86);
            this.txtNamaRuangan.Name = "txtNamaRuangan";
            this.txtNamaRuangan.PasswordChar = '\0';
            this.txtNamaRuangan.PlaceholderText = "";
            this.txtNamaRuangan.SelectedText = "";
            this.txtNamaRuangan.ShadowDecoration.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.Size = new System.Drawing.Size(250, 36);
            this.txtNamaRuangan.TabIndex = 30;
            this.txtNamaRuangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaRuangan_KeyPress);
            // 
            // fasilitasTableAdapter
            // 
            this.fasilitasTableAdapter.ClearBeforeFill = true;
            // 
            // jenisRuanganTableAdapter
            // 
            this.jenisRuanganTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(195, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 23);
            this.label9.TabIndex = 47;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(194, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(139, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(254, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(207, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "*";
            // 
            // UpdateRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 629);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLokasiRuangan);
            this.Controls.Add(this.rbTidakTersedia);
            this.Controls.Add(this.rbTersedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbJenisRuangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFasilitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamaRuangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRuangan";
            this.Load += new System.EventHandler(this.UpdateRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jenisRuanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtLokasiRuangan;
        private Guna.UI2.WinForms.Guna2RadioButton rbTidakTersedia;
        private Guna.UI2.WinForms.Guna2RadioButton rbTersedia;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbJenisRuangan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbFasilitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaRuangan;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource fasilitasBindingSource;
        private DSSpaceSolutionsTableAdapters.FasilitasTableAdapter fasilitasTableAdapter;
        private System.Windows.Forms.BindingSource jenisRuanganBindingSource;
        private DSSpaceSolutionsTableAdapters.JenisRuanganTableAdapter jenisRuanganTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}