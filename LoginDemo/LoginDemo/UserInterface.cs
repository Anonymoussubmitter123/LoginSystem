using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    /// <summary>
    /// 用户界面类，负责与用户交互，包括显示登录界面、注册界面，接收用户输入等。
    /// </summary>
    class UserInterface
    {
        /// <summary>
        /// 显示登录页面
        /// </summary>
        public void DisplayLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.flagLoginByHistory = false;  // 将登录方式置为不从历史记录获取
            loginForm.UpdateComboBox();  // 更新历史记录
            loginForm.ShowDialog();
        }
        /// <summary>
        /// 显示管理页面
        /// </summary>
        public void DispalyInformationManagementForm()
        {
            InformationManagementForm informationManagementForm = new InformationManagementForm();
            informationManagementForm.ShowDialog();
        }
        /// <summary>
        /// 显示注册页面
        /// </summary>
        public void DisplayRegistrationForm()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
        /// <summary>
        /// 显示Index页面
        /// </summary>
        public void DisplayIndexForm()
        {
            Index index = new Index();
            index.ShowDialog();
        }
        /// <summary>
        /// 获取RegistrationForm页面的textbox值
        /// </summary>
        /// <param name="registrationForm"></param>
        /// <returns></returns>
        public string[] GetUserRegistrationInput(RegistrationForm registrationForm)
        {
            string[] userRegistrationInput = new string[3];

            userRegistrationInput[0] = registrationForm.UserNameTextBox.Text.ToString();
            userRegistrationInput[1] = PassWordHelper.HashPassword(registrationForm.PassWordTextBox.Text.ToString());
            userRegistrationInput[2] = PassWordHelper.HashPassword(registrationForm.RePassWordTextBox.Text.ToString());

            return userRegistrationInput;
        }
        /// <summary>
        /// 获取Index页面的textbox值
        /// </summary>
        /// <param name="index">Index页面的对象</param>
        /// <returns></returns>
        public string GetIndexInput(Index index)
        {
            string userIndexInput = index.AdminPassWord.Text.ToString();

            return userIndexInput;
        }
        /// <summary>
        /// 获取管理页面的值
        /// </summary>
        /// <param name="informationManagementForm">管理页面对象</param>
        /// <returns></returns>
        public string[] GetInformationManagementInput(InformationManagementForm informationManagementForm)
        {
            string[] userInformationManagementInput = new string[2];

            userInformationManagementInput[0] = informationManagementForm.UserNameTextBox.Text.ToString();
            userInformationManagementInput[1] = informationManagementForm.PassWordTextBox.Text.ToString();

            return userInformationManagementInput;
        }
        /// <summary>
        /// 获取LoginForm页面textbox的值，并判断是否来自历史记录
        /// </summary>
        /// <param name="loginForm"></param>
        /// <param name="flagLoginByHistory"></param>
        /// <returns></returns>
        public string[] GetUserLoginInput(LoginForm loginForm , bool flagLoginByHistory)
        {
            string[] userLoginInput = new string[2];

            if (flagLoginByHistory)
            {
                userLoginInput[0] = loginForm.UserNameTextBox.Text.ToString();
                userLoginInput[1] = loginForm.PassWordTextBox.Text.ToString();
            }
            else
            {
                userLoginInput[0] = loginForm.UserNameTextBox.Text.ToString();
                userLoginInput[1] = PassWordHelper.HashPassword(loginForm.PassWordTextBox.Text.ToString());
            }

            return userLoginInput;
        }
    }
}
