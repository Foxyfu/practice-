using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Приложени_Hello_Name
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonRun.Click += ButtonRun_Click;
            ButtonClose.Click += ButtonClose_Click;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string inputName = string.Empty;
            if(string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                inputName = "World";
            }
            else
            {
                inputName = TextBoxName.Text;
            }
            TextBlockName.Text= $"{hello} {inputName }";
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
           MessageBox.Show(info);
        }
    }
}
