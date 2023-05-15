using Day27Prac26.Interfaces;
using Day27Prac26.Models;
using Day27Prac26.Share;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Day27Prac26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlSweets _worker;
  
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path = "D:\\кпияп\\практика по с#\\Practica\\Day27Prac26\\Day27Prac26\\File\\sweets.xml\\";
            SweetsSet sweets = new SweetsSet();
            XmlDocumentSweets xml = new XmlDocumentSweets();
            xml.Add(sweets);
        
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml document (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                TextBlock3.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var sweets = _worker.FindBy(TextBox1.Text);
            PrintBooks(sweets);
        }
        private void PrintBooks(SweetsSet sweets)
        {
            TextBlock1.Text = "========Sweet========" + Environment.NewLine;
            TextBlock2.Text += sweets?.ToString() ?? "Sweet not found";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.Checked)
            {
                TextBlock2.Text += sweets?.ToString() ?? "Sweet not found";
            }
        }
    }
}
