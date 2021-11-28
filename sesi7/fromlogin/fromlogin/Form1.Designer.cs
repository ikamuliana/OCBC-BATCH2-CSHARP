
namespace fromlogin
{
    partial class Form1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.bregis = new System.Windows.Forms.Button();
            this.blogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.lblclick = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(238, 133);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(451, 220);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(75, 23);
            this.bexit.TabIndex = 1;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // bregis
            // 
            this.bregis.Location = new System.Drawing.Point(451, 280);
            this.bregis.Name = "bregis";
            this.bregis.Size = new System.Drawing.Size(75, 23);
            this.bregis.TabIndex = 2;
            this.bregis.Text = "Register";
            this.bregis.UseVisualStyleBackColor = true;
            this.bregis.Click += new System.EventHandler(this.bregis_Click);
            // 
            // blogin
            // 
            this.blogin.Location = new System.Drawing.Point(350, 220);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(75, 23);
            this.blogin.TabIndex = 3;
            this.blogin.Text = "Login";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(240, 171);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(350, 130);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(225, 20);
            this.textuser.TabIndex = 5;
            // 
            // lblclick
            // 
            this.lblclick.AutoSize = true;
            this.lblclick.Location = new System.Drawing.Point(259, 285);
            this.lblclick.Name = "lblclick";
            this.lblclick.Size = new System.Drawing.Size(166, 13);
            this.lblclick.TabIndex = 7;
            this.lblclick.Text = "Create an account with us ? Click";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(350, 168);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(225, 20);
            this.textpass.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblclick);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.bregis);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bregis;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label lblclick;
        private System.Windows.Forms.TextBox textpass;
    }
}

