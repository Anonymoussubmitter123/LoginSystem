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
    public partial class InformationManagementForm : Form
    {
        public InformationManagementForm()
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

        private void AddUser_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userLoginInfo = userInterface.GetInformationManagementInput(this);
            User user = new User(userLoginInfo[0], userLoginInfo[1]);
            UserManager userManager = new UserManager(userDAO);

            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    if (Validator.IsPasswordValid(user.PassWord))
                    {
                        if (authentication.RegistrationAuthenticate(user.UserName))
                        {
                            userManager.AddUser(user.UserName, user.PassWord);
                            this.Hide();
                            MessageBox.Show("添加成功");
                            userInterface.DispalyInformationManagementForm();
                            this.Dispose();
                        }
                        else
                        {
                            throw new InformationManagementFormException("用户名已存在！");
                        }
                    }
                    else
                    {
                        throw new InformationManagementFormException("密码不能为空！");
                    }
                }
                else
                {
                    throw new InformationManagementFormException("用户名不能为空！");
                }

            }
            catch (InformationManagementFormException ex)
            {
                errorHandler.HandleInformationManagementFormError(this, ex);
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

        private void PassWordTextBox_TextChanged(object sender, EventArgs e)
        {
            PassWordTextBox.PasswordChar = '*';
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userLoginInfo = userInterface.GetInformationManagementInput(this);
            User user = new User(userLoginInfo[0], userLoginInfo[1]);
            UserManager userManager = new UserManager(userDAO);

            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    if (!authentication.RegistrationAuthenticate(user.UserName))
                    {
                        userManager.DeleteUser(user.UserName);
                        this.Hide();
                        MessageBox.Show("删除成功");
                        userInterface.DispalyInformationManagementForm();
                        this.Dispose();
                    }
                    else
                    {
                        throw new InformationManagementFormException("用户名不存在！");
                    }
                }
                else
                {
                    throw new InformationManagementFormException("用户名不能为空！");
                }

            }
            catch (InformationManagementFormException ex)
            {
                errorHandler.HandleInformationManagementFormError(this, ex);
            }
            catch (Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
        }

        private void QueryAppointUser_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userLoginInfo = userInterface.GetInformationManagementInput(this);
            User user = new User(userLoginInfo[0], userLoginInfo[1]);
            UserManager userManager = new UserManager(userDAO);

            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    userManager.QueryAppointUser(user.UserName);
                    this.Hide();
                    userInterface.DispalyInformationManagementForm();
                    this.Dispose();
                }
                else
                {
                    throw new InformationManagementFormException("用户名不能为空！");
                }

            }
            catch (InformationManagementFormException ex)
            {
                errorHandler.HandleInformationManagementFormError(this, ex);
            }
            catch (Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
        }

        private void EdituserPassWord_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authentication = new AuthenticationService(userDAO);
            string[] userLoginInfo = userInterface.GetInformationManagementInput(this);
            User user = new User(userLoginInfo[0], userLoginInfo[1]);
            UserManager userManager = new UserManager(userDAO);

            try
            {
                if (Validator.IsUsernameValid(user.UserName))
                {
                    if (Validator.IsPasswordValid(user.PassWord))
                    {
                        if (!authentication.RegistrationAuthenticate(user.UserName))
                        {
                            userManager.EdituserPassWord(user.UserName, user.PassWord);
                            this.Hide();
                            MessageBox.Show("修改成功");
                            userInterface.DispalyInformationManagementForm();
                            this.Dispose();
                        }
                        else
                        {
                            throw new InformationManagementFormException("用户名不存在！");
                        }
                    }
                    else
                    {
                        throw new InformationManagementFormException("密码不能为空！");
                    }
                }
                else
                {
                    throw new InformationManagementFormException("用户名不能为空！");
                }

            }
            catch (InformationManagementFormException ex)
            {
                errorHandler.HandleInformationManagementFormError(this, ex);
            }
            catch (Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
        }
    }
}
