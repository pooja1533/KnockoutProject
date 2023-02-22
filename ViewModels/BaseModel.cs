using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public partial class BaseModel
    {
        public bool IsDuplicate { get; set; }
        public bool IsError { get; set; }

        public string Message { get; set; }

        public string ErrorMessage { get; set; }

        public string RedirectUrl { get; set; }

        public byte Status { get; set; }

        public BaseModel()
        {
            IsError = true;
        }
    }
}
