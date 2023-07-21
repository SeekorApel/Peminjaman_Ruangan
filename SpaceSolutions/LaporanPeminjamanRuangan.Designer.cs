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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbFilterStatusPeminjaman = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortingBulan = new System.Windows.Forms.Label();
            this.cbFilterBulan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLihat = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laporanPeminjamanRuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.laporanPeminjamanRuanganTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanPeminjamanRuanganTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.laporanPeminjamanRuanganBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanPeminjamanRuangan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(83, 135);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(749, 328);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbFilterStatusPeminjaman
            // 
            this.cbFilterStatusPeminjaman.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterStatusPeminjaman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterStatusPeminjaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatusPeminjaman.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterStatusPeminjaman.FocusedState.Parent = this.cbFilterStatusPeminjaman;
            this.cbFilterStatusPeminjaman.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterStatusPeminjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterStatusPeminjaman.FormattingEnabled = true;
            this.cbFilterStatusPeminjaman.HoverState.Parent = this.cbFilterStatusPeminjaman;
            this.cbFilterStatusPeminjaman.ItemHeight = 30;
            this.cbFilterStatusPeminjaman.Items.AddRange(new object[] {
            "Di Pinjam",
            "Di Kembalikan"});
            this.cbFilterStatusPeminjaman.ItemsAppearance.Parent = this.cbFilterStatusPeminjaman;
            this.cbFilterStatusPeminjaman.Location = new System.Drawing.Point(83, 82);
            this.cbFilterStatusPeminjaman.Name = "cbFilterStatusPeminjaman";
            this.cbFilterStatusPeminjaman.ShadowDecoration.Parent = this.cbFilterStatusPeminjaman;
            this.cbFilterStatusPeminjaman.Size = new System.Drawing.Size(173, 36);
            this.cbFilterStatusPeminjaman.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorting Peminjaman";
            // 
            // SortingBulan
            // 
            this.SortingBulan.AutoSize = true;
            this.SortingBulan.Location = new System.Drawing.Point(709, 57);
            this.SortingBulan.Name = "SortingBulan";
            this.SortingBulan.Size = new System.Drawing.Size(70, 13);
            this.SortingBulan.TabIndex = 6;
            this.SortingBulan.Text = "Sorting Bulan";
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
            this.cbFilterBulan.Location = new System.Drawing.Point(659, 82);
            this.cbFilterBulan.Name = "cbFilterBulan";
            this.cbFilterBulan.ShadowDecoration.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Size = new System.Drawing.Size(173, 36);
            this.cbFilterBulan.TabIndex = 5;
            // 
            // btnLihat
            // 
            this.btnLihat.CheckedState.Parent = this.btnLihat;
            this.btnLihat.CustomImages.Parent = this.btnLihat;
            this.btnLihat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihat.ForeColor = System.Drawing.Color.White;
            this.btnLihat.HoverState.Parent = this.btnLihat;
            this.btnLihat.Location = new System.Drawing.Point(409, 482);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.ShadowDecoration.Parent = this.btnLihat;
            this.btnLihat.Size = new System.Drawing.Size(125, 36);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // txtFilterTahun
            // 
            this.txtFilterTahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterTahun.DefaultText = "";
            this.txtFilterTahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterTahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterTahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterTahun.DisabledState.Parent = this.txtFilterTahun;
            this.txtFilterTahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterTahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterTahun.FocusedState.Parent = this.txtFilterTahun;
            this.txtFilterTahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterTahun.HoverState.Parent = this.txtFilterTahun;
            this.txtFilterTahun.Location = new System.Drawing.Point(375, 82);
            this.txtFilterTahun.Name = "txtFilterTahun";
            this.txtFilterTahun.PasswordChar = '\0';
            this.txtFilterTahun.PlaceholderText = "";
            this.txtFilterTahun.SelectedText = "";
            this.txtFilterTahun.ShadowDecoration.Parent = this.txtFilterTahun;
            this.txtFilterTahun.Size = new System.Drawing.Size(173, 33);
            this.txtFilterTahun.TabIndex = 8;
            this.txtFilterTahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterTahun_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sorting Tahun";
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
            // LaporanPeminjamanRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterTahun);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.SortingBulan);
            this.Controls.Add(this.cbFilterBulan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterStatusPeminjaman);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanPeminjamanRuangan";
            this.Text = "Laporan Peminjaman Ruangan";
            this.Load += new System.EventHandler(this.LaporanPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanRuanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterStatusPeminjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SortingBulan;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBulan;
        private System.Windows.Forms.BindingSource laporanPeminjamanRuanganBindingSource;
        private DSSpaceSolutions dSSpaceSolutions;
        private DSSpaceSolutionsTableAdapters.LaporanPeminjamanRuanganTableAdapter laporanPeminjamanRuanganTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnLihat;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterTahun;
        private System.Windows.Forms.Label label1;
    }
}