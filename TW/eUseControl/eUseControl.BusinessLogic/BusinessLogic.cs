using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBl();
        }
    }
}
