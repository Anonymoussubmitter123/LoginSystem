
namespace LoginDemo
{
    partial class InformationManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.QueryAppointUser = new System.Windows.Forms.Button();
            this.EdituserPassWord = new System.Windows.Forms.Button();
            this.FanHuiDengLu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PassWordTextBox.Location = new System.Drawing.Point(322, 205);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(183, 21);
            this.PassWordTextBox.TabIndex = 24;
            this.PassWordTextBox.Text = "删除用户和查找用户可不输入";
            this.PassWordTextBox.TextChanged += new System.EventHandler(this.PassWordTextBox_TextChanged);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(208, 266);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(86, 29);
            this.AddUser.TabIndex = 22;
            this.AddUser.Text = "增加用户";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "用户名：";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(322, 176);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(183, 21);
            this.UserNameTextBox.TabIndex = 19;
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(322, 176);
            this.UserNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(145, 20);
            this.UserNameComboBox.TabIndex = 23;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(300, 266);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(86, 29);
            this.DeleteUser.TabIndex = 25;
            this.DeleteUser.Text = "删除用户";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // QueryAppointUser
            // 
            this.QueryAppointUser.Location = new System.Drawing.Point(392, 266);
            this.QueryAppointUser.Name = "QueryAppointUser";
            this.QueryAppointUser.Size = new System.Drawing.Size(86, 29);
            this.QueryAppointUser.TabIndex = 26;
            this.QueryAppointUser.Text = "查找用户";
            this.QueryAppointUser.UseVisualStyleBackColor = true;
            this.QueryAppointUser.Click += new System.EventHandler(this.QueryAppointUser_Click);
            // 
            // EdituserPassWord
            // 
            this.EdituserPassWord.Location = new System.Drawing.Point(484, 266);
            this.EdituserPassWord.Name = "EdituserPassWord";
            this.EdituserPassWord.Size = new System.Drawing.Size(86, 29);
            this.EdituserPassWord.TabIndex = 27;
            this.EdituserPassWord.Text = "修改密码";
            this.EdituserPassWord.UseVisualStyleBackColor = true;
            this.EdituserPassWord.Click += new System.EventHandler(this.EdituserPassWord_Click);
            // 
            // FanHuiDengLu
            // 
            this.FanHuiDengLu.Location = new System.Drawing.Point(208, 328);
            this.FanHuiDengLu.Name = "FanHuiDengLu";
            this.FanHuiDengLu.Size = new System.Drawing.Size(362, 29);
            this.FanHuiDengLu.TabIndex = 28;
            this.FanHuiDengLu.Text = "返回登录";
            this.FanHuiDengLu.UseVisualStyleBackColor = true;
            this.FanHuiDengLu.Click += new System.EventHandler(this.FanHuiDengLu_Click);
            // 
            // InformationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FanHuiDengLu);
            this.Controls.Add(this.EdituserPassWord);
            this.Controls.Add(this.QueryAppointUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameComboBox);
            this.Name = "InformationManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.ComboBox UserNameComboBox;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button QueryAppointUser;
        private System.Windows.Forms.Button EdituserPassWord;
        private System.Windows.Forms.Button FanHuiDengLu;
    }
}