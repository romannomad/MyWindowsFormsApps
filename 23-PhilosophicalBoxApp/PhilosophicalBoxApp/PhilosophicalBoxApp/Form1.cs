using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PhilosophicalBoxApp
{
    public partial class Form1 : Form
    {
        string[] sentences =
        {
"The mind becomes clearer the moment you stop trying to impress others and start listening to yourself.",

"Most people chase certainty, yet growth only happens in the places where certainty ends.",

"You cannot control the wind, but you can always adjust the direction of your steps.",

"Peace is not found by escaping life, but by learning to stand calmly in the middle of it.",

"A person becomes wise the moment they realize how little they truly understand.",

"Every choice you make is a vote for the person you are becoming.",

"Time reveals truth in ways that words never can.",

"The world changes when you change the way you choose to see it.",

"Strength is not the absence of fear, but the decision to move forward despite it.",

"Happiness grows quietly in the places where gratitude is allowed to take root."
        };

        Color[] colors =
            {
        Color.Blue,
        Color.Yellow,
        Color.Orange,
        Color.Green,
        Color.Orchid,
        Color.Purple,
        Color.Red,
        Color.AliceBlue,
        Color.Azure,
        Color.Goldenrod
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random lines = new Random();
            int index = lines.Next(sentences.Length);

            MessageBox.Show(sentences[index]);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(colors.Length);
            this.BackColor = colors[index];

            btnColor.BackColor = Color.Orange;
        }
    }
}
