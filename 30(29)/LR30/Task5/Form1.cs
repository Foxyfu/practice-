using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int position;
        private void Form1_Load(object sender, EventArgs e)
        {
            position = pictureBox1.Location.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ѕеремещение изображени€
            position -= 1; // Ўаг перемещени€ изображени€ (измените его по своему усмотрению
            pictureBox1.Location = new Point(pictureBox1.Location.X, position);

        }
    }
}