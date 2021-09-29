
namespace Login_HWID
{
    partial class Login
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBTN = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NotofocationForApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.Usernametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(60, 225);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(147, 23);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseSelectable = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your information here";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(235, 254);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "V 9.0";
            // 
            // NotofocationForApp
            // 
            this.NotofocationForApp.Text = "Notification from trainer!";
            this.NotofocationForApp.Visible = true;
            // 
            // Usernametb
            // 
            this.Usernametb.Location = new System.Drawing.Point(55, 117);
            this.Usernametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(159, 22);
            this.Usernametb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(55, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 22);
            this.Password.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 334);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usernametb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton LoginBTN;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NotifyIcon NotofocationForApp;
        private System.Windows.Forms.TextBox Usernametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
    }
}