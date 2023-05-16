using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private float amplitude;
        private float frequency;
        private float phase;
        private float centerX;
        private float centerY;
        private float angle;
        private Pen pen = new Pen(Color.Blue, 6);
        public Form1()
        {
            InitializeComponent();
            amplitude = 100; // Амплитуда движения окружности
            frequency = 0.1f; // Частота движения окружности
            phase = 9; // Начальная фаза движения окружности
            centerX = ClientSize.Width / 2; // Центр окружности по горизонтали
            centerY = ClientSize.Height / 2; // Центр окружности по вертикали
            angle = 0; // Текущий угол движения окружности
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 0.2f; // Шаг изменения угла движения окружности (измените его по своему усмотрению)

            // Вычисление новой позиции окружности на основе синусоиды
            float x = centerX + amplitude * (float)Math.Sin(frequency * angle + phase);
            float y = centerY;

            // Очистка фона
            using (Graphics g = CreateGraphics())
            {
                g.Clear(Color.White);
            }

            // Отрисовка окружности
            using (Graphics g = CreateGraphics())
            {
                int diameter = 100; // Диаметр окружности (измените его по своему усмотрению)
                float radius = diameter / 2f;
                float circleX = x - radius;
                float circleY = y - radius;

                g.DrawEllipse(pen, circleX, circleY, diameter, diameter);
            }
        }
    }
}