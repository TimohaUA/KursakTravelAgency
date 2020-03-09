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
using TA.BLL;
using TA.BLL.Comands;
using TA.DAL;

namespace TA.UI
{
    /// <summary>
    /// Логика взаимодействия для RadagClient.xaml
    /// </summary>
    public partial class RadagClient : Window
    {
        //public Client SelectClient { get; set; }
        public RadagClient(/*Client select*/)
        {
            InitializeComponent();
            //SelectClient = select;
            //grid.DataContext = SelectClient;
        }






        // зніміть з процесів, бо в мене мій таскменеджер загружається
    }
}
