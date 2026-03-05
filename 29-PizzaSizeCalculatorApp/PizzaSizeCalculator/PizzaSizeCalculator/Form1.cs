using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSizeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSmall.Checked)
            {
                UpdatePrice(5.00m);
            }
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMedium.Checked)
            {
                UpdatePrice(8.50m);
            }
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLarge.Checked)
            {
                UpdatePrice(12.00m);
            }
        }

        private void UpdatePrice(decimal price)
        {
            labelPrice.Text = $"Price: ${price:F2}";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string size = radioSmall.Checked ? "Small" :
                          radioMedium.Checked ? "Medium" :
                          radioLarge.Checked ? "Large" : "None";

            MessageBox.Show($"You ordered a {size} pizza.\n{labelPrice.Text}");
        }
    }
}
