using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachMouseEnterHandler();
        }

        private void AttachMouseEnterHandler()
        {
            foreach (Control control in Controls)
            {
                control.MouseEnter += new EventHandler(OnMouseEnter);
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Controls.Remove(control);
            control.Dispose();
        }
    }
}
