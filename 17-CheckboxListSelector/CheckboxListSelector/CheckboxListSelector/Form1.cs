using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxListSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>(); 

            foreach (Control c in this.Controls) 
            { 
                if (c is CheckBox checkbox && checkbox.Checked) 
                { 
                    selected.Add(checkbox.Text); 
                } 
            }
            lblResult.Text = string.Join(", ", selected);
        }
    }
}
