using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class LoginException : Exception
    {
        /// <summary>
        /// 在登录过程中发生的错误异常
        /// </summary>
        /// <param name="message"></param>
        public LoginException(string message) : base(message)
        {

        }
    }
}
