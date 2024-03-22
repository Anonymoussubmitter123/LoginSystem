using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace LoginDemo
{
    /// <summary>
    /// 密码辅助类，负责密码加密、解密等操作，以确保用户密码的安全性。
    /// </summary>
    class PassWordHelper
    {
        /// <summary>
        /// 使用 SHA-256 算法对密码进行哈希处理
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
