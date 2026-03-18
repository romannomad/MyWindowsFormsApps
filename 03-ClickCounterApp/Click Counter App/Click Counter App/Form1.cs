using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter_App
{
    
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();

            this.BackColor = Color.FromArgb
                (
                rnd.Next(256),
                rnd.Next(256),
                rnd.Next(256)
                );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = "0";
        }
    }
}
