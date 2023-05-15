using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart chart1 = new Chart();

            chart1.Size = new Size(400, 300);
            chart1.Location = new Point(10, 10);

            this.Controls.Add(chart1);

            ChartArea chartArea1 = new ChartArea();

            chart1.ChartAreas.Add(chartArea1);

            Series series1 = new Series();

            series1.ChartType = SeriesChartType.Line;

            chart1.Series.Add(series1);

            int x = int.Parse(textBox1.Text);
            int h = int.Parse(textBox2.Text);
            
            for (int i = 0;  i <= x; i += h) 
            {
                int y = i * i;
                series1.Points.AddXY(i, y);
            }
            

           
        }
    }
}
