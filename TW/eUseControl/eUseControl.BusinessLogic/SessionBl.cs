using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using System.Web;

namespace eUseControl.BusinessLogic.LogicBL
{
    class SessionBl : UserAPI, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

       
    }
}
