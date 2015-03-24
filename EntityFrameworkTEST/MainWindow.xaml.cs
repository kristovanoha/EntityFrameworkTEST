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


            //_context.Test.Load();
            //// Load data by setting the CollectionViewSource.Source property:
            //englishViewSource.Source = _context.Test.Local;
            ////gridTest.DataContext = _context.Test;
            ////gridTest.

            //var a = 4;
            //System.Windows.Data.CollectionViewSource testViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("testViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // testViewSource.Source = [generic data source]
        }
    }


}
