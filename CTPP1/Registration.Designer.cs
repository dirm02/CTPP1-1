namespace CTPP1
{
    partial class Registration
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
            this.Fname = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.SignatureText = new System.Windows.Forms.TextBox();
            this.LSignature = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.TUserName = new System.Windows.Forms.TextBox();
            this.LUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(5, 55);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(57, 13);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "First Name";
            // 
            // NameText
            // 
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.Location = new System.Drawing.Point(80, 88);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(202, 20);
            this.NameText.TabIndex = 3;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 95);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 2;
            this.LName.Text = "Name";
            // 
            // EmailText
            // 
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailText.Location = new System.Drawing.Point(80, 132);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(202, 20);
            this.EmailText.TabIndex = 5;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(12, 139);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(32, 13);
            this.LEmail.TabIndex = 4;
            this.LEmail.Text = "Email";
            // 
            // SignatureText
            // 
            this.SignatureText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignatureText.Location = new System.Drawing.Point(80, 181);
            this.SignatureText.Multiline = true;
            this.SignatureText.Name = "SignatureText";
            this.SignatureText.Size = new System.Drawing.Size(202, 72);
            this.SignatureText.TabIndex = 7;
            // 
            // LSignature
            // 
            this.LSignature.AutoSize = true;
            this.LSignature.Location = new System.Drawing.Point(10, 228);
            this.LSignature.Name = "LSignature";
            this.LSignature.Size = new System.Drawing.Size(52, 13);
            this.LSignature.TabIndex = 6;
            this.LSignature.Text = "Signature";
            // 
            // FnameText
            // 
            this.FnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FnameText.Location = new System.Drawing.Point(80, 48);
            this.FnameText.Multiline = true;
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(202, 20);
            this.FnameText.TabIndex = 8;
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.DarkGreen;
            this.BSave.Location = new System.Drawing.Point(183, 259);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(99, 43);
            this.BSave.TabIndex = 9;
            this.BSave.Text = "SAVE";
            this.BSave.UseVisualStyleBackColor = false;
            // 
            // TUserName
            // 
            this.TUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUserName.Location = new System.Drawing.Point(80, 12);
            this.TUserName.Multiline = true;
            this.TUserName.Name = "TUserName";
            this.TUserName.Size = new System.Drawing.Size(202, 20);
            this.TUserName.TabIndex = 11;
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(5, 19);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(57, 13);
            this.LUserName.TabIndex = 10;
            this.LUserName.Text = "UserName";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 325);
            this.Controls.Add(this.TUserName);
            this.Controls.Add(this.LUserName);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.SignatureText);
            this.Controls.Add(this.LSignature);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Fname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox SignatureText;
        private System.Windows.Forms.Label LSignature;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.TextBox TUserName;
        private System.Windows.Forms.Label LUserName;
    }
}