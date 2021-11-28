using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromlogin
{
    public partial class Form1 : Form
    {
        config db = new config();
        public Form1()
        {
            InitializeComponent();

            //Pass the database you
            db.Connect("userdata");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void bregis_Click(object sender, EventArgs e)
        {
            register Register = new register();
            Register.Show();
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            db.ExecutableSelect("select * from user_info where username='" + textuser.Text + "'" + " and PASSWORD='" + maskedTextBox1.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success you will login as " + db.Results(0, "NAMES"));
            }
            else
            {
                MessageBox.Show("Wrong Username and Password Combination");
            }
        }
    }
}
