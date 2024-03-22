using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    /// <summary>
    /// 业务逻辑层
    /// </summary>
    class UserManager
    {
        private UserDAO userDAO;

        public UserManager(UserDAO userDAO)
        {
            this.userDAO = userDAO;
        }

        internal UserDAO UserDAO
        {
            get => default;
            set
            {
            }
        }

        public void AddUser(string userName, string passWord)
        {
            userDAO.AddUser(userName, passWord);
        }
        public void EdituserPassWord(string userName, string newPassWord)
        {
            userDAO.EditUserInfo(userName, newPassWord);
        }
        public void DeleteUser(string userName)
        {
            userDAO.DeleteUser(userName);
        }
        public void QueryAppointUser(string userName)
        {
            userDAO.QueryAppointUser(userName);
        }
    }
}
