using System.Web.Mvc;
using System.Web.Routing;

namespace POOI_T1_Cruz
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Empleado",
                    action = "RegistrarEmpleado",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
