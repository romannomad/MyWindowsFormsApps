using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyJokesApp
{
    public partial class Form1 : Form
    {
        string[] jokes =
        {
            "Why don’t skeletons fight, they don’t have the guts",
            "I told my computer I needed a break, it said no problem and froze",
            "I’m reading a book on anti‑gravity, it’s impossible to put down",
            "I used to play piano by ear, now I use my hands",
            "I asked my dog what two minus two is, he said nothing"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(jokes.Length);

            lblResult.Text = jokes[index];
        }
    }
}
