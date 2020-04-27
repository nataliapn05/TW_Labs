using eUseControl.BusinessLogic.Interfaces;
using System;
using System.Linq;
using System.Web.Mvc;
using eUseControl.Web.Extension;

namespace eUseControl.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ISession _session;

        public BaseController()
        {
            var bl = new BusinessLogic.BussinesLogic();
            _session = bl.GetSessionBl();
        }

        

    }
}
