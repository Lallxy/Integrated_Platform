
using Integrated_Platform_App.Common.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.ViewModels
{
    public  class MainViewModel:BindableBase
    {
        public MainViewModel()
        {
           
           
        }
        private ObservableCollection<MenuBar> menubars;

        public ObservableCollection<MenuBar> Menubars
        {
            get { return menubars; }
            set { menubars = value; }
        }
        public void CreatMenu()
        {
           
        }


    }
}
