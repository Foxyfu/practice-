using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
 
            Graphics g = e.Graphics;


            DrawSmiley(g, 50, 50);
            DrawSmiley(g, 150, 50);
            DrawSmiley(g, 250, 50);
        }

        private void DrawSmiley(Graphics g, int x, int y)
        {

            g.DrawEllipse(Pens.Black, x, y, 50, 50);

            g.FillEllipse(Brushes.Black, x + 10, y + 10, 10, 10);
            g.FillEllipse(Brushes.Black, x + 30, y + 10, 10, 10);

            g.DrawArc(Pens.Black, x + 10, y + 20, 30, 20, 0, -180);
        }
    }
}
