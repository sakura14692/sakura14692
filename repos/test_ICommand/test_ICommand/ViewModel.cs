using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace test_ICommand
{
   public class ViewModel
    {
        public ICommand MyCommand { get; set; }
        public ICommand MyCommand2 { get; set; }

        public ViewModel()
        {

            MyCommand = new Command(ExcuteMethod,canExecuteMethod);
            MyCommand2 = new Command(ExcuteMethod2, canExecuteMethod);

        } 


        private bool canExecuteMethod(object paramater) 
        {
            return true;
        
        }

        public void ExcuteMethod(object paramter) 
        {
            
            MessageBox.Show("Đã thành công","Thông báo",MessageBoxButton.OK,MessageBoxImage.Information);
            Application.Current.Shutdown();
        }

        public void ExcuteMethod2(object paramter)
        {

            MessageBox.Show("Đã thành công 2!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
