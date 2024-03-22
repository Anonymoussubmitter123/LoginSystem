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
    public partial class Index : Form
    {
        public Index()
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterface userInterface = new UserInterface();

            this.Hide();
            userInterface.DisplayLoginForm();
            this.Dispose();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void InformationManagementSystem_Click(object sender, EventArgs e)
        {
            string sever = "192.168.1.101";
            string database = "loginDemo";
            string username = "root";
            string password = "w1286623295";
            ErrorHandler errorHandler = new ErrorHandler();
            UserInterface userInterface = new UserInterface();
            UserDAO userDAO = new UserDAO(sever, database, username, password);
            AuthenticationService authenticationService = new AuthenticationService(userDAO);
            string passWord = userInterface.GetIndexInput(this);

            try
            {
                if (Validator.IsUsernameValid(passWord))
                {
                    if (authenticationService.AdministratorAuthentucate(passWord))
                    {
                        this.Hide();
                        userInterface.DispalyInformationManagementForm();
                        this.Dispose();
                    }
                    else
                    {
                        throw new IndexException("密码错误");
                    }
                }
                else
                {
                    throw new IndexException("密码不能为空");
                }
            }
            catch(IndexException ex)
            {
                errorHandler.HandleIndexError(this, ex);
            }
            catch(Exception ex)
            {
                errorHandler.HandleMysqlError(ex);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPassWord_TextChanged(object sender, EventArgs e)
        {
            AdminPassWord.PasswordChar = '*';
        }
    }
}
