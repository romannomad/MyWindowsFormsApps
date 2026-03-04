using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLight.Checked)
            {
                ApplyTheme("light");
            }
        }

        private void radioDark_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDark.Checked)
            {
                ApplyTheme("dark");
            }
        }

        private void radioContrast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioContrast.Checked)
            {
                ApplyTheme("contrast");
            }
        }
        private void radioOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOrange.Checked)
            {
                ApplyTheme("orange");
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            radioLight.Checked = true;
            ApplyTheme("light");
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            radioGreen.Checked = true;
            ApplyTheme("green");
        }

        private void ApplyTheme(string theme)
        {
            switch(theme)
            {
                case "light":
                
                        this.BackColor = Color.White;
                        lblPreview.ForeColor = Color.Black;
                        break;

                case "dark":
                    this.BackColor = Color.FromArgb(30, 30, 30);
                    lblPreview.ForeColor = Color.White;
                    break;

                case "contrast":
                    this.BackColor = Color.Black;
                    lblPreview.ForeColor = Color.Yellow;
                    break;

                case "orange":
                    this.BackColor = Color.Orange;
                    lblPreview.ForeColor = Color.White;
                    break;

                case "green":
                    this.BackColor = Color.Green;
                    lblPreview.ForeColor = Color.White;
                    break;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            string[] themes = { "light", "dark", "contrast", "orange", "green" };
            Random rnd = new Random();
            string color = themes[rnd.Next(themes.Length)];

            if (color == "light")
            {
                radioLight.Checked = true;
            }
            if (color == "dark")
            {
                radioDark.Checked = true;
            }
            if (color == "contrast")
            {
                radioContrast.Checked = true;
            }
            if (color == "orange")
            {
                radioOrange.Checked = true;
            }
            if (color == "green")
            {
                radioGreen.Checked = true;
            }

            ApplyTheme(color);
        }

    }

}
