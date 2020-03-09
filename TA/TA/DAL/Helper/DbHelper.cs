using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA.DAL.Helper
{
    public class DbHelper
    {
        #region AgenWork_GET_SET_UPDATE
        public List<AgencyWorker> GetWorker()
        {
            List<AgencyWorker> temp = new List<AgencyWorker>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.AgencyWorkers
                        select i).ToList();
            }
            return temp;
        }

        public void SetWorker(int _id, string _FIO, string _position, string _email, string _phone, DateTime _dayOfRecrut)
        {
            var temp = new AgencyWorker
            {
                Id = _id,
                FIO = _FIO,
                Position = _position,
                Email = _email,
                PhoneNumber = _phone,
                DateOfRecruitment = _dayOfRecrut.Date
            };

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddWorker(string _FIO, string _position, string _email, string _phone, DateTime _dayOfRecrut)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.AgencyWorkers.Add(new AgencyWorker
                {
                    FIO = _FIO,
                    Position = _position,
                    Email = _email,
                    PhoneNumber = _phone,
                    DateOfRecruitment = _dayOfRecrut.Date
                });

                db.SaveChanges();
            }
        }
        #endregion



        #region Clients_GET_SET_UPDATE  
        public List<Client> GetClients()
        {
            List<Client> temp = new List<Client>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Clients
                        select i).ToList() /*as ObservableCollection<Client>*/;
            }
            return temp;
        }

        public void AddClient(string _FIO, string _email, string _phone, DateTime _dayBirt)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Clients.Add(new Client { FIO = _FIO, Email = _email, PhoneNumber = _phone, DateOfBirth = _dayBirt });
                db.SaveChanges();
            }
        }

        public void SetClient(int _id, string _FIO, string _email, string _phone, DateTime _dayBirt)
        {
            var temp = new Client
            {
                Id = _id,
                FIO = _FIO,
                Email = _email,
                PhoneNumber = _phone,
                DateOfBirth = _dayBirt
            };

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DelClient(Client client)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                Client temp = db.Clients.FirstOrDefault(x => x.Id == client.Id);
                if (temp != null)
                {
                    db.Clients.Remove(temp);
                    db.SaveChanges();
                }
            }
        }
        #endregion
        // зроблено


        #region ImagesShowPlace_GET_SET_UPDATE  
        public List<ImagesShowPlace> GetShowPlaceImg()
        {
            List<ImagesShowPlace> temp = new List<ImagesShowPlace>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.ImagesShowPlaces
                        select i).ToList();
            }
            return temp;
        }

        public List<ShowPlace> GetShowPlace()
        {
            List<ShowPlace> temp = new List<ShowPlace>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.ShowPlaces
                        select i).ToList();
            }
            return temp;
        }
        #endregion



        #region ImagesHotel_GET_SET_UPDATE  
        public List<ImagesHotel> GetHotelImg()
        {
            List<ImagesHotel> temp = new List<ImagesHotel>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.ImagesHotels
                        select i).ToList();
            }
            return temp;
        }

        public List<Hotel> GetHotels()
        {
            List<Hotel> temp = new List<Hotel>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Hotels
                        select i).ToList();
            }
            return temp;
        }
        #endregion      



        #region City_GET_SET_UPDATE
        public List<City> GetCities()
        {
            List<City> temp = new List<City>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Cities
                        select i).ToList();
            }
            return temp;
        }

        public void SetCity(int _id, string _cityName, int _countryId)
        {
            var temp = new City { Id = _id, CityName = _cityName, CountryId = _countryId };

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddCity(string _cityName, int _countryId)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Cities.Add(new City { CityName = _cityName, CountryId = _countryId });

                db.SaveChanges();
            }
        }
        #endregion



        #region Country_GET_SET_UPDATE
        public List<Country> GetCountryes()
        {
            List<Country> temp = new List<Country>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Countries
                        select i).ToList();
            }
            return temp;
        }

        public void SetCountry(int _id, string _CountryName)
        {
            var temp = new Country { Id = _id, CountryName = _CountryName };

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddCountry(string _CountryName)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Countries.Add(new Country { CountryName = _CountryName });
                db.SaveChanges();
            }
        }
        #endregion


        #region Tour_GET_SET_UPDATE
        public List<Tour> GetToursEnded()
        {
            List<Tour> temp = new List<Tour>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Tours
                        where i.StartDate < DateTime.Today
                        select i).ToList() /*as ObservableCollection<Tour>*/;
            }
            return temp;
        }

        public List<Tour> GetToursActual()
        {
            List<Tour> temp = new List<Tour>();

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                temp = (from i in db.Tours
                        where i.StartDate > DateTime.Today
                        select i).ToList();
            }
            return temp;
        }

        public void SetTour(int _id, string _TourName, DateTime _start, DateTime _end, double _price,
                                    int _max_tourist, bool _isDel, int _sale)
        {
            var temp = new Tour
            {
                Id = _id,
                TourName = _TourName,
                StartDate = _start.Date,
                EndDate = _end.Date,
                Price = Convert.ToDecimal(_price),
                MaxTourists = _max_tourist,
                IsDeleted = _isDel,
                Sale = _sale
            };

            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddTour(string _TourName, DateTime _start, DateTime _end, double _price,
                                    int _max_tourist, int _sale)
        {
            using (TravelAgencyEntities db = new TravelAgencyEntities())
            {
                db.Tours.Add(new Tour
                {
                    TourName = _TourName,
                    StartDate = _start.Date,
                    EndDate = _end.Date,
                    Price = Convert.ToDecimal(_price),
                    MaxTourists = _max_tourist,
                    IsDeleted = false,
                    Sale = _sale
                });
                db.SaveChanges();
            }
        }
        #endregion






    }
}
