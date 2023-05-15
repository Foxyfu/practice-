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

namespace _2
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

        private void ButtonCount_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(TextBoxInputX.Text);
            double h = double.Parse(TextBoxInputH_Copy.Text);
            double i = 0;
            while(i<x)
            {
                double y = 1 /i ;
                
                TextBoxXY.Text += Environment.NewLine + $"x - {i.ToString()} y - {y.ToString()}";
                i += h;
             
            }
        }
    }
}
