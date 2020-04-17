using System.Web.Mvc;

namespace GestmetAsp.Areas.UtilisateurZone
{
    public class UtilisateurZoneAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UtilisateurZone";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UtilisateurZone_default",
                "UtilisateurZone/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}