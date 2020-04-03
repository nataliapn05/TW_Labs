using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.User
{
    public class ULoginData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string UIp { get; set; }
        public DateTime UserLTime { get; set; }
    }
}
