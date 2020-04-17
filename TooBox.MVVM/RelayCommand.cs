using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToolBox.MVVM
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _action;

        public RelayCommand(Action action)
        {
            if (action == null) throw new ArgumentException();
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }

    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<T> _action;

        public RelayCommand(Action<T> action)
        {
            if (action == null) throw new ArgumentException();
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _action.Invoke((T)parameter);
        }
    }
}
