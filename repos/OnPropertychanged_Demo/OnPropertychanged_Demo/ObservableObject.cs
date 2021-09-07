using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OnPropertychanged_Demo
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string Name) 
        {

            if (PropertyChanged != null) PropertyChanged(this,new PropertyChangedEventArgs(Name));
        
        }


    }
}
