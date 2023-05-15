namespace task3
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

            Graphics g = e.Graphics;

            // Рисуем тело рыбы (эллипс)
            int bodyWidth = 100;
            int bodyHeight = 50;
            int bodyX = (ClientSize.Width - bodyWidth) / 2;
            int bodyY = (ClientSize.Height - bodyHeight) / 2;
            Rectangle bodyRect = new Rectangle(bodyX, bodyY, bodyWidth, bodyHeight);
            g.FillEllipse(Brushes.OrangeRed, bodyRect);
            g.DrawEllipse(Pens.Black, bodyRect);

            // Рисуем плавник (треугольник)
            Point[] finPoints = new Point[]
            {
                new Point(bodyX + bodyWidth, bodyY + bodyHeight / 2),
                new Point(bodyX + bodyWidth + 30, bodyY),
                new Point(bodyX + bodyWidth + 30, bodyY + bodyHeight)
            };
            g.FillPolygon(Brushes.Red, finPoints);
            g.DrawPolygon(Pens.Black, finPoints);

            // Рисуем глаз (эллипс)
            int eyeSize = 10;
            int eyeX = bodyX + 10;
            int eyeY = bodyY + bodyHeight / 2 - eyeSize / 2;
            Rectangle eyeRect = new Rectangle(eyeX, eyeY, eyeSize, eyeSize);
            g.FillEllipse(Brushes.White, eyeRect);
            g.DrawEllipse(Pens.Black, eyeRect);

            // Рисуем рот (дуга)
            int mouthX = bodyX + bodyWidth / 2 - 20;
            int mouthY = bodyY + bodyHeight / 2;
            g.DrawArc(Pens.Black, mouthX, mouthY, 40, 20, 0, -180);
        }
    }
}