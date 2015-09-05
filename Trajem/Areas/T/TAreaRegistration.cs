using System.Web.Mvc;

namespace Trajem.Areas.T
{
    public class TAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "T";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "T_default",
                "T/{controller}/{action}/{id}",
                new { controller = "Home" ,action = "Index", id = UrlParameter.Optional },
                    namespaces: new[] { "Trajem.Areas.T.Controllers" }
            );
        }
    }
}