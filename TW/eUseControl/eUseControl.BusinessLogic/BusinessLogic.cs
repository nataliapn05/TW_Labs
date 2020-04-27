using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.BusinessLogic.LogicBL;

namespace eUseControl.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBl();
        }
        public IRegister GetRegisterBL()
        {
            return new RegisterBL();
        }

    }
}
