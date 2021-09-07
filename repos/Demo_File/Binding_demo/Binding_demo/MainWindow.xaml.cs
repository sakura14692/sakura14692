﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
namespace Binding_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertychanged
    {


        public MainWindow()
        {
            InitializeComponent();
            ButtonName = "ok làm được rồi";
            this.DataContext = this;
        }


        private string buttonName;
        public string ButtonName 
        {
            get { return buttonName; }
            set 
            { 
                buttonName = value; 
            
            }

        
        
        }

        private event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnpropertyChanged(string newName) 
        { 
        if (PropertyChanged!=null) 
            {
                PropertyChanged(this,new PropertyChangedEventArgs(newName));
            
            
            }
        
        
        }

        
    }
}
