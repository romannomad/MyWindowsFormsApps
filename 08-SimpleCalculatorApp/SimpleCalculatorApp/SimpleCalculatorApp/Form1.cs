using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double result = a + b;
            lblResult.Text = "Result: " + result;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double result = a - b;
            lblResult.Text = "Result: " + result;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double result = a * b;
            lblResult.Text = "Result: " + result;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (b == 0)
            {
                lblResult.Text = "Cannot divide by zero";
                return;
            }

            double result = a / b;
            lblResult.Text = "Result: " + result;
        }
    }
}
