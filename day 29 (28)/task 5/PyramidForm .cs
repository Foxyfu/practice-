using System.Drawing.Drawing2D;

namespace task_5
{
    public partial class Form1 : Form
    {

        private Button triangleButton;
        private Button circleButton;
        private Button squareButton;
        public Form1()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Создаем треугольную кнопку
            var triangleButton = new Button();
            triangleButton.Text = "Triangle";
            triangleButton.Width = 100;
            triangleButton.Height = 50;
            triangleButton.Location = new Point(100, 100);
            triangleButton.Paint += (sender, e) =>
            {
                var button = (Button)sender;
                var path = new GraphicsPath();
                path.AddPolygon(new Point[] {
                new Point(0, button.Height),
                new Point(button.Width / 2, 0),
                new Point(button.Width, button.Height)
            });
                button.Region = new Region(path);
            };

            // Создаем круглую кнопку
            var circleButton = new Button();
            circleButton.Text = "Circle";
            circleButton.Width = 100;
            circleButton.Height = 100;
            circleButton.Location = new Point(150, 150);
            circleButton.Paint += (sender, e) =>
            {
                var button = (Button)sender;
                var path = new GraphicsPath();
                path.AddEllipse(0, 0, button.Width, button.Height);
                button.Region = new Region(path);
            };

            // Создаем квадратную кнопку
            var squareButton = new Button();
            squareButton.Text = "Square";
            squareButton.Width = 100;
            squareButton.Height = 100;
            squareButton.Location = new Point(200, 200);

            // Добавляем кнопки на форму
            Controls.Add(triangleButton);
            Controls.Add(circleButton);
            Controls.Add(squareButton);

            // Устанавливаем размеры формы
            Size = new Size(500, 500);
        }
    }
}