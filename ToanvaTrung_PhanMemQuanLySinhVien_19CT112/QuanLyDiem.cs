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

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    public partial class QuanLyDiem : UserControl
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-18M3J5U;database=QLSV;uid=sa;pwd=123456;");
        SqlCommand cmdSinhVien = new SqlCommand();
        SqlCommand cmdDiem = new SqlCommand();
        SqlDataAdapter daSinhVien = new SqlDataAdapter();
        SqlDataAdapter daDiem = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder cb;

        private void Datquanhe(string bangchinh, string bangphu, string khoachinh, string khoaphu, string tenquanhe)
        {
            cn.Open();
            cmdSinhVien = new SqlCommand("select * from " + bangchinh, cn);
            daSinhVien = new SqlDataAdapter(cmdSinhVien);
            cmdDiem = new SqlCommand("select * from " + bangphu, cn);
            daDiem = new SqlDataAdapter(cmdDiem);
            ds = new DataSet();
            daSinhVien.Fill(ds, bangchinh);
            daDiem.Fill(ds, bangphu);
            DataColumn chinh = ds.Tables[bangchinh].Columns[khoachinh];
            DataColumn phu = ds.Tables[bangphu].Columns[khoaphu];
            DataRelation r = new DataRelation(tenquanhe, chinh, phu);
            ds.Relations.Add(r);
        }
        private void BuocCacDieuKhien()
        {
            lstSinhVien.DataSource = ds;
            lstSinhVien.DisplayMember = "SinhVien.MaSV";
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SinhVien.FK_Diem_SinhVien";
            //FK_Diem_SinhVien là tên quan hệ của 2 bảng SinhVien và Diem trong DataSet ds
            txtMaSV.DataBindings.Add("Text", ds, "SinhVien.FK_Diem_SinhVien.MaSV");
            txtMaMH.DataBindings.Add("Text", ds, "SinhVien.FK_Diem_SinhVien.MaMH");
            txtHocKy.DataBindings.Add("Text", ds, "SinhVien.FK_Diem_SinhVien.HocKy");
            txtDiemLan1.DataBindings.Add("Text", ds, "SinhVien.FK_Diem_SinhVien.DiemLan1");
            txtDiemLan2.DataBindings.Add("Text", ds, "SinhVien.FK_Diem_SinhVien.DiemLan2");
        }

        private void butBosung_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].AddNew();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    daSinhVien.Update(ds, "Diem");
                    MessageBox.Show("Da cap nhat");
                }
                catch (Exception ll) { MessageBox.Show(ll.Message); }
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            int donghientai;
            donghientai = this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].Position;
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].RemoveAt(donghientai);
        }

        private void butPhuchoi_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].CancelCurrentEdit();
            ds.RejectChanges();
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].Position = 0;
        }

        private void butPre_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].Position--;
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].Position++;
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            int ViTri = this.BindingContext[ds, "SinhVien.FK_Diem_SinhVien"].Count - 1;
            this.BindingContext[ds, "SinhVien"].Position = ViTri;
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            Datquanhe("SinhVien", "Diem", "MaSV", "MaSV", "FK_Diem_SinhVien");
            cb = new SqlCommandBuilder(daDiem);
            BuocCacDieuKhien();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
