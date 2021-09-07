using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace test_ICommand
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> excuteMethod;
       public Func<object, bool> canexecuteMethod;

        public Command(Action<object> excuteMethod, Func<object, bool> canexecuteMethod) 
        {
            this.excuteMethod = excuteMethod;
            this.canexecuteMethod = canexecuteMethod;

        
        
        }



       

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            excuteMethod(parameter);
        }








    }



}
