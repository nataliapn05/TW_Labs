using eUseControl.Web.Extension;
using System.Web.Mvc;
using static eUseControl.Web.Controllers.AdminModAtribute;

namespace eUseControl.Web.Controllers
{
    public class AdminController : Controller
    {
        [AdminMod]
        public ActionResult Index()
        {
           // SessionStatus();
           // if((string)System.Web.HttpContext.CurrentSession["LoginStatus"]=="login")
            //{
              //  var user = System.Web.HttpContext.Current.GetMySessionObject();
                //return View(user);
            //}
                
                return View();
        }
    }
}