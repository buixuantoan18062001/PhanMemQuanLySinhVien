using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.IO;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    public partial class ConnectSQl : Form
    {
        public ConnectSQl()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();

            try
            {
                string connectionstring = "server=DESKTOP-18M3J5U; database=SinhVien;uid=sa;pwd=123456";
                if (rdwin.Checked == true)
                {
                    connectionstring = "Server= " + txtserver.Text;
                    connectionstring = ";database= " + txtdatabase.Text;
                    connectionstring = ";integrated security = true";
                    cnn.ConnectionString = connectionstring;
                }
                else
                {
                    connectionstring = "Server= " + txtserver.Text;
                    connectionstring = ";database= " + txtdatabase.Text;
                    connectionstring = ";uid= " + txtuser.Text;
                    connectionstring = ";pwd= " + txtpass.Text;
                    cnn.ConnectionString = connectionstring;
                }
                cnn.Open();
                MessageBox.Show("Kết nối thành công");
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Loi ket noi " + ex.Message);
            }
            Form1 from1 = new Form1();
            from1.ShowDialog();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn Có Muống Thoát Không ?", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
            Form1 from1 = new Form1();
            from1.ShowDialog();
        }


        private void ketnoiAccess_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            try
            {

                string s = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=qlbh.mdb;Persist Security Info=False";


                cnn.ConnectionString = s;
                cnn.Open();
                MessageBox.Show("Ket noi thanh cong");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi" + ex.Message);
            }
            Form1 from1 = new Form1();
            from1.ShowDialog();
        }
        public string LayChuoi()
        {
            string tentaptin = "chuoi.txt";
            string s;
            StreamReader rd = new StreamReader(tentaptin);
            s = rd.ReadToEnd();
            rd.Close();
            return s;

        }

        private void laydulieu1_Click(object sender, EventArgs e)
        {
            string Conn = LayChuoi();
            MessageBox.Show(Conn);
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Conn;
            cnn.Open();
            Form1 from1 = new Form1();
            from1.ShowDialog();
        }


        private void ConnectSQl_Load(object sender, EventArgs e)
        {

        }

    }
}