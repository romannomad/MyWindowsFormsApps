using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomQuoteGenerator
{
    public partial class Form1 : Form
    {
        string[] quotes =
        {
            "Believe you can and you're halfway there.", 
            "Every moment is a fresh beginning.", 
            "Dream big and dare to fail.", 
            "Turn your wounds into wisdom.", 
            "Action is the foundational key to all success."
        };

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            int index = rand.Next(quotes.Length);
            lblQuote.Text = quotes[index];
        }
    }
}
