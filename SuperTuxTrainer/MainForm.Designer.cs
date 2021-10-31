/* change isPremium for user to "PREMIUM" for he can use application
 * change isPremium for user to "BANNED" if you want ban user
 * change isPremium for user to "FREE" (DEFAULT) if he don't have purchase application for get access
 * 
 * If you want reset HWID for a user, change table whitelist to: RESET (default) when he will login on his account it's will add his new HWID
 */

﻿
namespace SuperTuxTrainer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotificationForApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.seedidBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.Harvest = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.FuleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.CoinButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CoinTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.AccRank = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.AccPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.AccUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
<<<<<<< HEAD
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
=======
>>>>>>> parent of 70a604b (Saving big changes what is made in this project! What i remmber i just now updated code in updater and remade setup because there was problem what i didnt saw but now thei are fixed....)
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationForApp
            // 
            this.NotificationForApp.Text = "Farming simulator HACK trainer";
            this.NotificationForApp.Visible = true;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.webBrowser1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(672, 237);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Update news zone! ";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroButton3.Location = new System.Drawing.Point(0, 218);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(672, 19);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Refresh";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(672, 206);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("https://gabhx.000webhostapp.com/Updating/updatenews", System.UriKind.Absolute);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.metroButton5);
            this.metroTabPage3.Controls.Add(this.seedidBox);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroButton4);
            this.metroTabPage3.Controls.Add(this.Harvest);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 8;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(672, 237);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Harvesting ";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 8;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(48, 79);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(134, 20);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Seed % in harvester";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(36, 20);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Seed id...";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(212, 20);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(56, 19);
            this.metroButton5.TabIndex = 12;
            this.metroButton5.Text = "SEND";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // seedidBox
            // 
            // 
            // 
            // 
            this.seedidBox.CustomButton.Image = null;
            this.seedidBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.seedidBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seedidBox.CustomButton.Name = "";
            this.seedidBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.seedidBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seedidBox.CustomButton.TabIndex = 1;
            this.seedidBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seedidBox.CustomButton.UseSelectable = true;
            this.seedidBox.CustomButton.Visible = false;
            this.seedidBox.Lines = new string[0];
            this.seedidBox.Location = new System.Drawing.Point(105, 20);
            this.seedidBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seedidBox.MaxLength = 9;
            this.seedidBox.Name = "seedidBox";
            this.seedidBox.PasswordChar = '\0';
            this.seedidBox.PromptText = "Enter max 1 digit! (id)";
            this.seedidBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seedidBox.SelectedText = "";
            this.seedidBox.SelectionLength = 0;
            this.seedidBox.SelectionStart = 0;
            this.seedidBox.ShortcutsEnabled = true;
            this.seedidBox.Size = new System.Drawing.Size(102, 19);
            this.seedidBox.TabIndex = 11;
            this.seedidBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.seedidBox.UseSelectable = true;
            this.seedidBox.WaterMark = "Enter max 1 digit! (id)";
            this.seedidBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seedidBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(297, 20);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(186, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Harvester % of seeds inside it..";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(572, 20);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(56, 19);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "SEND";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Harvest
            // 
            // 
            // 
            // 
            this.Harvest.CustomButton.Image = null;
            this.Harvest.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.Harvest.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Harvest.CustomButton.Name = "";
            this.Harvest.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.Harvest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Harvest.CustomButton.TabIndex = 1;
            this.Harvest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Harvest.CustomButton.UseSelectable = true;
            this.Harvest.CustomButton.Visible = false;
            this.Harvest.Lines = new string[0];
            this.Harvest.Location = new System.Drawing.Point(466, 20);
            this.Harvest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Harvest.MaxLength = 9;
            this.Harvest.Name = "Harvest";
            this.Harvest.PasswordChar = '\0';
            this.Harvest.PromptText = "Enter max 9 digits!";
            this.Harvest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Harvest.SelectedText = "";
            this.Harvest.SelectionLength = 0;
            this.Harvest.SelectionStart = 0;
            this.Harvest.ShortcutsEnabled = true;
            this.Harvest.Size = new System.Drawing.Size(102, 19);
            this.Harvest.TabIndex = 8;
            this.Harvest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Harvest.UseSelectable = true;
            this.Harvest.WaterMark = "Enter max 9 digits!";
            this.Harvest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Harvest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.FuleTextBox);
            this.metroTabPage1.Controls.Add(this.ProcOpenLabel);
            this.metroTabPage1.Controls.Add(this.CoinButton);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.CoinTextBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(672, 237);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Hacking zone! ";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(-3, 44);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Fule for all machines";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 11);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Coins";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(233, 41);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(56, 19);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "SEND";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FuleTextBox
            // 
            this.FuleTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.FuleTextBox.CustomButton.Image = null;
            this.FuleTextBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.FuleTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FuleTextBox.CustomButton.Name = "";
            this.FuleTextBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.FuleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FuleTextBox.CustomButton.TabIndex = 1;
            this.FuleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FuleTextBox.CustomButton.UseSelectable = true;
            this.FuleTextBox.CustomButton.Visible = false;
            this.FuleTextBox.Lines = new string[0];
            this.FuleTextBox.Location = new System.Drawing.Point(127, 41);
            this.FuleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FuleTextBox.MaxLength = 3;
            this.FuleTextBox.Name = "FuleTextBox";
            this.FuleTextBox.PasswordChar = '\0';
            this.FuleTextBox.PromptText = "Enter max 3 digits!";
            this.FuleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FuleTextBox.SelectedText = "";
            this.FuleTextBox.SelectionLength = 0;
            this.FuleTextBox.SelectionStart = 0;
            this.FuleTextBox.ShortcutsEnabled = true;
            this.FuleTextBox.Size = new System.Drawing.Size(102, 19);
            this.FuleTextBox.TabIndex = 5;
            this.FuleTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FuleTextBox.UseSelectable = true;
            this.FuleTextBox.WaterMark = "Enter max 3 digits!";
            this.FuleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FuleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FuleTextBox.Click += new System.EventHandler(this.FuleTextBox_Click);
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.BackColor = System.Drawing.Color.Gray;
            this.ProcOpenLabel.Location = new System.Drawing.Point(225, 90);
            this.ProcOpenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(10, 13);
            this.ProcOpenLabel.TabIndex = 4;
            this.ProcOpenLabel.Text = "-";
            // 
            // CoinButton
            // 
            this.CoinButton.Location = new System.Drawing.Point(233, 11);
            this.CoinButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoinButton.Name = "CoinButton";
            this.CoinButton.Size = new System.Drawing.Size(56, 19);
            this.CoinButton.TabIndex = 3;
            this.CoinButton.Text = "SEND";
            this.CoinButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CoinButton.UseSelectable = true;
            this.CoinButton.Click += new System.EventHandler(this.SendCoinValue_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(160, 89);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Process:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CoinTextBox
            // 
            this.CoinTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.CoinTextBox.CustomButton.Image = null;
            this.CoinTextBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.CoinTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoinTextBox.CustomButton.Name = "";
            this.CoinTextBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.CoinTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CoinTextBox.CustomButton.TabIndex = 1;
            this.CoinTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CoinTextBox.CustomButton.UseSelectable = true;
            this.CoinTextBox.CustomButton.Visible = false;
            this.CoinTextBox.Lines = new string[0];
            this.CoinTextBox.Location = new System.Drawing.Point(127, 11);
            this.CoinTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoinTextBox.MaxLength = 9;
            this.CoinTextBox.Name = "CoinTextBox";
            this.CoinTextBox.PasswordChar = '\0';
            this.CoinTextBox.PromptText = "Enter max 9 digits!";
            this.CoinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CoinTextBox.SelectedText = "";
            this.CoinTextBox.SelectionLength = 0;
            this.CoinTextBox.SelectionStart = 0;
            this.CoinTextBox.ShortcutsEnabled = true;
            this.CoinTextBox.Size = new System.Drawing.Size(102, 19);
            this.CoinTextBox.TabIndex = 0;
            this.CoinTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CoinTextBox.UseSelectable = true;
            this.CoinTextBox.WaterMark = "Enter max 9 digits!";
            this.CoinTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CoinTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CoinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllCoinsTextBox_KeyPress);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(15, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(680, 279);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.AccRank);
            this.metroTabPage4.Controls.Add(this.metroLabel10);
            this.metroTabPage4.Controls.Add(this.AccPassword);
            this.metroTabPage4.Controls.Add(this.metroLabel8);
            this.metroTabPage4.Controls.Add(this.AccUsername);
            this.metroTabPage4.Controls.Add(this.metroLabel6);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 8;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(672, 237);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Account information";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 8;
            // 
            // AccRank
            // 
            this.AccRank.AutoSize = true;
            this.AccRank.Location = new System.Drawing.Point(17, 165);
            this.AccRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccRank.Name = "AccRank";
            this.AccRank.Size = new System.Drawing.Size(15, 19);
            this.AccRank.TabIndex = 7;
            this.AccRank.Text = "-";
            this.AccRank.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(16, 136);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(122, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "Your Account Rank:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.Click += new System.EventHandler(this.label1_Click);
            // 
            // AccPassword
            // 
            this.AccPassword.AutoSize = true;
            this.AccPassword.Location = new System.Drawing.Point(18, 108);
            this.AccPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccPassword.Name = "AccPassword";
            this.AccPassword.Size = new System.Drawing.Size(15, 19);
            this.AccPassword.TabIndex = 5;
            this.AccPassword.Text = "-";
            this.AccPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 82);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(117, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Account Password:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AccUsername
            // 
            this.AccUsername.AutoSize = true;
            this.AccUsername.Location = new System.Drawing.Point(18, 55);
            this.AccUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccUsername.Name = "AccUsername";
            this.AccUsername.Size = new System.Drawing.Size(15, 19);
            this.AccUsername.TabIndex = 3;
            this.AccUsername.Text = "-";
            this.AccUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(18, 27);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Account Username:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(695, 7);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(16, 14);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "X";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(675, 7);
            this.metroButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(16, 14);
            this.metroButton6.TabIndex = 6;
            this.metroButton6.Text = "_";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
<<<<<<< HEAD
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(23, 52);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Farm Simulator 14";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
=======
>>>>>>> parent of 70a604b (Saving big changes what is made in this project! What i remmber i just now updated code in updater and remade setup because there was problem what i didnt saw but now thei are fixed....)
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 355);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "HACKING ZONE!";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.NotifyIcon NotificationForApp;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox seedidBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox Harvest;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox FuleTextBox;
        private System.Windows.Forms.Label ProcOpenLabel;
        private MetroFramework.Controls.MetroButton CoinButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CoinTextBox;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroLabel AccRank;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel AccPassword;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel AccUsername;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}