using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TA.BLL.Comands
{
    public class ButtonOKredag: ICommand
    {
        public Clients Clients { get; set; }

        public ButtonOKredag(Clients clients)
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
                return true;
        }

        public void Execute(object parameter)
        {
            Clients.OkRadag();
        }
    }
}
