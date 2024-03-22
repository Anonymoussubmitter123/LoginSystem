using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    /// <summary>
    /// 表示用户的实体类，包含用户的基本信息，如用户名、密码等。
    /// </summary>
    class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User(string userName, string passWord)
        {
            UserName = userName;
            PassWord = passWord;
        }
    }
}
