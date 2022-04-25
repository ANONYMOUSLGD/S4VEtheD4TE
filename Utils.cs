using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace S4VEtheD4TE
{
    public class Utils
    {

        public static void OpenDefaultBrowser(string URL)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            cmd.StandardInput.WriteLine("start " + URL);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }
    }
}
