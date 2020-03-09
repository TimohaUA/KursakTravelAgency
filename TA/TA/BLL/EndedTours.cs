using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TA.DAL;
using TA.DAL.Helper;

namespace TA.BLL
{
    public class EndedTours : INotifyPropertyChanged
    {
        DbHelper h = new DbHelper();

        public EndedTours()
        {
            END_T_LIST = h.GetToursEnded();
        }

        private List<Tour> end_t_list;
        public List<Tour> END_T_LIST
        {
            get
            {
                return end_t_list;
            }
            set
            {
                end_t_list = value;
                OnPropertyChanged("END_T_LIST");
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
