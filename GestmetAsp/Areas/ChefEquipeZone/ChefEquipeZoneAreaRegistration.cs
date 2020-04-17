using System.Web.Mvc;

namespace GestmetAsp.Areas.ChefEquipeZone
{
    public class ChefEquipeZoneAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ChefEquipeZone";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ChefEquipeZone_default",
                "ChefEquipeZone/{controller}/{action}/{id}",
                new {action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}