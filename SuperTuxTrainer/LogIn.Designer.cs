﻿
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
            System.Windows.Forms.Timer TimerAvability;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBTN = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.NotofocationForApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Usernametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.RegistrationWebpageLink = new System.Windows.Forms.LinkLabel();
            this.UpdateLink = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accessibilityFormTXT = new System.Windows.Forms.Label();
            this.BanCheck = new System.Windows.Forms.Timer(this.components);
            TimerAvability = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerAvability
            // 
            TimerAvability.Enabled = true;
            TimerAvability.Interval = 30000;
            TimerAvability.Tick += new System.EventHandler(this.TimerAvability_Tick);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(45, 183);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(110, 19);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseSelectable = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your information here";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(233, 388);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "V 10.0";
            // 
            // NotofocationForApp
            // 
            this.NotofocationForApp.ContextMenuStrip = this.contextMenuStrip1;
            this.NotofocationForApp.Icon = ((System.Drawing.Icon)(resources.GetObject("NotofocationForApp.Icon")));
            this.NotofocationForApp.Text = "Notification from trainer!";
            this.NotofocationForApp.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Usernametb
            // 
            this.Usernametb.Location = new System.Drawing.Point(41, 95);
            this.Usernametb.Margin = new System.Windows.Forms.Padding(2);
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(120, 20);
            this.Usernametb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(41, 149);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 20);
            this.Password.TabIndex = 8;
            // 
            // RegistrationWebpageLink
            // 
            this.RegistrationWebpageLink.AutoSize = true;
            this.RegistrationWebpageLink.Location = new System.Drawing.Point(77, 223);
            this.RegistrationWebpageLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationWebpageLink.Name = "RegistrationWebpageLink";
            this.RegistrationWebpageLink.Size = new System.Drawing.Size(46, 13);
            this.RegistrationWebpageLink.TabIndex = 9;
            this.RegistrationWebpageLink.TabStop = true;
            this.RegistrationWebpageLink.Text = "Register";
            this.RegistrationWebpageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateLink
            // 
            this.UpdateLink.AutoSize = true;
            this.UpdateLink.Location = new System.Drawing.Point(10, 298);
            this.UpdateLink.Name = "UpdateLink";
            this.UpdateLink.Size = new System.Drawing.Size(214, 13);
            this.UpdateLink.TabIndex = 10;
            this.UpdateLink.TabStop = true;
            this.UpdateLink.Text = "See Latest news about application updates!";
            this.UpdateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLink_LinkClicked);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 355);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 20);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Application status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Information about application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Application status:";
            // 
            // accessibilityFormTXT
            // 
            this.accessibilityFormTXT.AutoSize = true;
            this.accessibilityFormTXT.Location = new System.Drawing.Point(10, 354);
            this.accessibilityFormTXT.Name = "accessibilityFormTXT";
            this.accessibilityFormTXT.Size = new System.Drawing.Size(10, 13);
            this.accessibilityFormTXT.TabIndex = 12;
            this.accessibilityFormTXT.Text = "-";
            // 
            // BanCheck
            // 
            this.BanCheck.Enabled = true;
            this.BanCheck.Interval = 1000;
            this.BanCheck.Tick += new System.EventHandler(this.BanCheck_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 414);
            this.Controls.Add(this.accessibilityFormTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateLink);
            this.Controls.Add(this.RegistrationWebpageLink);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usernametb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
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
        private System.Windows.Forms.LinkLabel RegistrationWebpageLink;
        private System.Windows.Forms.LinkLabel UpdateLink;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label accessibilityFormTXT;
        private System.Windows.Forms.Timer BanCheck;
    }
}