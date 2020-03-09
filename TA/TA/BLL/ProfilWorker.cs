using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.DAL.Helper;
using TA.DAL;
using System.ComponentModel;

namespace TA.BLL
{
    public class ProfilWorker : INotifyPropertyChanged
    {
        DbHelper h = new DbHelper();

        #region ProfileForker
        private int id_worker;
        private string fio;
        private string position;
        private string email;
        private string phone;
        private string dateOfRec;

        public int ID_WORKER
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").Id;
            }
            set
            {
                id_worker = value;
                OnPropertyChanged("ID_WORKER");
            }
        }

        public string FIO
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").FIO;
            }
            set
            {
                fio = value;
                OnPropertyChanged("FIO");
            }
        }

        public string POSITION
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").Position;
            }
            set
            {
                position = value;
                OnPropertyChanged("POSITION");
            }
        }

        public string EMAIL
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").Email;
            }
            set
            {
                email = value;
                OnPropertyChanged("EMAIL");
            }
        }

        public string PHONE
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").PhoneNumber;
            }
            set
            {
                phone = value;
                OnPropertyChanged("PHONE");
            }
        }

        public string DATE_REC
        {
            get
            {
                List<AgencyWorker> workers = new List<AgencyWorker>();
                workers = h.GetWorker();
                return workers.Find(x => x.FIO == "Tymeichuk Oleksandr").DateOfRecruitment.ToShortDateString();
            }
            set
            {
                dateOfRec = value;
                OnPropertyChanged("DATE_REC");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        } 
        #endregion


    }
}
