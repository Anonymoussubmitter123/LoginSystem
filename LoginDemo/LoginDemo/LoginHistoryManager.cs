using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoginDemo
{
    /// <summary>
    /// 用于处理用户输入的历史记录
    /// </summary>
    class LoginHistoryManager
    {
        private string filePath = Path.Combine(Directory.GetCurrentDirectory(),"login_history.json");

        private List<User> loginHistory;
        /// <summary>
        /// 用于保存历史记录到json文件中
        /// </summary>
        /// <param name="loginInfo">当前需要保存的对象</param>
        public void SaveLoginHistory(User user)
        {
            loginHistory = LoadLoginHistory();
            // 判断是否当前对象是否已经在历史记录中,没有就保存
            if(!loginHistory.Any(loginHistory => loginHistory.UserName == user.UserName))
            {
                loginHistory.Add(user);
            }
            // 判断如果超过了三条就更新掉最早的一条
            if (loginHistory.Count > 3)
            {
                loginHistory.RemoveAt(0);
            }

            string json = JsonConvert.SerializeObject(loginHistory);  // 转换为json格式
            File.WriteAllText(filePath, json);
        }
        /// <summary>
        /// 加载当前json文件中历史记录
        /// </summary>
        /// <returns></returns>
        public List<User> LoadLoginHistory()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            // 如果没有记录就返回空列表
            return new List<User>();
        }
    }
}
