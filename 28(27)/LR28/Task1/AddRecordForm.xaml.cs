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
using System.Windows.Shapes;

using Task1.Models;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AddRecordForm.xaml
    /// </summary>
    public partial class AddRecordForm : Window
    {
        MainWindow _sender;
        public AddRecordForm(MainWindow sender)
        {
            InitializeComponent();
            _sender = sender;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Record record = new Record(SurnameTBox.Text, BirthdayPicker.Text, PhoneTBox.Text);
            _sender.AddRecord(record);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
