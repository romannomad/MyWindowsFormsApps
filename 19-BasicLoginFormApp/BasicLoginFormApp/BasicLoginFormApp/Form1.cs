using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLoginFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (username == "Admin" && password == "1234")
            {
                lblResult.Text = "Login successful";
                lblResult.ForeColor = Color.Green;
            }

            else
            {
                lblResult.Text = "Invalid username/password";
                lblResult.ForeColor = Color.Red;
            }
          
        }
    }
}
