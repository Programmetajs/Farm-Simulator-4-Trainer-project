
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1.SuspendLayout();
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
            this.LoginBTN.Location = new System.Drawing.Point(88, 225);
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
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your information here";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(311, 478);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 20);
            this.metroLabel1.TabIndex = 4;
<<<<<<< HEAD
<<<<<<< HEAD
            this.metroLabel1.Text = "V 12.0";
=======
            this.metroLabel1.Text = "V 11.0";
>>>>>>> parent of 70a604b (Saving big changes what is made in this project! What i remmber i just now updated code in updater and remade setup because there was problem what i didnt saw but now thei are fixed....)
=======
            this.metroLabel1.Text = "V 11.0";
>>>>>>> parent of 70a604b (Saving big changes what is made in this project! What i remmber i just now updated code in updater and remade setup because there was problem what i didnt saw but now thei are fixed....)
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
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Usernametb
            // 
            this.Usernametb.Location = new System.Drawing.Point(83, 117);
            this.Usernametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(159, 22);
            this.Usernametb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(83, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 22);
            this.Password.TabIndex = 8;
            // 
            // RegistrationWebpageLink
            // 
            this.RegistrationWebpageLink.AutoSize = true;
            this.RegistrationWebpageLink.Location = new System.Drawing.Point(13, 261);
            this.RegistrationWebpageLink.Name = "RegistrationWebpageLink";
            this.RegistrationWebpageLink.Size = new System.Drawing.Size(335, 16);
            this.RegistrationWebpageLink.TabIndex = 9;
            this.RegistrationWebpageLink.TabStop = true;
            this.RegistrationWebpageLink.Text = "Dont have a account? Fill form and send it to developer!";
            this.RegistrationWebpageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UpdateLink
            // 
            this.UpdateLink.AutoSize = true;
            this.UpdateLink.Location = new System.Drawing.Point(13, 367);
            this.UpdateLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateLink.Name = "UpdateLink";
            this.UpdateLink.Size = new System.Drawing.Size(266, 16);
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
            this.label5.Location = new System.Drawing.Point(13, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Application status:";
            // 
            // accessibilityFormTXT
            // 
            this.accessibilityFormTXT.AutoSize = true;
            this.accessibilityFormTXT.Location = new System.Drawing.Point(13, 436);
            this.accessibilityFormTXT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accessibilityFormTXT.Name = "accessibilityFormTXT";
            this.accessibilityFormTXT.Size = new System.Drawing.Size(11, 16);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 510);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}