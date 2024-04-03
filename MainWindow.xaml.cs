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
using DataBaseLab3.CatCafeDataSetTableAdapters;

namespace DataBaseLab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        catsTableAdapter cats = new catsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            CatsDataGrid.ItemsSource = cats.GetFullInfo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CatsDataGrid.Columns[0].Visibility = Visibility.Collapsed;
            CatsDataGrid.Columns[1].Header = "Кличка";
            CatsDataGrid.Columns[2].Header = "Возраст";
            CatsDataGrid.Columns[3].Header = "Пол";
            CatsDataGrid.Columns[4].Header = "Возможность забрать домой";
            CatsDataGrid.Columns[5].Visibility = Visibility.Collapsed;
            CatsDataGrid.Columns[6].Header = "Имя";
            CatsDataGrid.Columns[7].Header = "Фамилия";
            CatsDataGrid.Columns[8].Header = "Отчество";
            CatsDataGrid.Columns[9].Header = "Опыт работы";
        }

        private void NextTable_Click(object sender, RoutedEventArgs e)
        {
            WindowEF window = new WindowEF();
            window.ShowDialog();
        }
    }
}
