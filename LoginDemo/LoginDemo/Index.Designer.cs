
namespace LoginDemo
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InformationManagementSystem = new System.Windows.Forms.Button();
            this.RightsManagementSystem = new System.Windows.Forms.Button();
            this.AdminPassWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginDemo.Properties.Resources.BiZhi;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InformationManagementSystem
            // 
            this.InformationManagementSystem.Location = new System.Drawing.Point(12, 314);
            this.InformationManagementSystem.Name = "InformationManagementSystem";
            this.InformationManagementSystem.Size = new System.Drawing.Size(186, 36);
            this.InformationManagementSystem.TabIndex = 2;
            this.InformationManagementSystem.Text = "信息管理系统";
            this.InformationManagementSystem.UseVisualStyleBackColor = true;
            this.InformationManagementSystem.Click += new System.EventHandler(this.InformationManagementSystem_Click);
            // 
            // RightsManagementSystem
            // 
            this.RightsManagementSystem.Location = new System.Drawing.Point(12, 314);
            this.RightsManagementSystem.Name = "RightsManagementSystem";
            this.RightsManagementSystem.Size = new System.Drawing.Size(186, 36);
            this.RightsManagementSystem.TabIndex = 3;
            this.RightsManagementSystem.Text = "权限管理系统";
            this.RightsManagementSystem.UseVisualStyleBackColor = true;
            // 
            // AdminPassWord
            // 
            this.AdminPassWord.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdminPassWord.Location = new System.Drawing.Point(12, 287);
            this.AdminPassWord.Name = "AdminPassWord";
            this.AdminPassWord.Size = new System.Drawing.Size(186, 21);
            this.AdminPassWord.TabIndex = 4;
            this.AdminPassWord.Text = "在此输入管理员密码";
            this.AdminPassWord.TextChanged += new System.EventHandler(this.AdminPassWord_TextChanged);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.AdminPassWord);
            this.Controls.Add(this.InformationManagementSystem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RightsManagementSystem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button InformationManagementSystem;
        private System.Windows.Forms.Button RightsManagementSystem;
        public System.Windows.Forms.TextBox AdminPassWord;
    }
}