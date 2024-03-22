using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LoginDemo
{
    /// <summary>
    /// 数据访问对象类，负责与数据库进行交互，包括用户的增删改查操作。
    /// </summary>
    class UserDAO
    {
        private string connectionString;

        public string ConnectionString { get; set; }

        public UserDAO(string server, string database, string username, string password)
        {
            // 构建连接字符串
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }
        /// <summary>
        /// 判断登录时用户名密码是否正确
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <returns></returns>
        public bool VerifyLoginInfo(string userName,string passWord)
        {
            // 检查登录时用户名和密码是否正确
            ErrorHandler errorHandler = new ErrorHandler();
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "select * from User where userName = @userName";
                    MySqlCommand command = new MySqlCommand(query, msc);
                    command.Parameters.AddWithValue("@userName", userName);

                    msc.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        string hashedPassword = PassWordHelper.HashPassword(dataReader["passWord"].ToString());
                        if (Validator.IsPasswordSame(passWord, hashedPassword))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    errorHandler.HandleMysqlError(ex);
                }
                return false;
            }
        }
        /// <summary>
        /// 检查DB中是否存在当前输入的用户名
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsUsernameExistInDB(string userName)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "select count(*) from User where userName = @userName";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@userName", userName.ToString());

                msc.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
        /// <summary>
        /// 向DB表中插入注册用户
        /// </summary>
        /// <param name="registrationForm">注册页面对象</param>
        public void RegisterUser(RegistrationForm registrationForm)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO user (userName, passWord) VALUES (@userName, @passWord)";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@userName", registrationForm.UserNameTextBox.Text.ToString());
                command.Parameters.AddWithValue("@passWord", registrationForm.PassWordTextBox.Text.ToString());

                msc.Open();
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 验证管理员密码
        /// </summary>
        /// <param name="passWord">管理员密码</param>
        /// <returns></returns>
        public bool VerifyAdministrator(string passWord)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "SELECT count(*) FROM admin WHERE userName = 'admin' and passWord = @PassWord";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@PassWord", passWord.ToString());

                msc.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
        /// <summary>
        /// 管理员增加用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        public void AddUser(string userName, string passWord)
        {
            using(MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO user VALUES (@userName, @passWord)";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@passWord", passWord);

                msc.Open();
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 管理员修改用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="newPassWord"></param>
        public void EditUserInfo(string userName, string newPassWord)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "UPDATE User SET passWord = @newPassWord WHERE userName = @userName";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@newPassWord", newPassWord);
                command.Parameters.AddWithValue("@userName", userName);

                msc.Open();
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 管理员删除用户
        /// </summary>
        /// <param name="userName">要删除的用户名</param>
        public void DeleteUser(string userName)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM user WHERE userName = @userName";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@userName", userName);

                msc.Open();
                command.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        public void QueryAppointUser(string userName)
        {
            using (MySqlConnection msc = new MySqlConnection(connectionString))
            {
                string query = "SELECT count(*) FROM user WHERE userName = @userName";
                MySqlCommand command = new MySqlCommand(query, msc);
                command.Parameters.AddWithValue("@userName", userName);

                msc.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if(count > 0)
                {
                    MessageBox.Show($"存在用户{userName}");
                }
                else
                {
                    MessageBox.Show($"不存在用户{userName}");
                }
            }
        }
    }
}
