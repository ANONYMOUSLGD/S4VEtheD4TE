using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace S4VEtheD4TE
{
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }

        // Singleton
        private static DecryptForm inst;
        public static DecryptForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new DecryptForm();
                return inst;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text.ToString();

            if (password == "")
            {
                MessageBox.Show("Password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Utils.DecryptFiles(password);
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error decrypting files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(error);
                }
            }
        }

        private void buttonPasteClipboard_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = Clipboard.GetText();
        }
    }
}
