using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TA.BLL.Comands;
using TA.DAL.Helper;

namespace TA.BLL
{
    public class Hotell : INotifyPropertyChanged
    {
        DbHelper h = null;

        public Hotell()
        {
            h = new DbHelper();
            var t = from i in h.GetHotelImg()
                    join sp in h.GetHotels() on i.Id equals sp.Id
                    join ct in h.GetCities() on sp.CityId equals ct.Id
                    join c in h.GetCountryes() on ct.CountryId equals c.Id
                    select new { i.ImageURL, sp.HotelsName, ct.CityName, c.CountryName };
            sph_list = new List<HotellInfo>();
            foreach (var item in t)
            {
                sph_list.Add(new HotellInfo { IMG = item.ImageURL, NAME = item.HotelsName, CITY = item.CityName, COUNTRY = item.CountryName });
            }
        }

        private List<HotellInfo> sph_list;
        public List<HotellInfo> SPH_LIST
        {
            get
            {
                return sph_list;
            }
            set
            {
                sph_list = value;
                OnPropertyChanged("SPH_LIST");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
