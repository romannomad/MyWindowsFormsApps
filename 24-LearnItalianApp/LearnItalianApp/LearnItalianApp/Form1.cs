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
            Random rnd = new Random();
            int index = rnd.Next(italianWords.Length);

            lblWords.Text = italianWords[index];

            lblWords.Left = (this.ClientSize.Width - lblWords.Width) / 2;

            wordsLearned++;
            lblCounter.Text = "Words learned: " + wordsLearned;
        }
    }
}
