using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.Core;
using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class RegisterBL : UserAPI, IRegister
    {
        public URegisterResp UserRegister(URegisterData data)
        {
            return UserRegisterAction(data);
        }
    }
}
