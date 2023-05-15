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

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button bt = (Button)sender;
            c.Children.Remove(bt);
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Button bt = new Button();
            bt.Width = 100;
            bt.Height = 20;
            Random r = new Random();
            bt.Margin = new Thickness(r.Next(0, 1000), r.Next(0, 1000), 0, 0);
            bt.PreviewMouseMove += Button_PreviewMouseMove;
            bt.Click += Button_Click;
            c.Children.Add(bt);
        }
    }
}
