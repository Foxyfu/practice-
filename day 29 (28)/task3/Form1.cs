using System.Drawing;

namespace task3
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 8;
        private const int SquareSize = 50;
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
            Text = "��������� �����";

            // ������������� �� ������� Paint
            Paint += ChessboardForm_Paint;
        }



        private void ChessboardForm_Paint(object sender, PaintEventArgs e)
        {
            // ������� ������ Graphics ��� ��������� �� �����
            Graphics g = e.Graphics;

            // �������� �� ������ ������ �����
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    // ��������� ���������� ������� ������
                    int x = col * SquareSize;
                    int y = row * SquareSize;

                    // ���������� ���� ������ � ����������� �� �� �������
                    Color color = (row + col) % 2 == 0 ? Color.White : Color.Black;

                    // ������� ������ ����� ��� ������������ ������
                    SolidBrush brush = new SolidBrush(color);

                    // ����������� ������
                    g.FillRectangle(brush, x, y, SquareSize, SquareSize);

                    // ����������� ������� �����
                    brush.Dispose();
                }
            }

            // ����������� ������� ������� Graphics
            g.Dispose();
        }
    }
}