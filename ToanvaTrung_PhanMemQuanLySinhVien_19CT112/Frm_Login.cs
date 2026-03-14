using ToanvaTrung_PhanMemQuanLySinhVien_19CT112.Data;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private List<User> listUser;
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            listUser = Cls_Main._listUser;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    if (KiemTraDangNhap(txtUserName.Text, txtPassWord.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        lblErr.Text = "Sai Tài Khoản Hoặc Mật Khẩu";
                    }
                }
            }
        }

        private bool KiemTraDangNhap(string userName, string passWord)
        {
            foreach (User item in listUser)
            {
                if (item.UserName.Equals(userName) && item.PassWord.Equals(passWord))
                {
                    item.Remember = ckbRemember.Checked;
                    Cls_Main._staticUser = item;
                    return true;
                }

            }
            return false;
        }



        private void txtUserName_Leave(object sender, EventArgs e)
        {
            foreach (User item in listUser)
            {
                if (item.UserName == txtUserName.Text && item.Remember)
                {
                    ckbRemember.Checked = true;

                    txtPassWord.Text = item.PassWord;
                    btnLogin.Focus();
                }
            }
        }

        private void stripdoimatkhau_Click(object sender, EventArgs e)
        {
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.ShowDialog();
        }

        private void btnFrm_ChangedPassword_Click(object sender, EventArgs e)
        {
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
