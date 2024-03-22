using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LoginDemo
{
    static class Validator
    {
        /// <summary>
        /// 检查用输入是否为空
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool IsUsernameValid(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 验证密码是否为空
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsPasswordValid(string password)
        {
            if (password != PassWordHelper.HashPassword(""))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 检查注册时两次密码是否一致
        /// </summary>
        /// <param name="passWord"></param>
        /// <param name="repassWord"></param>
        /// <returns></returns>
        public static bool IsPasswordSame(string passWord, string repassWord)
        {
            return passWord == repassWord;
        }
    }
}
