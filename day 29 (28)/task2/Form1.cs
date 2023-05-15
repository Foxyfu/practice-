namespace task2
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
            int x = 10;
            int y = 10;
            int Width = 50; int Height = 100;

            for (int i = 0; i < 150; i += 30)
            {
                graphics.DrawRectangle(blackPen, x + i, y + i * 2, Width, Height);

            }
        }
    }
}