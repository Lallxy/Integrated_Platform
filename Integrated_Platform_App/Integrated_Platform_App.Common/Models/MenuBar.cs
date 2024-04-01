using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.Common.Models
{
    public  class MenuBar:BaseEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string ForPage { get; set; }
        public string Color { get; set; }

    }
}
