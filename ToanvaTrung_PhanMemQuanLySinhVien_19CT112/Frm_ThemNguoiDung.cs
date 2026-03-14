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
    public partial class Frm_ThemNguoiDung : Form
    {
        public Frm_ThemNguoiDung()
        {
            InitializeComponent();
        }
        public bool isAdd = false;
        UserDao userDao;

        public User user;
        string err = string.Empty;
        /// <summary>
        /// </summary>
        private void SetDataToControl(User user)
        {
            txtID.Text = user.ID.ToString();
            txtFullName.Text = user.FullName;
            txtUserName.Text = user.UserName;
            txtPassWord.Text = user.PassWord;
            ckbRemember.Checked = user.Remember;
            cboUserType.SelectedValue = user.IdUserType;
        }

        private void LoadDataToComUserType()
        {
            List<UserType> userTypes = new List<UserType>()
            {
                new UserType(){IDUserType=1,NameUserType="Admin"},
                 new UserType(){IDUserType=2,NameUserType="User"},
                 new UserType(){IDUserType=3,NameUserType="Khác"},
            };

            cboUserType.DataSource = userTypes;
            cboUserType.DisplayMember = "NameUserType";
            cboUserType.ValueMember = "IDUserType";
        }

        private string CreateMaxID()
        {
            string maxID = string.Empty;
            maxID = userDao.GetMaxID().ToString();
            return maxID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                if (!string.IsNullOrEmpty(txtUserName.Text))
                {
                    if (!string.IsNullOrEmpty(txtPassWord.Text))
                    {
                        if (cboUserType.SelectedIndex > -1)
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                FullName = txtFullName.Text,
                                UserName = txtUserName.Text,
                                PassWord = txtPassWord.Text,
                                Remember = ckbRemember.Checked,
                                IdUserType = Convert.ToInt32(cboUserType.SelectedValue.ToString())
                            };
                            if (UpdateUser(ref err, user))
                            {
                                MessageBox.Show("Add User SuccessFull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Select userType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Select Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Not Select UserName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Not Select FullName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UpdateUser(ref string err, User user)
        {
            try
            {
                if (isAdd)
                {
                    userDao.listUser.Add(user);
                    userDao.WriteUsers(Cls_Main.pathfile);
                    return true;
                }
                else
                {
                    foreach (User item in userDao.listUser)
                    {
                        if (item.ID == user.ID)
                        {
 
                            item.FullName = user.FullName;
                            item.UserName = user.UserName;
                            item.PassWord = user.PassWord;
                            item.Remember = user.Remember;
                            item.IdUserType = user.IdUserType;
                        }
                    }
                    userDao.WriteUsers(Cls_Main.pathfile);
                    return true;
                }
            }
            catch (Exception ex)
            {

                err = ex.Message;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ThemNguoiDung_Load(object sender, EventArgs e)
        {
            userDao = new UserDao();
            userDao.GetUsers(Cls_Main.pathfile); 
            LoadDataToComUserType();
            if (isAdd)
            {
                txtID.Text = CreateMaxID();
                txtID.Enabled = false;
            }
            else
            {
                SetDataToControl(user);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Frm_ChangedPassword frm_ChangedPassword = new Frm_ChangedPassword();
            frm_ChangedPassword.ShowDialog();
        }

    }
}
