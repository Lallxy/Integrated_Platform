using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.API.DAO.Interface
{
    public class ForResult
    {
        public ForResult(string message, bool status = false)
        {
            Message = message;
            Status = status;
        }

        public ForResult(bool status, object result)
        {
            Status = status;
            Result = result;
        }

        public string Message { get; set; }

        public bool Status { get; set; }

        public object Result { get; set; }
    }
}
