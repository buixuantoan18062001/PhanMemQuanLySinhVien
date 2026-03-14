using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112.Data
{
    public class UserDao
    {

        public List<User> listUser;
        public UserDao()
        {
            listUser = new List<User>();
            #region khoá code
            //user = new User();
            //user.ID = 1;
            //user.UserName = "admin";
            //user.PassWord = "admin";
            //user.Remember = true;

            //user = new User(2, "user2", "user2", true);


            //
            //{
            //    new User() { ID = 1,UserName="admin",PassWord="admin",Remember=true ,IdUserType=1},//1 la Admin
            //    new User() { ID = 2,UserName="user",PassWord="user",Remember=false,IdUserType=2},
            //    new User() { ID = 3,UserName="phuc",PassWord="123456789",Remember=true,IdUserType=2 }//2 la user thuong
            //};
            #endregion
        }
        public void WriteUsers(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (User item in listUser)
                    {
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.ID, item.FullName, item.Sex.ToString(), item.UserName, item.PassWord, item.Remember.ToString(), item.IdUserType));
                    }
                }
            }

        }

        public void GetUsers(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    User user;
                    listUser.Clear();

                    while ((line = sr.ReadLine()) != null)
                    {

                        if (!string.IsNullOrEmpty(line))
                        {

                            string[] userArray = line.Split(',');
                            user = new User();
                            user.ID = Convert.ToInt32(userArray[0]);
                            user.FullName = userArray[1];
                            user.Sex = Convert.ToBoolean(userArray[2]);
                            user.UserName = userArray[3];
                            user.PassWord = userArray[4];
                            user.Remember = Convert.ToBoolean(userArray[5].ToString());
                            user.IdUserType = Convert.ToInt32(userArray[6]);
                            listUser.Add(user);
                        }

                    }
                }
            }

        }

        public int GetMaxID()
        {
            int maxID = 0;
            foreach (User item in listUser)
            {
                if (item.ID > maxID)
                    maxID = item.ID;
            }
            return maxID + 1;
        }
    }
}
