using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInput.Text, out double value))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double result = 0;

            if (radioKmToMiles.Checked)
            {
                result = value * 0.621371;
                lblResult.Text = $"{value} km = {result:F2} miles";
            }

            else if (radioMilesToKm.Checked)
            {
                result = value * 1.60934;
                lblResult.Text = $"{value} miles = {result:F2} km";
            }

            else
            {
                lblResult.Text = "Please select a conversion type.";
            }
        }
    }
}
