namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
            Text = "Рисование фигур";

            Paint += new PaintEventHandler(DrawingForm_Paint);
        }

        private void DrawingForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисование треугольника
            Point[] trianglePoints = { new Point(50, 50), new Point(150, 150), new Point(50, 150) };
            g.DrawPolygon(Pens.Black, trianglePoints);

            // Рисование эллипса
            Rectangle ellipseRect = new Rectangle(200, 50, 100, 200);
            g.DrawEllipse(Pens.Black, ellipseRect);

            // Закрашивание круга
            Rectangle filledCircleRect = new Rectangle(350, 50, 100, 100);
            g.FillEllipse(Brushes.Red, filledCircleRect);

            // Закрашивание прямоугольника
            Rectangle filledRectangleRect = new Rectangle(50, 250, 200, 100);
            g.FillRectangle(Brushes.Blue, filledRectangleRect);

            // Рисование сектора
            Rectangle sectorRect = new Rectangle(300, 250, 150, 150);
            g.DrawPie(Pens.Black, sectorRect, 45, 90);
        }
    }
}