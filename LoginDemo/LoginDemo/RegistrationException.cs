using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class RegistrationException:Exception
    {
        /// <summary>
        /// 在注册过程中发生的错误异常
        /// </summary>
        /// <param name="message"></param>
        public RegistrationException(string message) : base(message)
        {

        }
    }
}
