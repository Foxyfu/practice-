using Microsoft.Win32;

using System;
using System.CodeDom;
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
using System.Xml;

using Task1.Interfaces;
using Task1.Models;
using Task1.Share;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum ViewMode
        {
            TextBlock,
            ListBox,
            TreeView
        }

        public bool IsFileOpened = false;
        private string _path;
        private readonly IXmlWorker _worker;
        private ViewMode viewMode;
        public MainWindow()
        {
            InitializeComponent();
            _worker = new XmlDocumentWorker();
        }

        public void AddRecord(Record record)
        {
            _worker.Add(record);
            PrintRecords(_worker.GetAll());
        }

        private void FindRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            Record record = _worker.GetBySurname(SurnameTBox.Text);
            PrintRecord(record);
        }

        private void PrintRecord(Record record)
        {
            switch (viewMode)
            {
                case ViewMode.TextBlock:
                    OutputTxtBlock.Text = "=======Запись=======" + Environment.NewLine;
                    OutputTxtBlock.Text += record?.ToString() ?? "Запись не найдена!";
                    break;
                case ViewMode.ListBox:
                    OutputLstBox.Items.Clear();
                    OutputLstBox.Items.Add(record);
                    break;
                case ViewMode.TreeView:
                    OutputTreeView.Items.Clear();
                    OutputTreeView.Items.Add(record);
                    break;
            }

        }

        private void PrintRecords(List<Record> records)
        {
            switch (viewMode)
            {
                case ViewMode.TextBlock:
                    OutputTxtBlock.Text = "=======Записи=======" + Environment.NewLine;
                    foreach (Record record in records)
                    {
                        OutputTxtBlock.Text += record.ToString();
                    }
                    break;
                case ViewMode.ListBox:
                    OutputLstBox.Items.Clear();
                    OutputLstBox.Items.Add("=======Записи=======");
                    foreach (Record record in records)
                    {
                        OutputLstBox.Items.Add(record);
                    }
                    break;
                case ViewMode.TreeView:
                    OutputTreeView.Items.Clear();
                    OutputTreeView.Items.Add("=======Записи=======");
                    foreach (Record record in records)
                    {
                        OutputTreeView.Items.Add(record);
                    }
                    break;
            }
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DeleteRecordTBox.Text) && !string.IsNullOrWhiteSpace(DeleteRecordTBox.Text))
            {
                _worker.Delete(DeleteRecordTBox.Text);
                PrintRecords(_worker.GetAll());
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "XML документы (.xml)|*.xml";
            bool? isOpen = dialog.ShowDialog();
            if (isOpen.HasValue && isOpen.Value)
            {
                _path = dialog.FileName;
                _worker.Load(_path);
                PrintRecords(_worker.GetAll());
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddRecordForm addRecordForm = new AddRecordForm(this);
            addRecordForm.Show();
        }

        private void ChangeView(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Name)
            {
                case "TextBlockRadBtn":
                    viewMode = ViewMode.TextBlock;
                    break;
                case "TreeViewRadBtn":
                    viewMode = ViewMode.TreeView;
                    break;
                case "ListBoxRadBtn":
                    viewMode = ViewMode.ListBox;
                    break;
            }
            UpdateView();
        }

        private void UpdateView()
        {
            switch(viewMode)
            {
                case ViewMode.TextBlock:
                    Grid.SetZIndex(OutputTxtBlock, 0);
                    Grid.SetZIndex(OutputLstBox, -1);
                    Grid.SetZIndex(OutputTreeView, -1);
                    break;
                case ViewMode.TreeView:
                    Grid.SetZIndex(OutputTxtBlock, -1);
                    Grid.SetZIndex(OutputLstBox, -1);
                    Grid.SetZIndex(OutputTreeView, 0);
                    break;
                case ViewMode.ListBox:
                    Grid.SetZIndex(OutputTxtBlock, -1);
                    Grid.SetZIndex(OutputLstBox, 0);
                    Grid.SetZIndex(OutputTreeView, -1);
                    break;
            }
        }
    }
}
