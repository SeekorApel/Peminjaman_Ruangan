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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laporanPeminjamanRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.laporanPeminjamanRuanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanPeminjamanRuanganTableAdapter();
            this.laporanPeminjamanRuanganBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbFilterBulan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLihat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DSLaporanRuangan";
            reportDataSource4.Value = this.laporanPeminjamanRuanganBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanRuangan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(110, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(759, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // laporanPeminjamanRuanganBindingSource
            // 
            this.laporanPeminjamanRuanganBindingSource.DataMember = "LaporanPeminjamanRuangan";
            this.laporanPeminjamanRuanganBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laporanPeminjamanRuanganTableAdapter
            // 
            this.laporanPeminjamanRuanganTableAdapter.ClearBeforeFill = true;
            // 
            // laporanPeminjamanRuanganBindingSource1
            // 
            this.laporanPeminjamanRuanganBindingSource1.DataMember = "LaporanPeminjamanRuangan";
            this.laporanPeminjamanRuanganBindingSource1.DataSource = this.dSSpaceSolutions;
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
            this.cbFilterBulan.Location = new System.Drawing.Point(110, 35);
            this.cbFilterBulan.Name = "cbFilterBulan";
            this.cbFilterBulan.ShadowDecoration.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Size = new System.Drawing.Size(140, 36);
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
            this.cbFilterStatus.Location = new System.Drawing.Point(611, 35);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.ShadowDecoration.Parent = this.cbFilterStatus;
            this.cbFilterStatus.Size = new System.Drawing.Size(140, 36);
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
            this.txtTahun.Location = new System.Drawing.Point(371, 35);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PasswordChar = '\0';
            this.txtTahun.PlaceholderText = "";
            this.txtTahun.SelectedText = "";
            this.txtTahun.ShadowDecoration.Parent = this.txtTahun;
            this.txtTahun.Size = new System.Drawing.Size(155, 36);
            this.txtTahun.TabIndex = 3;
            // 
            // btnLihat
            // 
            this.btnLihat.CheckedState.Parent = this.btnLihat;
            this.btnLihat.CustomImages.Parent = this.btnLihat;
            this.btnLihat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLihat.ForeColor = System.Drawing.Color.White;
            this.btnLihat.HoverState.Parent = this.btnLihat;
            this.btnLihat.Location = new System.Drawing.Point(391, 443);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.ShadowDecoration.Parent = this.btnLihat;
            this.btnLihat.Size = new System.Drawing.Size(180, 45);
            this.btnLihat.TabIndex = 4;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // LaporanPeminjamanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 524);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.cbFilterBulan);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanPeminjamanRuangan";
            this.Text = "LaporanPeminjamanRuangan";
            this.Load += new System.EventHandler(this.LaporanPeminjamanRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
    }
}