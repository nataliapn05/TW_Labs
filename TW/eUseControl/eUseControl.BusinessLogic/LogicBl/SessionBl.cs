﻿using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.LogicBl
{
    class SessionBl: UserAPI, ISession
    {
        public bool GetUserSessionStatus()
        {
            return UserSessionStatus();
        }
    }
}
