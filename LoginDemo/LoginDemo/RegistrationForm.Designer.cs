
namespace LoginDemo
{
    partial class RegistrationForm
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
            this.FanHuiDengLu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RePassWordTextBox = new System.Windows.Forms.TextBox();
            this.LiJiZhuCe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FanHuiDengLu
            // 
            this.FanHuiDengLu.Location = new System.Drawing.Point(429, 272);
            this.FanHuiDengLu.Name = "FanHuiDengLu";
            this.FanHuiDengLu.Size = new System.Drawing.Size(77, 23);
            this.FanHuiDengLu.TabIndex = 24;
            this.FanHuiDengLu.Text = "返回登陆";
            this.FanHuiDengLu.UseVisualStyleBackColor = true;
            this.FanHuiDengLu.Click += new System.EventHandler(this.FanHuiDengLu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(371, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "注册界面";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(292, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "重复密码：";
            // 
            // RePassWordTextBox
            // 
            this.RePassWordTextBox.Location = new System.Drawing.Point(363, 242);
            this.RePassWordTextBox.Name = "RePassWordTextBox";
            this.RePassWordTextBox.Size = new System.Drawing.Size(145, 21);
            this.RePassWordTextBox.TabIndex = 21;
            this.RePassWordTextBox.UseSystemPasswordChar = true;
            // 
            // LiJiZhuCe
            // 
            this.LiJiZhuCe.Location = new System.Drawing.Point(319, 272);
            this.LiJiZhuCe.Name = "LiJiZhuCe";
            this.LiJiZhuCe.Size = new System.Drawing.Size(77, 23);
            this.LiJiZhuCe.TabIndex = 20;
            this.LiJiZhuCe.Text = "立即注册";
            this.LiJiZhuCe.UseVisualStyleBackColor = true;
            this.LiJiZhuCe.Click += new System.EventHandler(this.LiJiZhuCe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(316, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(304, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户名：";
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Location = new System.Drawing.Point(363, 215);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(145, 21);
            this.PassWordTextBox.TabIndex = 17;
            this.PassWordTextBox.UseSystemPasswordChar = true;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(363, 188);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(145, 21);
            this.UserNameTextBox.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FanHuiDengLu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RePassWordTextBox);
            this.Controls.Add(this.LiJiZhuCe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FanHuiDengLu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox RePassWordTextBox;
        private System.Windows.Forms.Button LiJiZhuCe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox PassWordTextBox;
        public System.Windows.Forms.TextBox UserNameTextBox;
    }
}