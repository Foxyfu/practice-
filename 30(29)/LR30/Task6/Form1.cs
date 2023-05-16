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
            amplitude = 100; // ��������� �������� ����������
            frequency = 0.1f; // ������� �������� ����������
            phase = 9; // ��������� ���� �������� ����������
            centerX = ClientSize.Width / 2; // ����� ���������� �� �����������
            centerY = ClientSize.Height / 2; // ����� ���������� �� ���������
            angle = 0; // ������� ���� �������� ����������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 0.2f; // ��� ��������� ���� �������� ���������� (�������� ��� �� ������ ����������)

            // ���������� ����� ������� ���������� �� ������ ���������
            float x = centerX + amplitude * (float)Math.Sin(frequency * angle + phase);
            float y = centerY;

            // ������� ����
            using (Graphics g = CreateGraphics())
            {
                g.Clear(Color.White);
            }

            // ��������� ����������
            using (Graphics g = CreateGraphics())
            {
                int diameter = 100; // ������� ���������� (�������� ��� �� ������ ����������)
                float radius = diameter / 2f;
                float circleX = x - radius;
                float circleY = y - radius;

                g.DrawEllipse(pen, circleX, circleY, diameter, diameter);
            }
        }
    }
}