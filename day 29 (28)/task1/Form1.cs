namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            Pen blackPen = new Pen(Color.Black);

            // Вычисление координат и радиуса для внешнего круга
            int x = ClientSize.Width / 2;
            int y = ClientSize.Height / 2;
            int radius = Math.Min(ClientSize.Width/2, ClientSize.Height/2) / 2;

            // Рисование внешнего круга
            graphics.DrawEllipse(blackPen, x - radius, y - radius, radius * 2, radius * 2);

            // Вычисление координат и радиуса для внутреннего круга
            int innerRadius = radius / 2;

            // Рисование внутреннего круга
            graphics.DrawEllipse(blackPen, x - innerRadius, y - innerRadius, innerRadius * 2, innerRadius * 2);
            graphics.DrawEllipse(blackPen, x - innerRadius/2, y - innerRadius/2, innerRadius, innerRadius);
        }
    }
}