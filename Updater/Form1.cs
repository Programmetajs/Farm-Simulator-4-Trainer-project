using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\SuperTuxTrainer.exe");
                File.Delete(@".\MetroFramework.dll");
                File.Delete(@".\MetroFramework.Fonts.dll");
                File.Delete(@".\Memory.dll");
                File.Delete(@".\MetroFramework.Design.dll");
                client.DownloadFile("https://gabhx.000webhostapp.com/Updating/SuperTuxTrainer.zip", @"SuperTuxTrainer.zip");
                string zipPath = @".\SuperTuxTrainer.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\SuperTuxTrainer.zip");


                Process.Start(@".\SuperTuxTrainer.exe");
                this.Close();
            }
            catch
            {
                Process.Start("SuperTuxTrainer.exe");
                this.Close();
            }
        }
    }
}
