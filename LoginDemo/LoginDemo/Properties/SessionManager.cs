using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo.Properties
{
    /// <summary>
    /// 会话管理类，负责管理用户的登录状态和会话信息，包括创建、销毁会话等操作。
    /// </summary>
    class SessionManager
    {
        private Dictionary<string, User> sessions;

        public SessionManager()
        {
            sessions = new Dictionary<string, User>();
        }
        /// <summary>
        /// 创建新的会话，并将用户信息关联到会话中，返回会话ID。
        /// </summary>
        /// <param name="user">User类的对象</param>
        /// <returns></returns>
        public string CreatSession(User user)
        {
            string sessionID = Guid.NewGuid().ToString();
            sessions.Add(sessionID, user);
            return sessionID;
        }
        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="sessionID">用户会话的ID</param>
        public void DestorySession(string sessionID)
        {
            if (sessions.ContainsKey(sessionID))
            {
                sessions.Remove(sessionID);
            }
        }
        /// <summary>
        /// 验证会话的有效性
        /// </summary>
        /// <param name="sessionID">用户会话的ID</param>
        /// <returns></returns>
        public bool IsValidSession(string sessionID)
        {
            return sessions.ContainsKey(sessionID);
        }
        /// <summary>
        /// 根据会话ID查询用户
        /// </summary>
        /// <param name="sessionID">用户会话的ID</param>
        /// <returns></returns>
        public User GetSessionUser(string sessionID)
        {
            if (sessions.ContainsKey(sessionID))
            {
                return sessions[sessionID];
            }
            return null;
        }
    }
}
