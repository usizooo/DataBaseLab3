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

namespace DataBaseLab3
{
    /// <summary>
    /// Логика взаимодействия для WindowEF.xaml
    /// </summary>
    public partial class WindowEF : Window
    {
        private CatCafeEntities context = new CatCafeEntities();    
        public WindowEF()
        {
            InitializeComponent();
            CatsEFDataGrid.ItemsSource = context.cats.ToList();
        }
    }
}
