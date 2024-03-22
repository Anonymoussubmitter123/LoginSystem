using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo.Properties
{
    class PermissionManager
    {
        private Dictionary<string, string> rolePermissionMap;
        public PermissionManager()
        {
            rolePermissionMap = new Dictionary<string, string>();
        }
        /// <summary>
        /// 为角色添加权限
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="permission">权限名</param>
        public void AddRole(string userName, string permission)
        {
            if (!rolePermissionMap.ContainsKey(userName))
            {
                rolePermissionMap.Add(userName, permission);
                MessageBox.Show($"已添加角色 {userName}，权限为: {permission}", userName);
            }
            else
            {
                MessageBox.Show($"角色{userName}已存在！");
            }
        }
        /// <summary>
        /// 为角色添加权限
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="permission">权限名</param>
        public void GrantPermission(string userName, string permission)
        {
            if (rolePermissionMap.ContainsKey(userName))
            {
                rolePermissionMap[userName] = permission;
                MessageBox.Show($"已赋予角色{userName}权限：{permission}");
            }
            else
            {
                MessageBox.Show($"角色{userName}不存在");
            }
        }
        /// <summary>
        /// 撤销角色权限
        /// </summary>
        /// <param name="userName">用户名</param>
        public void RevokePermission(string userName)
        {
            if (rolePermissionMap.ContainsKey(userName))
            {
                rolePermissionMap.Remove(userName);
                MessageBox.Show($"角色{userName}已被撤销");
            }
            else
            {
                MessageBox.Show($"角色{userName}不存在");
            }
        }
    }
}
