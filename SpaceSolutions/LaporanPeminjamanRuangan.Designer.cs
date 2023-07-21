namespace SpaceSolutions
{
    partial class LaporanPeminjamanRuangan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laporanPeminjamanRuanganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laporanPeminjamanRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanPeminjamanRuanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanPeminjamanRuanganTableAdapter();
            this.cbFilterBulan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLihat = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laporanPeminjamanRuanganBindingSource1
            // 
            this.laporanPeminjamanRuanganBindingSource1.DataMember = "LaporanPeminjamanRuangan";
            this.laporanPeminjamanRuanganBindingSource1.DataSource = this.dSSpaceSolutions;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DSLaporanRuangan";
            reportDataSource5.Value = this.laporanPeminjamanRuanganBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanRuangan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // laporanPeminjamanRuanganBindingSource
            // 
            this.laporanPeminjamanRuanganBindingSource.DataMember = "LaporanPeminjamanRuangan";
            this.laporanPeminjamanRuanganBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // laporanPeminjamanRuanganTableAdapter
            // 
            this.laporanPeminjamanRuanganTableAdapter.ClearBeforeFill = true;
            // 
            // cbFilterBulan
            // 
            this.cbFilterBulan.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBulan.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBulan.FocusedState.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBulan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterBulan.FormattingEnabled = true;
            this.cbFilterBulan.HoverState.Parent = this.cbFilterBulan;
            this.cbFilterBulan.ItemHeight = 30;
            this.cbFilterBulan.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbFilterBulan.ItemsAppearance.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Location = new System.Drawing.Point(51, 52);
            this.cbFilterBulan.Name = "cbFilterBulan";
            this.cbFilterBulan.ShadowDecoration.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Size = new System.Drawing.Size(160, 36);
            this.cbFilterBulan.TabIndex = 1;
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterStatus.FocusedState.Parent = this.cbFilterStatus;
            this.cbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.HoverState.Parent = this.cbFilterStatus;
            this.cbFilterStatus.ItemHeight = 30;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "Di Pinjam",
            "Di Kembalikan"});
            this.cbFilterStatus.ItemsAppearance.Parent = this.cbFilterStatus;
            this.cbFilterStatus.Location = new System.Drawing.Point(488, 52);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.ShadowDecoration.Parent = this.cbFilterStatus;
            this.cbFilterStatus.Size = new System.Drawing.Size(160, 36);
            this.cbFilterStatus.TabIndex = 2;
            // 
            // txtTahun
            // 
            this.txtTahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahun.DefaultText = "";
            this.txtTahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.DisabledState.Parent = this.txtTahun;
            this.txtTahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.FocusedState.Parent = this.txtTahun;
            this.txtTahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.HoverState.Parent = this.txtTahun;
            this.txtTahun.Location = new System.Drawing.Point(266, 52);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PasswordChar = '\0';
            this.txtTahun.PlaceholderText = "";
            this.txtTahun.SelectedText = "";
            this.txtTahun.ShadowDecoration.Parent = this.txtTahun;
            this.txtTahun.Size = new System.Drawing.Size(160, 36);
            this.txtTahun.TabIndex = 3;
            this.txtTahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahun_KeyPress);
            // 
            // btnLihat
            // 
            this.btnLihat.BorderRadius = 5;
            this.btnLihat.CheckedState.Parent = this.btnLihat;
            this.btnLihat.CustomImages.Parent = this.btnLihat;
            this.btnLihat.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLihat.ForeColor = System.Drawing.Color.White;
            this.btnLihat.HoverState.Parent = this.btnLihat;
            this.btnLihat.Location = new System.Drawing.Point(411, 460);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.ShadowDecoration.Parent = this.btnLihat;
            this.btnLihat.Size = new System.Drawing.Size(140, 36);
            this.btnLihat.TabIndex = 4;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bulan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tahun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status Peminjaman";
            // 
            // LaporanPeminjamanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.cbFilterBulan);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanPeminjamanRuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanPeminjamanRuangan";
            this.Load += new System.EventHandler(this.LaporanPeminjamanRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSSpaceSolutions dSSpaceSolutions;
        private System.Windows.Forms.BindingSource laporanPeminjamanRuanganBindingSource;
        private DSSpaceSolutionsTableAdapters.LaporanPeminjamanRuanganTableAdapter laporanPeminjamanRuanganTableAdapter;
        private System.Windows.Forms.BindingSource laporanPeminjamanRuanganBindingSource1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBulan;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtTahun;
        private Guna.UI2.WinForms.Guna2Button btnLihat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}