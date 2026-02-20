using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnItalianApp
{
    public partial class Form1 : Form
    {
        string[] italianWords =
        {
            "ciao - hello",
            "grazie - thank you",
            "prego - you're welcome",
            "amico - friend",
            "famiglia - family",
            "casa - house",
            "acqua - water",
            "pane - bread",
            "gatto - cat",
            "cane - dog",
            "libro - book",
            "strada - street",
            "tempo - time/weather",
            "lavoro - work",
            "scuola - school",
            "notte - night",
            "giorno - day",
            "felice - happy",
            "veloce - fast",
            "lento - slow"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index = rnd.Next(italianWords.Length);

            MessageBox.Show(italianWords[index]);
        }
    }
}
