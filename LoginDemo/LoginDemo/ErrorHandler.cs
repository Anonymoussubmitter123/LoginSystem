using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDemo
{
    class ErrorHandler
    {

        /// <summary>
        /// 处理登录的错误
        /// </summary>
        /// <param name="loginForm">当前页面对象可填this</param>
        /// <param name="ex">捕捉到的异常</param>
        public void HandleLoginError(LoginForm loginForm, Exception ex)
        {
            loginForm.UserNameTextBox.Text = "";
            loginForm.PassWordTextBox.Text = "";
            LogException(ex);
            ShowNormalErrorMessage(ex.Message);
        }
        /// <summary>
        /// 处理index页面的错误
        /// </summary>
        /// <param name="index">index对象</param>
        /// <param name="ex">捕捉到的异常</param>
        public void HandleIndexError(Index index, Exception ex)
        {
            index.AdminPassWord.Text = "";
            LogException(ex);
            ShowNormalErrorMessage(ex.Message);
        }
        /// <summary>
        /// 处理管理页面的错误
        /// </summary>
        /// <param name="informationManagementForm">informationManagementForm页面对象</param>
        /// <param name="ex">捕捉到的异常</param>
        public void HandleInformationManagementFormError(InformationManagementForm informationManagementForm, Exception ex)
        {
            informationManagementForm.UserNameTextBox.Text = "";
            informationManagementForm.PassWordTextBox.Text = "";
            LogException(ex);
            ShowNormalErrorMessage(ex.Message);
        }
        /// <summary>
        /// 处理注册等普通的错误
        /// </summary>
        /// <param name="ex"></param>
        public void HandleRegistrationError(RegistrationForm registrationForm ,Exception ex)
        {
            registrationForm.UserNameTextBox.Text = "";
            registrationForm.PassWordTextBox.Text = "";
            registrationForm.RePassWordTextBox.Text = "";
            LogException(ex);
            ShowNormalErrorMessage(ex.Message);
        }
        /// <summary>
        /// 处理数据库连接错误
        /// </summary>
        /// <param name="ex"></param>
        public void HandleMysqlError(Exception ex)
        {
            LogException(ex);
            ShowMysqlErrorMessage();
        }
        /// <summary>
        /// 记录异常文件
        /// </summary>
        /// <param name="ex"></param>
        private void LogException(Exception ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
            Console.WriteLine($"StackTrance:{ex.StackTrace}");
        }
        /// <summary>
        /// 通过窗口给用户提供错误提示
        /// </summary>
        /// <param name="message"></param>
        private void ShowNormalErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ShowMysqlErrorMessage()
        {
            string message = "服务器连接出现错误";
            MessageBox.Show(message, "其他错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
