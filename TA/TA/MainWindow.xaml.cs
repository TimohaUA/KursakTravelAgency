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
using TA.DAL;
using TA.DAL.Helper;

namespace TA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // DbHelper h = new DbHelper();

            //lb_select.ItemsSource = h.GetCities();

            //h.SetCity(1, "Klevan_1", 1);

            //h.AddCity("XXX", 5);
        }
    }
}
