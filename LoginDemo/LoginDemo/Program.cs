using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LoginHistoryManager lhm = new LoginHistoryManager();
            //LoginInfo li1 = new LoginInfo("小明", "jZae727K08KaOmKSgOaGzww/XVqGr/PKEgIMkjrcbJI=");
            //LoginInfo li2 = new LoginInfo("小红", "123456");
            //List<LoginInfo> loginHistory = new List<LoginInfo>();
            //loginHistory.Add(li1);
            //// loginHistory.Add(li2);
            //lhm.SaveLoginHistory(loginHistory);  // 测试代码

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new LoginForm());
        }
    }
}
