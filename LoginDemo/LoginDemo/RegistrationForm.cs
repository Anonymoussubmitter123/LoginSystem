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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

        private void LiJiZhuCe_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userRegistrationInfo = userInterface.GetUserRegistrationInput(this);
            User user = new User(userRegistrationInfo[0], userRegistrationInfo[1]);
            string rePassWord = userRegistrationInfo[2];

            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    if (Validator.IsPasswordValid(user.PassWord))
                    {
                        if (authentication.RegistrationAuthenticate(user.UserName))
                        {
                            if(Validator.IsPasswordSame(user.PassWord, rePassWord))
                            {
                                userDAO.RegisterUser(this);
                                MessageBox.Show("注册成功，请登录！");
                                this.Hide();
                                userInterface.DisplayLoginForm();  // 显示登录页面，并等待其关闭后再继续执行下面的代码
                                this.Dispose();  // 释放当前窗体资源
                            }
                            else
                            {
                                throw new RegistrationException("两次输入密码不一致！");
                            }
                        }
                        else
                        {
                            throw new RegistrationException("用户名已存在！");
                        }
                    }
                    else
                    {
                        throw new RegistrationException("密码不能为空！");
                    }
                }
                else
                {
                    throw new RegistrationException("用户名不能为空！");
                }

            }
            catch (RegistrationException ex)
            {
                errorHandler.HandleRegistrationError(this, ex);
            }
            catch (Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
        }

        private void FanHuiDengLu_Click(object sender, EventArgs e)
        {
            UserInterface userInterface = new UserInterface();
            this.Hide();
            userInterface.DisplayLoginForm();
            this.Dispose();
        }
    }
}
