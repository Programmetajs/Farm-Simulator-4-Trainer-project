using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using MetroFramework.Forms;

namespace SuperTuxTrainer
{
    public partial class MainForm : MetroForm
    {

        public static MainForm instance;
        public Button CoinBTN;
        public Label AccountRankText;
        public Label AccNameINInfo;
        public Label AccountPasswordLab;

        public Mem m = new Mem();
        public bool ProcOpen = false;

        [Obsolete]
        public MainForm()
        {
            InitializeComponent();

            instance = this;
            CoinBTN = CoinButton;
            AccountRankText = AccRank;
            AccNameINInfo = AccUsername;
            AccountPasswordLab = AccPassword;

        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // constantly check if the process is available and open
            ProcOpen = m.OpenProcess("game.exe");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0); // do UI thread stuff


           

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Game Found";
               // NotofocationForApp.ShowBalloonTip(1000, "Game is found!", "The applications is found the game! Go and HACK!", ToolTipIcon.Info);

            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return; // do not continue if process is not available/open
            }

           // m.ReadFloat("game.exe+00149C50,95C,FC,34C") = TestLab.Text;


        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }
        #region Hacks

        private void SendCoinValue_Click(object sender, EventArgs e)
        {
            if (CoinTextBox.Text != "" && ProcOpen) // check if process is avialable/open and if textbox has text in it
                m.WriteMemory("game.exe+00149C30,20,998", "double", CoinTextBox.Text);
        }

        private void AllCoinsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // only allow digits
                e.Handled = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (FuleTextBox.Text != "" && ProcOpen) // check if process is avialable/open and if textbox has text in it
                m.WriteMemory("game.exe+00149C50,95C,FC,34C", "Float", FuleTextBox.Text);
        }

        private void FuleTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (seedidBox.Text != "" && ProcOpen) // check if process is avialable/open and if textbox has text in it
                m.WriteMemory("game.exe+00149C30,20,48,88", "int", seedidBox.Text);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (Harvest.Text != "" && ProcOpen) // check if process is avialable/open and if textbox has text in it
                m.WriteMemory("game.exe+00149C30,20,48,8C", "Float" , Harvest.Text);
        }
        #endregion 
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are free memmber then that means you have limited hacks/features in this application! For exsample you cant use Money hack or something else! To get premium or know more about that please contact to developer!" , "Info about free memmber rank!" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
