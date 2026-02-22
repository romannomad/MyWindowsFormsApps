using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResult.Text = $"{fahrenheit} °F";
            }
            else
            {
                lblResult.Text = "Please enter a valid number";
            }
        }
    }
}
