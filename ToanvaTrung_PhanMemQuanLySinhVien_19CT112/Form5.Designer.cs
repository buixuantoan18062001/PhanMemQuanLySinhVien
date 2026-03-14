namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    partial class Form5
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
            this.qLSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new ToanvaTrung_PhanMemQuanLySinhVien_19CT112.QLSVDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.butLoc = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // qLSVDataSetBindingSource
            // 
            this.qLSVDataSetBindingSource.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource.Position = 0;
            this.qLSVDataSetBindingSource.CurrentChanged += new System.EventHandler(this.qLSVDataSetBindingSource_CurrentChanged);
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.qLSVDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ToanvaTrung_PhanMemQuanLySinhVien_19CT112.bin.Debug.ReportSV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 192);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1203, 495);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cmbLoc
            // 
            this.cmbLoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Items.AddRange(new object[] {
            "SV1",
            "SV2",
            "SV3",
            "SV4"});
            this.cmbLoc.Location = new System.Drawing.Point(34, 34);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(399, 39);
            this.cmbLoc.TabIndex = 99;
            this.cmbLoc.SelectedIndexChanged += new System.EventHandler(this.cmbLoc_SelectedIndexChanged);
            // 
            // butLoc
            // 
            this.butLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butLoc.ForeColor = System.Drawing.Color.White;
            this.butLoc.Location = new System.Drawing.Point(469, 34);
            this.butLoc.Name = "butLoc";
            this.butLoc.Size = new System.Drawing.Size(180, 39);
            this.butLoc.TabIndex = 98;
            this.butLoc.Text = "In";
            this.butLoc.Click += new System.EventHandler(this.butLoc_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 687);
            this.Controls.Add(this.cmbLoc);
            this.Controls.Add(this.butLoc);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form: Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.ComboBox cmbLoc;
        private Guna.UI2.WinForms.Guna2Button butLoc;
    }
}