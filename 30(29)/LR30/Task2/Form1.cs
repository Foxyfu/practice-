using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private int position = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Перемещение изображения
            position += 1; // Шаг перемещения изображения (измените его по своему усмотрению)
            if (position > Width)
                position = -150;
            pictureBox.Location = new Point(position, pictureBox.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка изображения PNG
            string imagePath = "banner.png";
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
                position = -150; // Начальная позиция изображения за пределами формы
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }
    }
}