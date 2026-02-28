using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddPlus7
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int counter = 1;

        Color[] colors =
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow,
            Color.Orange
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblResult.Text = counter.ToString();
            counter += 7;

            int index = rnd.Next(colors.Length);
            this.BackColor = colors[index];


        }
    }
}
