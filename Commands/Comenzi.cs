using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dictionar.Commands
{
    public class Comenzi : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action DoWork;
        public Comenzi(Action work)
        {
            DoWork = work;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
