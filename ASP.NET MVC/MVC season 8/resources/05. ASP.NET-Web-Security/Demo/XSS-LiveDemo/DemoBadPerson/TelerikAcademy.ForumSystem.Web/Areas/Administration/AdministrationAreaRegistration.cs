using System.Web.Mvc;

//imeto na faila besheAdministrationAreaRegistration ama go sykratih da moa go kacha v github che mn dylyg pytq v Windows

namespace TelerikAcademy.ForumSystem.Web.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administration_default",
                "Administration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}