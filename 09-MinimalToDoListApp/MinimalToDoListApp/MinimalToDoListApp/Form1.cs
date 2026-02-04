using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimalToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();

            if (task != "")
            {
                listTasks.Items.Add(task);
                txtTask.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem != null)
            {
                listTasks.Items.Remove(listTasks.SelectedItem);
            }
        }
    }
}
