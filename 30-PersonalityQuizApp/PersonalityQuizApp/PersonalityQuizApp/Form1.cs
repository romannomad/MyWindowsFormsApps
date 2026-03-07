using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalityQuizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string result = "";

            if (radioBeach.Checked)
            {
                result = "You’re a free‑spirited, optimistic person who loves open space and adventure.";
            }

            else if (radioForest.Checked)
            {
                result = "You’re calm, thoughtful, and recharge best in peaceful environments.";
            }

            else if (radioCozy.Checked)
            {
                result = "You’re introspective, creative, and enjoy comfort and warm vibes.";
            }

            else if (radioCity.Checked)
            {
                result = "You’re energetic, social, and thrive in fast‑paced environments.";
            }

            else
            {
                result = "Please choose an option first!";
            }

            MessageBox.Show(result, "Your Personality");
        }
    }
}
