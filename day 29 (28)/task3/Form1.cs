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
            Text = "Шахматная доска";

            // Подписываемся на событие Paint
            Paint += ChessboardForm_Paint;
        }



        private void ChessboardForm_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics для рисования на форме
            Graphics g = e.Graphics;

            // Проходим по каждой клетке доски
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    // Вычисляем координаты текущей клетки
                    int x = col * SquareSize;
                    int y = row * SquareSize;

                    // Определяем цвет клетки в зависимости от ее позиции
                    Color color = (row + col) % 2 == 0 ? Color.White : Color.Black;

                    // Создаем объект кисти для закрашивания клетки
                    SolidBrush brush = new SolidBrush(color);

                    // Закрашиваем клетку
                    g.FillRectangle(brush, x, y, SquareSize, SquareSize);

                    // Освобождаем ресурсы кисти
                    brush.Dispose();
                }
            }

            // Освобождаем ресурсы объекта Graphics
            g.Dispose();
        }
    }
}