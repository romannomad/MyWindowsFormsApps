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
            }
        }
    }

   
}
