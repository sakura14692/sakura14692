using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Quan_ly_kho.ViewModels
{
    public class mainViewModels
    {
        
        public mainViewModels() 
        {
            if (!isLoaded)
            {
                isLoaded = true;
               
                LoginForm login = new LoginForm();
                login.ShowDialog();
                
                
                

            }

            
        
        }

        public bool isLoaded = false;

        

    }
}
