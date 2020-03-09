using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TA.DAL;
using TA.DAL.Helper;

namespace TA.BLL
{
    public class NextTours : INotifyPropertyChanged
    {
        DbHelper h = new DbHelper();

        public NextTours()
        {
            NEXT_T_LIST = h.GetToursActual();
        }

        private List<Tour> next_t_list;
        public List<Tour> NEXT_T_LIST
        {
            get
            {           
                return next_t_list;
            }
            set
            {
                next_t_list = value;
                OnPropertyChanged("NEXT_T_LIST");
            }
        }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
