using Integrated_Platform_App.Common.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.ViewModels
{
    class HomeViewModel:BindableBase
    {
        public HomeViewModel()
        {
            
        }
        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value; }
        }
        public void InitTaskBars()
        {
            TaskBars.Add(new TaskBar { Icon="", Content="",Id=1, Color="", Title="", Target="" });
            TaskBars.Add(new TaskBar { Icon="", Content="",Id=2, Color="", Title="", Target="" });
            TaskBars.Add(new TaskBar { Icon="", Content="",Id=3, Color="", Title="", Target="" });
            TaskBars.Add(new TaskBar { Icon="", Content="",Id=4, Color="", Title="", Target="" });
        }

    }
}
