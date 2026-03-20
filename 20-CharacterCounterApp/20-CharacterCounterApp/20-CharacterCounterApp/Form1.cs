using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_CharacterCounterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCharacterCount();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            UpdateCharacterCount();
        }

        private void UpdateCharacterCount()
        {
            {
                int count = txtInput.Text.Length;
                lblCount.Text = $"Characters: {count}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
    }
}
