namespace SpaceSolutions
{
    partial class InputRuangan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbFasilitas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbJenisRuangan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTersedia = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTidakTersedia = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLokasiRuangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.fasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fasilitasTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.FasilitasTableAdapter();
            this.jenisRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jenisRuanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.JenisRuanganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRuanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 3;
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
            this.txtNamaRuangan.Location = new System.Drawing.Point(73, 104);
            this.txtNamaRuangan.Name = "txtNamaRuangan";
            this.txtNamaRuangan.PasswordChar = '\0';
            this.txtNamaRuangan.PlaceholderText = "";
            this.txtNamaRuangan.SelectedText = "";
            this.txtNamaRuangan.ShadowDecoration.Parent = this.txtNamaRuangan;
            this.txtNamaRuangan.Size = new System.Drawing.Size(250, 36);
            this.txtNamaRuangan.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(333, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 18;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fasilitas";
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
            this.cbFasilitas.Location = new System.Drawing.Point(73, 186);
            this.cbFasilitas.Name = "cbFasilitas";
            this.cbFasilitas.ShadowDecoration.Parent = this.cbFasilitas;
            this.cbFasilitas.Size = new System.Drawing.Size(250, 36);
            this.cbFasilitas.TabIndex = 21;
            this.cbFasilitas.ValueMember = "idFasilitas";
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
            this.cbJenisRuangan.Location = new System.Drawing.Point(76, 269);
            this.cbJenisRuangan.Name = "cbJenisRuangan";
            this.cbJenisRuangan.ShadowDecoration.Parent = this.cbJenisRuangan;
            this.cbJenisRuangan.Size = new System.Drawing.Size(250, 36);
            this.cbJenisRuangan.TabIndex = 23;
            this.cbJenisRuangan.ValueMember = "idJenisRuangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Jenis Ruangan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ketersediaan Ruangan";
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
            this.rbTersedia.Location = new System.Drawing.Point(82, 360);
            this.rbTersedia.Name = "rbTersedia";
            this.rbTersedia.Size = new System.Drawing.Size(89, 29);
            this.rbTersedia.TabIndex = 25;
            this.rbTersedia.TabStop = true;
            this.rbTersedia.Text = "Tersedia";
            this.rbTersedia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTersedia.UncheckedState.BorderThickness = 2;
            this.rbTersedia.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTersedia.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTersedia.UseVisualStyleBackColor = true;
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
            this.rbTidakTersedia.Location = new System.Drawing.Point(194, 360);
            this.rbTidakTersedia.Name = "rbTidakTersedia";
            this.rbTidakTersedia.Size = new System.Drawing.Size(129, 29);
            this.rbTidakTersedia.TabIndex = 26;
            this.rbTidakTersedia.TabStop = true;
            this.rbTidakTersedia.Text = "Tidak Tersedia";
            this.rbTidakTersedia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTidakTersedia.UncheckedState.BorderThickness = 2;
            this.rbTidakTersedia.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTidakTersedia.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbTidakTersedia.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 28;
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
            this.txtLokasiRuangan.Location = new System.Drawing.Point(79, 437);
            this.txtLokasiRuangan.Name = "txtLokasiRuangan";
            this.txtLokasiRuangan.PasswordChar = '\0';
            this.txtLokasiRuangan.PlaceholderText = "";
            this.txtLokasiRuangan.SelectedText = "";
            this.txtLokasiRuangan.ShadowDecoration.Parent = this.txtLokasiRuangan;
            this.txtLokasiRuangan.Size = new System.Drawing.Size(250, 36);
            this.txtLokasiRuangan.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(132, 585);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(132, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasilitasBindingSource
            // 
            this.fasilitasBindingSource.DataMember = "Fasilitas";
            this.fasilitasBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // fasilitasTableAdapter
            // 
            this.fasilitasTableAdapter.ClearBeforeFill = true;
            // 
            // jenisRuanganBindingSource
            // 
            this.jenisRuanganBindingSource.DataMember = "JenisRuangan";
            this.jenisRuanganBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // jenisRuanganTableAdapter
            // 
            this.jenisRuanganTableAdapter.ClearBeforeFill = true;
            // 
            // InputRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 690);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLokasiRuangan);
            this.Controls.Add(this.rbTidakTersedia);
            this.Controls.Add(this.rbTersedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbJenisRuangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFasilitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamaRuangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputRuangan";
            this.Load += new System.EventHandler(this.InputRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisRuanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaRuangan;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFasilitas;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbJenisRuangan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rbTidakTersedia;
        private Guna.UI2.WinForms.Guna2RadioButton rbTersedia;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtLokasiRuangan;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource fasilitasBindingSource;
        private DSSpaceSolutionsTableAdapters.FasilitasTableAdapter fasilitasTableAdapter;
        private System.Windows.Forms.BindingSource jenisRuanganBindingSource;
        private DSSpaceSolutionsTableAdapters.JenisRuanganTableAdapter jenisRuanganTableAdapter;
    }
}