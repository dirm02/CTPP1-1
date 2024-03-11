namespace CTPP1
{
    partial class Login
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
            this.WelcomeMessage = new System.Windows.Forms.TextBox();
            this.TextUSERNAME = new System.Windows.Forms.TextBox();
            this.LUSERNAME = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 12);
            this.WelcomeMessage.Multiline = true;
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(297, 65);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "\r\nWELCOME PLEASE LOGIN \r\nOR \r\nClick your username\r\n";
            this.WelcomeMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextUSERNAME
            // 
            this.TextUSERNAME.Location = new System.Drawing.Point(90, 102);
            this.TextUSERNAME.Multiline = true;
            this.TextUSERNAME.Name = "TextUSERNAME";
            this.TextUSERNAME.Size = new System.Drawing.Size(219, 37);
            this.TextUSERNAME.TabIndex = 2;
            this.TextUSERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LUSERNAME
            // 
            this.LUSERNAME.AutoSize = true;
            this.LUSERNAME.Location = new System.Drawing.Point(12, 126);
            this.LUSERNAME.Name = "LUSERNAME";
            this.LUSERNAME.Size = new System.Drawing.Size(68, 13);
            this.LUSERNAME.TabIndex = 3;
            this.LUSERNAME.Text = "USERNAME";
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.Color.Red;
            this.BLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BLogin.Location = new System.Drawing.Point(234, 163);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 38);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "LOGIN";
            this.BLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(380, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 195);
            this.panel1.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 213);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.LUSERNAME);
            this.Controls.Add(this.TextUSERNAME);
            this.Controls.Add(this.WelcomeMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeMessage;
        private System.Windows.Forms.TextBox TextUSERNAME;
        private System.Windows.Forms.Label LUSERNAME;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Panel panel1;
    }
}