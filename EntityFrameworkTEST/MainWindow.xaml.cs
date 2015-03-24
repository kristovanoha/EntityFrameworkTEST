using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace EntityFrameworkTEST
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

        private DatabaseSlovnikEntities _context = new DatabaseSlovnikEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource testViewSource =
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("testViewSource")));

            _context.Test.Load();
            testViewSource.Source = _context.Test.Local;

            CollectionViewSource viewSource =((CollectionViewSource)(this.FindResource("viewSource")));
            _context.Test2.Load();
            viewSource.Source = _context.Test2.Local;
      
        }
    }


}
