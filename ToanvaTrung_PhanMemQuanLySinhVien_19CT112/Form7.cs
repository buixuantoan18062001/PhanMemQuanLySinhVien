using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("QLSV"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from QLSV where Ma=@MaSV or HoTen like @HoTen", cn))
                        {
                            cmd.Parameters.AddWithValue("QLSV", txtSearch.Text);
                            cmd.Parameters.AddWithValue("QLSV", string.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            lblLop.Text = $"Total records: {dataGridView1.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                btnSearch.PerformClick();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    
    }
}
