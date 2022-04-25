
namespace S4VEtheD4TE
{
    partial class DecryptForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptForm));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonPasteClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Blue;
            this.textBoxPassword.Location = new System.Drawing.Point(7, 7);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(639, 29);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDecrypt.Location = new System.Drawing.Point(7, 45);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(315, 32);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonPasteClipboard
            // 
            this.buttonPasteClipboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPasteClipboard.Location = new System.Drawing.Point(331, 45);
            this.buttonPasteClipboard.Name = "buttonPasteClipboard";
            this.buttonPasteClipboard.Size = new System.Drawing.Size(315, 32);
            this.buttonPasteClipboard.TabIndex = 2;
            this.buttonPasteClipboard.Text = "Paste Clipboard";
            this.buttonPasteClipboard.UseVisualStyleBackColor = true;
            this.buttonPasteClipboard.Click += new System.EventHandler(this.buttonPasteClipboard_Click);
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 89);
            this.Controls.Add(this.buttonPasteClipboard);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert password:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonPasteClipboard;
    }
}