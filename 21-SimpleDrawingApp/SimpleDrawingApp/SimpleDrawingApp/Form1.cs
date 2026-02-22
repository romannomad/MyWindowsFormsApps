using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = canvas.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }

                lastPoint = e.Location;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
        }
    }
}
