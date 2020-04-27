using eUseControl.BusinessLogic.Interfaces;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class AdminModAtribute
    {
         public class AdminModAttribute : ActionFilterAttribute     {         
            private readonly ISession _sessionBL; 
 
        public AdminModAttribute()         {            
               // var businessLogic = new BusinessLogic.SessionBl();            
                //_sessionBL = businessLogic.GetSessionBL();         
            } 
 
        public override void OnActionExecuting(ActionExecutingContext filterContext)         
            {            
                //var apiCookie = HttpContext.Current.Request.Cookies["LOGIN-KEY"];            
               // if (apiCookie != null){                
                    //var profile = _sessionBL.GetUserByCookie(apiCookie.Value);                
                   // if (profile != null && profile.Level == URole.Admin)                 {                     
                       // HttpContext.Current.SetMySessionObject(profile);                 }                 
                   // else                 {                     filterContext.Result = new RedirectToRouteResult(new                     
                       // RouteValueDictionary(new { controller = "Home", action = "Index" }));                
                    //}             
                }         
            }     
        }
    }
