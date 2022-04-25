
namespace S4VEtheD4TE
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxMeme = new System.Windows.Forms.PictureBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelAboutMonero = new System.Windows.Forms.LinkLabel();
            this.linkLabelFAQ = new System.Windows.Forms.LinkLabel();
            this.linkLabelContactUs = new System.Windows.Forms.LinkLabel();
            this.buttonCheckPayment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCopyAddress = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelSendMonero = new System.Windows.Forms.Label();
            this.pictureBoxMonero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonero)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMeme
            // 
            this.pictureBoxMeme.Image = global::S4VEtheD4TE.Properties.Resources.you_just_got_owned__1_;
            this.pictureBoxMeme.Location = new System.Drawing.Point(193, 12);
            this.pictureBoxMeme.Name = "pictureBoxMeme";
            this.pictureBoxMeme.Size = new System.Drawing.Size(597, 345);
            this.pictureBoxMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMeme.TabIndex = 1;
            this.pictureBoxMeme.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxDescription.Location = new System.Drawing.Point(193, 363);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(597, 154);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label1.Location = new System.Drawing.Point(33, 234);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 32);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "0:00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label2.Location = new System.Drawing.Point(33, 318);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(133, 32);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "0:00:00:00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time before price raise: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your files will be lost on:";
            // 
            // linkLabelAboutMonero
            // 
            this.linkLabelAboutMonero.AutoSize = true;
            this.linkLabelAboutMonero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelAboutMonero.Location = new System.Drawing.Point(25, 366);
            this.linkLabelAboutMonero.Name = "linkLabelAboutMonero";
            this.linkLabelAboutMonero.Size = new System.Drawing.Size(145, 25);
            this.linkLabelAboutMonero.TabIndex = 9;
            this.linkLabelAboutMonero.TabStop = true;
            this.linkLabelAboutMonero.Text = "About Monero";
            this.linkLabelAboutMonero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelFAQ
            // 
            this.linkLabelFAQ.AutoSize = true;
            this.linkLabelFAQ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelFAQ.Location = new System.Drawing.Point(71, 428);
            this.linkLabelFAQ.Name = "linkLabelFAQ";
            this.linkLabelFAQ.Size = new System.Drawing.Size(49, 25);
            this.linkLabelFAQ.TabIndex = 10;
            this.linkLabelFAQ.TabStop = true;
            this.linkLabelFAQ.Text = "FAQ";
            this.linkLabelFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelContactUs
            // 
            this.linkLabelContactUs.AutoSize = true;
            this.linkLabelContactUs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelContactUs.Location = new System.Drawing.Point(44, 485);
            this.linkLabelContactUs.Name = "linkLabelContactUs";
            this.linkLabelContactUs.Size = new System.Drawing.Size(108, 25);
            this.linkLabelContactUs.TabIndex = 11;
            this.linkLabelContactUs.TabStop = true;
            this.linkLabelContactUs.Text = "Contact Us";
            this.linkLabelContactUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // buttonCheckPayment
            // 
            this.buttonCheckPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckPayment.Location = new System.Drawing.Point(6, 108);
            this.buttonCheckPayment.Name = "buttonCheckPayment";
            this.buttonCheckPayment.Size = new System.Drawing.Size(172, 33);
            this.buttonCheckPayment.TabIndex = 13;
            this.buttonCheckPayment.Text = "Check Payment";
            this.buttonCheckPayment.UseVisualStyleBackColor = true;
            this.buttonCheckPayment.Click += new System.EventHandler(this.buttonCheckPayment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCopyAddress);
            this.groupBox1.Controls.Add(this.buttonDecrypt);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.buttonCheckPayment);
            this.groupBox1.Controls.Add(this.labelSendMonero);
            this.groupBox1.Controls.Add(this.pictureBoxMonero);
            this.groupBox1.Location = new System.Drawing.Point(12, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 147);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // buttonCopyAddress
            // 
            this.buttonCopyAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyAddress.Location = new System.Drawing.Point(596, 108);
            this.buttonCopyAddress.Name = "buttonCopyAddress";
            this.buttonCopyAddress.Size = new System.Drawing.Size(172, 33);
            this.buttonCopyAddress.TabIndex = 16;
            this.buttonCopyAddress.Text = "Copy address";
            this.buttonCopyAddress.UseVisualStyleBackColor = true;
            this.buttonCopyAddress.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDecrypt.Location = new System.Drawing.Point(184, 108);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(172, 33);
            this.buttonDecrypt.TabIndex = 15;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(6, 77);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(762, 25);
            this.textBoxAddress.TabIndex = 14;
            this.textBoxAddress.Text = "888tNkZrPN6JsEgekjMnABU4TBzc2Dt29EPAvkRxbANsAnjyPbb3iQ1YBRk1UXcdRsiKc9dhwMVgN5S9c" +
    "QUiyoogDavup3H";
            // 
            // labelSendMonero
            // 
            this.labelSendMonero.AutoSize = true;
            this.labelSendMonero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendMonero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelSendMonero.Location = new System.Drawing.Point(305, 31);
            this.labelSendMonero.Name = "labelSendMonero";
            this.labelSendMonero.Size = new System.Drawing.Size(339, 21);
            this.labelSendMonero.TabIndex = 13;
            this.labelSendMonero.Text = "Send $300 worth of Monero to this address:";
            // 
            // pictureBoxMonero
            // 
            this.pictureBoxMonero.BackColor = System.Drawing.Color.White;
            this.pictureBoxMonero.Image = global::S4VEtheD4TE.Properties.Resources.monero_accepted_here;
            this.pictureBoxMonero.Location = new System.Drawing.Point(6, 13);
            this.pictureBoxMonero.Name = "pictureBoxMonero";
            this.pictureBoxMonero.Size = new System.Drawing.Size(172, 59);
            this.pictureBoxMonero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMonero.TabIndex = 12;
            this.pictureBoxMonero.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(802, 682);
            this.Controls.Add(this.linkLabelContactUs);
            this.Controls.Add(this.linkLabelFAQ);
            this.Controls.Add(this.linkLabelAboutMonero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.pictureBoxMeme);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S4VEtheD4TE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMeme;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelAboutMonero;
        private System.Windows.Forms.LinkLabel linkLabelFAQ;
        private System.Windows.Forms.LinkLabel linkLabelContactUs;
        private System.Windows.Forms.Button buttonCheckPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxMonero;
        private System.Windows.Forms.Label labelSendMonero;
        private System.Windows.Forms.Button buttonCopyAddress;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}

