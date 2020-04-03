using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.LogicBl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBl();
        }
    }
}
