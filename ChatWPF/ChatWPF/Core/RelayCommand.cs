using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatWPF.Core
{
    class RelayCommand : ICommand
    {
      

        private Action<object> execute;

        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value}
            remove { CommandManager.RequerySuggested -= value}
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
