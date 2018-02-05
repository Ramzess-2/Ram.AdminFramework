

namespace Admin.Framework.Routing {

    public class DefaultRouteProvider: IDefaultRouteProvider {

        public DefaultRouteProvider() {

        }


        public IWithController withArea(string areaName, string nameSpace) {
            return new WithControllerAction(areaName, nameSpace);
        }

        public IWithController withArea(string controllerName, string area, string nameSpace = ""){
            return new WithControllerAction(area, nameSpace) { };
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
