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
        private Random rnd = new Random();
        
        string[] jokes =
        {
            "Why don’t skeletons fight, they don’t have the guts",
            "I told my computer I needed a break, it said no problem and froze",
            "I’m reading a book on anti‑gravity, it’s impossible to put down",
            "I used to play piano by ear, now I use my hands",
            "I asked my dog what two minus two is, he said nothing",
            "Why did the math book look sad? It had too many problems",
            "I tried to catch fog yesterday… I mist",
            "Why don’t eggs tell jokes? They’d crack each other up",
            "I told my fridge a joke. It didn’t laugh, but the ice cracked",
            "Why did the smartphone go to therapy? It lost its touch"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int index = rnd.Next(jokes.Length);
            lblResult.Text = jokes[index];
        }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.Yellow, Color.Red, Color.Green, Color.Orange, Color.DarkGray, Color.BlueViolet, Color.DeepPink };
            this.BackColor = colors[rnd.Next(colors.Length)];
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();

            foreach (string joke in jokes)
            {
                if (joke.ToLower().Contains(query))
                {
                    lblResult.ForeColor = Color.Black;
                    lblResult.Text = joke;
                    return;
                }
            }

            lblResult.ForeColor = Color.Red;
            lblResult.Text = "No joke found";

        }
    }
}
