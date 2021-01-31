using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhilarDataApp.Models
{
    public class ConcertCommand : ICommand
    {
        public ConcertCommand(Action<object> execute)
        {
            Action = execute;
        }

        public Action<object> Action { get; } = null;
        public void Execute(object parameter)
        {
            if (Action != null)
                Action(parameter);
        }

        public bool CanExecute(object paramter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
