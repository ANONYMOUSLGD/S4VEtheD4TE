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

namespace S4VEtheD4TE
{
    public partial class Main : Form
    {
        string RemainingTime1 = "";

        DateTime now = DateTime.Now;
        TimeSpan duration1 = new TimeSpan(3, 0, 0, 0);
        TimeSpan duration2 = new TimeSpan(7, 0, 0, 0);

        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;

            // Check for first use
            if (Properties.Settings.Default.FirstUse == true)
            {
                MessageBox.Show("First run");
                Properties.Settings.Default.FirstUse = false;
            }
            else
            {
                MessageBox.Show("Not first run");
            }
        }


        private void time1_Tick(object sender, EventArgs e)
        {
            TimeSpan oneSecond = new TimeSpan(0, 0, 1);
            duration1 = duration1.Subtract(oneSecond);
            duration2 = duration2.Subtract(oneSecond);
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
    }
}
