using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TA.DAL.Helper;
using TA.DAL;
using System.Collections.ObjectModel;
using TA.BLL.Comands;

namespace TA.BLL
{
    public class ShowPlace : INotifyPropertyChanged
    {
        DbHelper h = null;

        public ShowPlace()
        {
            h = new DbHelper();
            var t = from i in h.GetShowPlaceImg()
                    join sp in h.GetShowPlace() on i.Id equals sp.Id
                    join ct in h.GetCities() on sp.CityId equals ct.Id
                    join c in h.GetCountryes() on ct.CountryId equals c.Id
                    select new {i.ImageURL, sp.ShowPlaceName, ct.CityName, c.CountryName };
            spi_list = new List<ShowPlaceInfo>();
            foreach (var item in t)
            {
                spi_list.Add(new ShowPlaceInfo { IMG = item.ImageURL, NAME = item.ShowPlaceName, CITY = item.CityName, COUNTRY = item.CountryName });
            }
        }

        private List<ShowPlaceInfo> spi_list;
        public List<ShowPlaceInfo> SPI_LIST
        {
            get
            {
                return spi_list;
            }
            set
            {
                spi_list = value;
                OnPropertyChanged("SPI_LIST");
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
