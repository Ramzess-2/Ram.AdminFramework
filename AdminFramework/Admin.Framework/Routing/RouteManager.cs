namespace Admin.Framework.Routing {

    public class RouteManager {

        public static IDefaultRouteProvider GetProvider() {
            return new DefaultRouteProvider();
        }


    }
}
