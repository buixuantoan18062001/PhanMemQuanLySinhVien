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
    public partial class Frm_Users_Main : UserControl
    {
        public Frm_Users_Main()
        {
            InitializeComponent();
        }
        UserDao userDao;
        List<User> listUser;


        private void GetDataToDataGridView()
        {
            userDao.GetUsers(Cls_Main.pathfile);
            listUser = userDao.listUser;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listUser;
            dgvUserList.DataSource = bindingSource;
            lblQuantity.Text = dgvUserList.RowCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_ThemNguoiDung frm_User_Modified = new Frm_ThemNguoiDung();
            frm_User_Modified.isAdd = true;
            frm_User_Modified.ShowDialog();
            GetDataToDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (user != null)
            {
                Frm_ThemNguoiDung frm_User_Modified = new Frm_ThemNguoiDung();
                frm_User_Modified.isAdd = false;
                frm_User_Modified.user = user;
                frm_User_Modified.ShowDialog();
                user = null;
                GetDataToDataGridView();
            }
        }
        User user;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                userDao.listUser.Remove(user);

                userDao.WriteUsers(Cls_Main.pathfile);
                user = null;
                GetDataToDataGridView();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }  

        private void Frm_Users_Main_Load(object sender, EventArgs e)
        {
            userDao = new UserDao();

            GetDataToDataGridView();
        }

        private void dgvUserList_Click(object sender, EventArgs e)
        {
            if (dgvUserList.RowCount > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUserList.CurrentRow.Cells["colID"].Value.ToString()),
                    FullName = dgvUserList.CurrentRow.Cells["colFullName"].Value.ToString(),
                    UserName = dgvUserList.CurrentRow.Cells["colUserName"].Value.ToString(),
                    PassWord = dgvUserList.CurrentRow.Cells["colPassWord"].Value.ToString(),
                    Remember = Convert.ToBoolean(dgvUserList.CurrentRow.Cells["colRemember"].Value.ToString()),
                    IdUserType = Convert.ToInt32(dgvUserList.CurrentRow.Cells["colIDUserType"].Value.ToString())
                };
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.ShowDialog();
        }
    }
}
