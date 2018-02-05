using System.Web.Mvc;
using System.Web.Routing;

namespace Admin.Framework.Routing {

    internal class RouteBuilder {

        public static Route LinkRoute(Route route, string areaName, string nameSpace) {

            route.DataTokens[RouteConstants.NAMESPACE_FALLBACK] = !string.IsNullOrEmpty(nameSpace);

            if (!string.IsNullOrEmpty(areaName))
                route.DataTokens[RouteConstants.DATA_TOKENS_AREA] = areaName;
            
            return route;
        }
        

        public static Route Build(string routeName, string url, string actionName, string controllerName, string nameSpaces, bool useOptionalId = false) {
            if (nameSpaces == null)

                return RouteTable.Routes.MapRoute(routeName, url, new {
                    controller = controllerName,
                    action = actionName
                });
            
            return RouteTable.Routes.MapRoute(routeName, url, new {
                controller = controllerName,
                action = actionName
            }, new string[] { nameSpaces });

        }

        public static Route Build(string routeName, string url, string actionName, string controllerName, string nameSpaces, object constraint, bool useOptionalId = false) {

            if (nameSpaces == null)

                return RouteTable.Routes.MapRoute(routeName, url, new {
                    controller = controllerName,
                    action = actionName
                }, constraint);


            return RouteTable.Routes.MapRoute(routeName, url, new {
                controller = controllerName,
                action = actionName
            }, constraint, new string[] { nameSpaces });

        }

    }
}
