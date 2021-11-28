
namespace fromlogin
{
    partial class register
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblregis = new System.Windows.Forms.Label();
            this.btnregis = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(256, 102);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(40, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Names";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(256, 137);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(55, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(256, 173);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblregis
            // 
            this.lblregis.AutoSize = true;
            this.lblregis.Location = new System.Drawing.Point(309, 293);
            this.lblregis.Name = "lblregis";
            this.lblregis.Size = new System.Drawing.Size(160, 13);
            this.lblregis.TabIndex = 3;
            this.lblregis.Text = "Do you have an account ? Click";
            // 
            // btnregis
            // 
            this.btnregis.Location = new System.Drawing.Point(384, 235);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(75, 23);
            this.btnregis.TabIndex = 4;
            this.btnregis.Text = "Register";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(486, 235);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(486, 288);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(363, 99);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(210, 20);
            this.textname.TabIndex = 7;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(363, 134);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(210, 20);
            this.textuser.TabIndex = 8;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(363, 170);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(210, 20);
            this.textpass.TabIndex = 9;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.lblregis);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblname);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblregis;
        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpass;
    }
}