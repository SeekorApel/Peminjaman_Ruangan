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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laporanPeminjamanBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSpaceSolutions = new SpaceSolutions.DSSpaceSolutions();
            this.laporanDetailPeminjamanBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilterStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilterBulan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLihat = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.PictureBox();
            this.txtCariidPeminjamanBarang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laporanPeminjamanBarangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanPeminjamanBarangTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.laporanDetailPeminjamanBarangTableAdapter = new SpaceSolutions.DSSpaceSolutionsTableAdapters.LaporanDetailPeminjamanBarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanDetailPeminjamanBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
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
            // laporanDetailPeminjamanBarangBindingSource
            // 
            this.laporanDetailPeminjamanBarangBindingSource.DataMember = "LaporanDetailPeminjamanBarang";
            this.laporanDetailPeminjamanBarangBindingSource.DataSource = this.dSSpaceSolutions;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSLaporanBarang";
            reportDataSource1.Value = this.laporanPeminjamanBarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanBarang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(92, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(792, 154);
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
            this.txtTahun.Location = new System.Drawing.Point(299, 38);
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
            this.cbFilterStatus.Location = new System.Drawing.Point(510, 38);
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
            this.cbFilterBulan.Location = new System.Drawing.Point(88, 38);
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
            this.btnLihat.Location = new System.Drawing.Point(88, 274);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.ShadowDecoration.Parent = this.btnLihat;
            this.btnLihat.Size = new System.Drawing.Size(100, 36);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status Peminjaman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bulan";
            // 
            // btnCari
            // 
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Image = global::SpaceSolutions.Properties.Resources.search_Use_1;
            this.btnCari.Location = new System.Drawing.Point(814, 368);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 32);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCari.TabIndex = 30;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCariidPeminjamanBarang
            // 
            this.txtCariidPeminjamanBarang.BorderRadius = 5;
            this.txtCariidPeminjamanBarang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariidPeminjamanBarang.DefaultText = "";
            this.txtCariidPeminjamanBarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariidPeminjamanBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariidPeminjamanBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidPeminjamanBarang.DisabledState.Parent = this.txtCariidPeminjamanBarang;
            this.txtCariidPeminjamanBarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariidPeminjamanBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidPeminjamanBarang.FocusedState.Parent = this.txtCariidPeminjamanBarang;
            this.txtCariidPeminjamanBarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariidPeminjamanBarang.HoverState.Parent = this.txtCariidPeminjamanBarang;
            this.txtCariidPeminjamanBarang.Location = new System.Drawing.Point(570, 367);
            this.txtCariidPeminjamanBarang.Name = "txtCariidPeminjamanBarang";
            this.txtCariidPeminjamanBarang.PasswordChar = '\0';
            this.txtCariidPeminjamanBarang.PlaceholderText = "Cari Berdasakan ID";
            this.txtCariidPeminjamanBarang.SelectedText = "";
            this.txtCariidPeminjamanBarang.ShadowDecoration.Parent = this.txtCariidPeminjamanBarang;
            this.txtCariidPeminjamanBarang.ShortcutsEnabled = false;
            this.txtCariidPeminjamanBarang.Size = new System.Drawing.Size(226, 37);
            this.txtCariidPeminjamanBarang.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Detail Peminjaman Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Laporan Peminjaman Barang";
            // 
            // laporanPeminjamanBarangTableAdapter
            // 
            this.laporanPeminjamanBarangTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.laporanDetailPeminjamanBarangBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SpaceSolutions.LaporanDetailPeminjamanBarang.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(92, 367);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(447, 174);
            this.reportViewer2.TabIndex = 34;
            // 
            // laporanDetailPeminjamanBarangTableAdapter
            // 
            this.laporanDetailPeminjamanBarangTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPeminjamanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 561);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCariidPeminjamanBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.cbFilterBulan);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanPeminjamanBarang";
            this.Text = "LaporanPeminjamanBarang";
            this.Load += new System.EventHandler(this.LaporanPeminjamanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanPeminjamanBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSpaceSolutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanDetailPeminjamanBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
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
        private System.Windows.Forms.PictureBox btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txtCariidPeminjamanBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource laporanDetailPeminjamanBarangBindingSource;
        private DSSpaceSolutionsTableAdapters.LaporanDetailPeminjamanBarangTableAdapter laporanDetailPeminjamanBarangTableAdapter;
    }
}