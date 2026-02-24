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
        Random rnd = new Random();

        int wordsLearned = 0;
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
            "lento - slow",
            "buongiorno - good morning",
            "buonasera - good evening",
            "arrivederci - goodbye",
            "per favore - please",
            "mi dispiace - I'm sorry",
            "sì - yes",
            "no - no",
            "forse - maybe",
            "latte - milk",
            "formaggio - cheese",
            "vino - wine",
            "birra - beer",
            "frutta - fruit",
            "verdura - vegetables",
            "pollo - chicken",
            "pesce - fish",
            "treno - train",
            "aeroporto - airport",
            "biglietto - ticket",
            "albergo - hotel",
            "ristorante - restaurant",
            "bagno - bathroom",
            "mappa - map",
            "centro - city center",
            "bambino - child",
            "donna - woman",
            "uomo - man",
            "parlare - to speak",
            "mangiare - to eat",
            "andare - to go",
            "vedere - to see"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            int index = rnd.Next(italianWords.Length);

            lblWords.Text = italianWords[index];

            lblWords.Left = (this.ClientSize.Width - lblWords.Width) / 2;

            wordsLearned++;
            lblCounter.Text = "Words learned: " + wordsLearned;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(
                rnd.Next(150, 255),
                rnd.Next(150, 255),
                rnd.Next(150, 255)

                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawItalianFlag(e.Graphics);
        }

        private void DrawItalianFlag(Graphics g)
        {
            int x = 10;
            int y = 10;
            int width = 45;
            int height = 30;

            g.FillRectangle(Brushes.Green, x, y, width / 3, height);
            g.FillRectangle(Brushes.White, x + width / 3, y, width / 3, height);
            g.FillRectangle(Brushes.Red, x + 2 * (width / 3), y, width / 3, height);

            g.DrawRectangle(Pens.Black, x, y, width, height);
        }
    }
}
