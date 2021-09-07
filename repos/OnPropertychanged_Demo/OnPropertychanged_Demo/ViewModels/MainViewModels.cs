using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace OnPropertychanged_Demo.ViewModels
{
  public  class MainViewModels
    {

        public PersonViewModel Person { get; private set; }
        public BackgroundViewModel Background { get; private set; }


        public MainViewModels() 
        {
            Person = new PersonViewModel();
            Background = new BackgroundViewModel();
        
        
        }

        public void SetBackground(Brush brushColor) 
        {

            Background.Color = brushColor;
        
        }

    }
}
