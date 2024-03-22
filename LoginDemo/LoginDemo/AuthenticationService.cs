using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    /// <summary>
    /// 认证服务类，负责处理用户登录认证的逻辑，包括验证用户身份、生成和验证令牌等。
    /// </summary>
    class AuthenticationService
    {
        private UserDAO userDAO;

        public AuthenticationService(UserDAO userDAO)
        {
            this.userDAO = userDAO;
        }

        internal UserManager UserManager
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// 验证用户名和密码是否正确
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool LoginAuthenticate(string userName, string passWord)
        {
            return userDAO.VerifyLoginInfo(userName, passWord);
        }
        /// <summary>
        /// 验证用户名是否已被注册,如果被注册就是0
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool RegistrationAuthenticate(string userName)
        {
            return !userDAO.IsUsernameExistInDB(userName);
        } 
        public bool AdministratorAuthentucate(string passWord)
        {
            return userDAO.VerifyAdministrator(passWord);
        }
    }
}
