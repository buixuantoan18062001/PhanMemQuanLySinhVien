using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-18M3J5U;Initial Catalog=QLSV;User ID=sa;Password=123456");

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from SinhVien", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.ReportPath = "ReportSV.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void butLoc_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from SinhVien Where MASV = '" + cmbLoc.Text + "'", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.ReportPath = "ReportSV.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cmbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qLSVDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
