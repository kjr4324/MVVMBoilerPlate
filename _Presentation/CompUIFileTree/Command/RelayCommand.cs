using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CompUIFileTree.Command
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            bool bCanExecute = false;
            if (parameter != null)
            {
                bCanExecute = _canExecute(parameter);
            }

            return bCanExecute;
        }

        public void Execute(object? parameter)
        {
            if (parameter != null)
            {
                _execute(parameter);
            }
        }
    }
}
