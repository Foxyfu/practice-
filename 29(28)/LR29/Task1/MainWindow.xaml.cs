using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateChessboard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Color fillColor = (row + col) % 2 == 0 ? Colors.White : Colors.Black;
                    SolidColorBrush brush = new SolidColorBrush(fillColor);
                    Rectangle rect = new Rectangle { Fill = brush, Width = 40, Height = 40 };
                    chessboardCanvas.Children.Add(rect);
                    Canvas.SetTop(rect, row * 40);
                    Canvas.SetLeft(rect, col * 40);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateChessboard();
        }
    }
}
