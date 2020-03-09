using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TA.DAL;

namespace TA.BLL.Comands
{
    public class ButtonDelClient: ICommand
    {
        public Clients Clients { get; set; }

        public ButtonDelClient(Clients clients)
        {
            Clients = clients;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if ((parameter as Client) != null)
                return true;
            return false;
        }

        public void Execute(object parameter)
        {
            Clients.DeleteClient();
        }
    }
}
