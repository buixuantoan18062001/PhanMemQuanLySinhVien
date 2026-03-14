using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToanvaTrung_PhanMemQuanLySinhVien_19CT112.Data;
using System.Windows.Forms;


namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    internal class Cls_Main
    {
        public static User _staticUser = new User();
        public static List<User> _listUser = new UserDao().listUser;
        public static string pathfile = string.Format(@"{0}\listUser.ini", Application.StartupPath);
    }
}
