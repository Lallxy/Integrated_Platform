using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.Common.Models
{
    public  class BaseEntity: INotifyPropertyChanged
    {
        public int Id { get; set; }

        public DateTime CreatTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 实现通知更新
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
