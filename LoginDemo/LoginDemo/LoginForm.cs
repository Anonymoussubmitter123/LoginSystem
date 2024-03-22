using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();  // 用于初始化 Windows 窗体的所有控件和相关属性,他之前不能编辑代码；
            UpdateComboBox();
        }

        internal UserInterface UserInterface
        {
            get => default;
            set
            {
            }
        }

        internal AuthenticationService AuthenticationService
        {
            get => default;
            set
            {
            }
        }

        public bool flagLoginByHistory = false;

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 把历史记录传到textbox
        /// </summary>
        public void UpdateComboBox()
        {
            LoginHistoryManager loginHistoryManager = new LoginHistoryManager();
            List<User> loginHistory = loginHistoryManager.LoadLoginHistory();

            // 清空 ComboBox 中的选项
            UserNameComboBox.Items.Clear();
            // 将历史记录添加到 ComboBox 中
            foreach (User account in loginHistory)
            {
                UserNameComboBox.Items.Add(account.UserName);
            }
        }

        private void denglu_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever,database,username,password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userLoginInfo = userInterface.GetUserLoginInput(this, flagLoginByHistory);
            User user = new User(userLoginInfo[0], userLoginInfo[1]);
            LoginHistoryManager loginHistoryManager = new LoginHistoryManager();
            
            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    if (Validator.IsPasswordValid(user.PassWord))
                    {
                        if (authentication.LoginAuthenticate(user.UserName, user.PassWord))
                        {
                            loginHistoryManager.SaveLoginHistory(user);
                            this.Hide();
                            MessageBox.Show("登录成功");
                            userInterface.DisplayIndexForm();
                            this.Dispose();
                        }
                        else
                        {
                            throw new LoginException("用户名密码错误！");
                        }
                    }
                    else
                    {
                        throw new LoginException("密码不能为空！");
                    }
                }
                else
                {
                    throw new LoginException("用户名不能为空！");
                }
                
            }
            catch(LoginException ex)
            {
                errorHandler.HandleLoginError(this, ex);
            }
            catch (Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginHistoryManager loginHistoryManager = new LoginHistoryManager();
            List<User> loginHistory = loginHistoryManager.LoadLoginHistory();
            if (UserNameComboBox.SelectedIndex >=0 && UserNameComboBox.SelectedIndex <= loginHistory.Count())
            {
                UserNameTextBox.Text = loginHistory[UserNameComboBox.SelectedIndex].UserName;
                PassWordTextBox.Text = loginHistory[UserNameComboBox.SelectedIndex].PassWord;
                flagLoginByHistory = true;
            }
        }

        private void zhuce_Click(object sender, EventArgs e)
        {
            UserInterface userInterface = new UserInterface();

            this.Hide();
            userInterface.DisplayRegistrationForm();
            this.Dispose();
        }
    }
}
