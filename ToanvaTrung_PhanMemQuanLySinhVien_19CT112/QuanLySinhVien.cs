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
    public partial class QuanLySinhVien : UserControl
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource bin = new BindingSource();
        DataTable dt = new DataTable();
        SqlConnection cnn = new SqlConnection();
        string server = "DESKTOP-18M3J5U";
        public void Runnow()
        {
            try
            {
                string s = "Server=" + server + ";database=QLSV;uid=sa;pwd=123456;";
                cnn.ConnectionString = s;
                cnn.Open();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Có lỗi khi kết nối cơ sỡ dữ liệu ! ");
            }
        }
        private void butClear_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = false;
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtMaLop.Text = "";
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "insert into SinhVien (MaSV,HoTen,GioiTinh,NgaySinh,DiaChi,MaLop) values(@MaSV,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@MaLop)";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = txtMaSV.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cmbGioiTinh.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = txtMaLop.Text;
                cmd.ExecuteNonQuery();
                dt.Clear();
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Lỗi Khi Thêm Vui Lòng Kiểm Tra Lại");
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            try
            {
                Runnow();
                string s = "UPDATE SinhVien set HoTen=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,MaLop=@MaLop Where MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = txtMaSV.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cmbGioiTinh.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtMaLop.Text;
                cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = txtMaLop.Text;
                cmd.ExecuteNonQuery();
                dt.Clear();
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Lỗi Khi Thêm Vui Lòng Kiểm Tra Lại");
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Xoa = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaSV"].Value);
                Runnow();
                string s = "Delete From SinhVien Where MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(s, cnn);
                cmd.Parameters.Add("@MaSV", SqlDbType.Int).Value = Xoa;
                cmd.ExecuteNonQuery();
                dt.Clear();
                da.Fill(dt);
                cnn.Close();
                txtMaSV.Enabled = false;
                txtMaSV.Text = "";
                txtHoTen.Text = "";
                cmbGioiTinh.Text = "";
                txtNgaySinh.Text = "";
                txtDiaChi.Text = "";
                txtMaLop.Text = "";
            }
            catch (Exception e4)
            {
                MessageBox.Show("Lỗi Khi Thêm Vui Lòng Kiểm Tra Lại");
            }
        }

        private void butXem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from SinhVien", cnn);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Runnow();
            string s = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(s, cnn);
            da.SelectCommand = cmd;
            da.Fill(dt);
            bin.DataSource = dt;
            dataGridView1.DataSource = bin;
            cnn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaSV.Enabled = false;
                txtMaSV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaSV"].Value);
                txtHoTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["HoTen"].Value);
                cmbGioiTinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GioiTinh"].Value);
                txtNgaySinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NgaySinh"].Value);
                txtDiaChi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DiaChi"].Value);
                txtMaLop.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaLop"].Value);

            }
        }
    }
}
