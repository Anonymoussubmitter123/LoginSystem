
namespace LoginDemo
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.denglu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.zhuce = new System.Windows.Forms.Button();
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Location = new System.Drawing.Point(357, 233);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(145, 21);
            this.PassWordTextBox.TabIndex = 17;
            this.PassWordTextBox.UseSystemPasswordChar = true;
            this.PassWordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(376, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "登陆界面";
            // 
            // denglu
            // 
            this.denglu.Location = new System.Drawing.Point(339, 258);
            this.denglu.Name = "denglu";
            this.denglu.Size = new System.Drawing.Size(52, 23);
            this.denglu.TabIndex = 14;
            this.denglu.Text = "登录";
            this.denglu.UseVisualStyleBackColor = true;
            this.denglu.Click += new System.EventHandler(this.denglu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(357, 204);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(130, 21);
            this.UserNameTextBox.TabIndex = 11;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // zhuce
            // 
            this.zhuce.Location = new System.Drawing.Point(423, 258);
            this.zhuce.Name = "zhuce";
            this.zhuce.Size = new System.Drawing.Size(52, 23);
            this.zhuce.TabIndex = 10;
            this.zhuce.Text = "注册";
            this.zhuce.UseVisualStyleBackColor = true;
            this.zhuce.Click += new System.EventHandler(this.zhuce_Click);
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(357, 204);
            this.UserNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(145, 20);
            this.UserNameComboBox.TabIndex = 16;
            this.UserNameComboBox.SelectedIndexChanged += new System.EventHandler(this.UserNameComboBox_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.denglu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.zhuce);
            this.Controls.Add(this.UserNameComboBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button denglu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button zhuce;
        private System.Windows.Forms.ComboBox UserNameComboBox;
    }
}