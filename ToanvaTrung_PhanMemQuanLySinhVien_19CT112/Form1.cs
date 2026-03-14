using ToanvaTrung_PhanMemQuanLySinhVien_19CT112.Data;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();
            
        }


        private void addUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContainer.Controls.Add(uc);
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
          
            moveImageBox(sender);
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }
        UserDao _userDao;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblTime.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss tt}", DateTime.Now);
            _userDao = new UserDao();
            _userDao.GetUsers(Cls_Main.pathfile);
            Cls_Main._listUser = _userDao.listUser;
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            lblUserInfor.Text = string.Format("Người Dùng_{0} : {1}", Cls_Main._staticUser.ID, Cls_Main._staticUser.UserName);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss tt}", DateTime.Now);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frm_Users_Main uC_2 = new Frm_Users_Main();
            addUserControl(uC_2);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Frm_ThemNguoiDung frm_ThemNguoiDung = new Frm_ThemNguoiDung();
            frm_ThemNguoiDung.isAdd = true;
            frm_ThemNguoiDung.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            QuanLySinhVien uC_7 = new QuanLySinhVien();
            addUserControl(uC_7);
        }
      

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            QuanLyDiem uC_8 = new QuanLyDiem();
            addUserControl(uC_8);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }
    }
}
