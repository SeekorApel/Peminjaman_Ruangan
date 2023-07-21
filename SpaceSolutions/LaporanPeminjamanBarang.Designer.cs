namespace SpaceSolutions
{
    partial class LaporanPeminjamanBarang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laporanPeminjamanBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterBulan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLihat = new Guna.UI2.WinForms.Guna2Button();
            this.laporanPeminjamanBarangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanPeminjamanBarangTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            this.SuspendLayout();
            // 
            // laporanPeminjamanBarangBindingSource
            // 
            this.laporanPeminjamanBarangBindingSource.DataMember = "LaporanPeminjamanBarang";
            this.laporanPeminjamanBarangBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // dSSpaceSolutions
            // 
            this.dSSpaceSolutions.DataSetName = "DSSpaceSolutions";
            this.dSSpaceSolutions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource9.Name = "DSLaporanBarang";
            reportDataSource9.Value = this.laporanPeminjamanBarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanBarang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(89, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(807, 315);
            this.reportViewer1.TabIndex = 0;
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
            this.txtTahun.Location = new System.Drawing.Point(299, 70);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PasswordChar = '\0';
            this.txtTahun.PlaceholderText = "";
            this.txtTahun.SelectedText = "";
            this.txtTahun.ShadowDecoration.Parent = this.txtTahun;
            this.txtTahun.Size = new System.Drawing.Size(160, 36);
            this.txtTahun.TabIndex = 6;
            this.txtTahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahun_KeyPress);
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
            this.cbFilterStatus.Location = new System.Drawing.Point(510, 70);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.ShadowDecoration.Parent = this.cbFilterStatus;
            this.cbFilterStatus.Size = new System.Drawing.Size(160, 36);
            this.cbFilterStatus.TabIndex = 5;
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
            this.cbFilterBulan.Location = new System.Drawing.Point(88, 70);
            this.cbFilterBulan.Name = "cbFilterBulan";
            this.cbFilterBulan.ShadowDecoration.Parent = this.cbFilterBulan;
            this.cbFilterBulan.Size = new System.Drawing.Size(160, 36);
            this.cbFilterBulan.TabIndex = 4;
            // 
            // btnLihat
            // 
            this.btnLihat.BorderRadius = 5;
            this.btnLihat.CheckedState.Parent = this.btnLihat;
            this.btnLihat.CustomImages.Parent = this.btnLihat;
            this.btnLihat.Font = new System.Drawing.Font("Gilmer Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLihat.ForeColor = System.Drawing.Color.White;
            this.btnLihat.HoverState.Parent = this.btnLihat;
            this.btnLihat.Location = new System.Drawing.Point(427, 466);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.ShadowDecoration.Parent = this.btnLihat;
            this.btnLihat.Size = new System.Drawing.Size(140, 36);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // laporanPeminjamanBarangTableAdapter
            // 
            this.laporanPeminjamanBarangTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status Peminjaman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bulan";
            // 
            // LaporanPeminjamanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.cbFilterBulan);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanPeminjamanBarang";
            this.Text = "LaporanPeminjamanBarang";
            this.Load += new System.EventHandler(this.LaporanPeminjamanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2TextBox txtTahun;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBulan;
        private Guna.UI2.WinForms.Guna2Button btnLihat;
        private System.Windows.Forms.BindingSource laporanPeminjamanBarangBindingSource;
        private DSSpaceSolutions dSSpaceSolutions;
        private DSSpaceSolutionsTableAdapters.LaporanPeminjamanBarangTableAdapter laporanPeminjamanBarangTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}