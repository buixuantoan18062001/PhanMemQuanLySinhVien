using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112.Data
{
    public class UserType
    {
        private int iDUserType;
        private string nameUserType;

        public int IDUserType { get => iDUserType; set => iDUserType = value; }
        public string NameUserType { get => nameUserType; set => nameUserType = value; }
    }
}
