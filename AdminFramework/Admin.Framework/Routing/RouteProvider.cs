
namespace Admin.Framework.Routing {

    public class RouteProvider: IRouteProvider<IWithController, IWithAction>, IWithoutArea<IWithAction> {

        public RouteProvider() {

        }


        public IWithController withArea(string area, string nameSpace) {
            return new WithControllerAction(area, nameSpace);
        }

        public IWithController withArea(string controllerName, string areaName, string nameSpace = "") {
            return new WithControllerAction(areaName, nameSpace) {  };
        }

        /// <summary>
        /// Use this method if you dont use areas in you application
        /// </summary>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        public IWithAction withoutAreaController(string controllerName) {
            return new WithControllerAction()
                .withController(controllerName);
        }

    }
}
