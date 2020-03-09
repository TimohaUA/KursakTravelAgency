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
using System.Windows.Input;
using TA.UI;
using TA.BLL.Comands;

namespace TA.BLL
{
    public class Clients : INotifyPropertyChanged
    {
        DbHelper h = null;

        public Client selectClient { get; set; }

        public ButtonClick ButtonClick { get; set; }
        public ButtonOKredag ButtonOk { get; set; }
        public ButtonCencel ButtonCen { get; set; }

        public ButtonAddClient ButtonAddCl { get; set; }
        public ButtonAddOk ButtonAddClOk { get; set; }
        public ButtonAddCencel ButtonAddClCencel { get; set; }

        public ButtonDelClient ButtonDelClient { get; set; }

        public Clients()
        {
            h = new DbHelper();
            //child = new RadagClient(selectClient);
            selectClient = new Client();
            C_LIST = h.GetClients();
            ButtonClick = new ButtonClick(this);
            ButtonOk = new ButtonOKredag(this);
            ButtonCen = new ButtonCencel(this);

            ButtonAddCl = new ButtonAddClient(this);
            ButtonAddClOk = new ButtonAddOk(this);
            ButtonAddClCencel = new ButtonAddCencel(this);

            ButtonDelClient = new ButtonDelClient(this);
        }

        private RadagClient redagWindow = null;
        public RadagClient RedagWindow { get => redagWindow; set => redagWindow = value; }


        private AddClient addClientWindow = null;
        public AddClient AddClientWindow { get => addClientWindow; set => addClientWindow = value; }


        private List<Client> c_list;
        public List<Client> C_LIST
        {
            get
            {
                return c_list;
            }
            set
            {
                c_list = value;
                OnPropertyChanged("C_LIST");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public void OpenRadag()
        {
            redagWindow = new RadagClient(/*selectClient*/) { DataContext = this };
            RedagWindow.ShowDialog();
        }

        public void CencelRadag()
        {
            redagWindow.Close();
        }

        public void OkRadag()
        {
            if (RedagWindow.tb_PIB.Text != "" && RedagWindow.tb_EMAIL.Text != "" && RedagWindow.tb_PHONE.Text != "" && RedagWindow.tp_Birt.SelectedDate != null)
            {
                h.SetClient(selectClient.Id, RedagWindow.tb_PIB.Text, RedagWindow.tb_EMAIL.Text, RedagWindow.tb_PHONE.Text, RedagWindow.tp_Birt.SelectedDate.Value.Date);
                redagWindow.Close();
            }
        }


        public void OpenAddClient()
        {
            addClientWindow = new AddClient() { DataContext = this };
            AddClientWindow.ShowDialog();
        }

        public void CencelAddCl()
        {
            addClientWindow.Close();
        }

        public void OkAddCl()
        {
            if (AddClientWindow.tb_PIB.Text != "" && AddClientWindow.tb_EMAIL.Text != "" && AddClientWindow.tb_PHONE.Text != "" && AddClientWindow.tp_Birt.SelectedDate != null)
            {
                h.AddClient(AddClientWindow.tb_PIB.Text, AddClientWindow.tb_EMAIL.Text, AddClientWindow.tb_PHONE.Text, AddClientWindow.tp_Birt.SelectedDate.Value.Date);
                C_LIST = h.GetClients();
                addClientWindow.Close();
            }
        }

        public void DeleteClient()
        {
            if (selectClient != null)
            {
                Client temp = new Client();
                temp = selectClient;
                h.DelClient(temp);
                C_LIST = h.GetClients();
            }
        }
    }
}
