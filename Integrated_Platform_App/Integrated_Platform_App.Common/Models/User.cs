using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.Common.Models
{
    public class User: BaseEntity
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string  UserName { get; set; }
        public bool IsDelete { get; set; }
    }
}
