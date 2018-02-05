using System.Web.Routing;

namespace Admin.Framework.Routing {
    
    public class WithAction: IWithAction {

        private readonly string _prefix;

        private readonly string _area;
        private readonly string _nameSpace;
        private readonly string _controllerName;

        /// <summary>
        /// Names of area, namespace, controller
        /// </summary>
        /// <param name="areaName">name of area</param>
        /// <param name="nameSpace">name of namespace</param>
        /// <param name="controllerName">name of controller name</param>
        public WithAction(string areaName, string nameSpace, string controllerName) {
            _area = areaName;
            _nameSpace = nameSpace;
            _controllerName = controllerName;
        }

        /// <summary>
        /// Names of prefix, area, namespace, controller
        /// </summary>
        /// <param name="prefix">default prefix from url ({prefix}/url)</param>
        /// <param name="areaName">name of area</param>
        /// <param name="nameSpace">name of namespace</param>
        /// <param name="controllerName">name of controller name</param>
        public WithAction(string prefix, string areaName, string nameSpace, string controllerName):this(areaName, nameSpace, controllerName) {
            _prefix = prefix;
        }
        
        /// <summary>
        /// This methods changes/defines controller name
        /// </summary>
        /// <param name="controllerName"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withController(string controllerName) {
            return new WithControllerAction(_area, _nameSpace)
                .withController(controllerName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string url, string actionName, IRouteConstraint constraint) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(url, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string routeName, string url, string actionName, IRouteConstraint constraint) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(routeName, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string url, string actionName, object constraint) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(url, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string routeName, string url, string actionName, object constraint) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(routeName, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="hasOptionalId"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string url, string actionName, bool hasOptionalId = false) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(url, url, actionName, _controllerName, _nameSpace, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="hasOptionalId"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string routeName, string url, string actionName, bool hasOptionalId = false) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(routeName, url, actionName, _controllerName, _nameSpace, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <param name="hasOptionalId"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string url, string actionName, object constraint, bool hasOptionalId = false) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(url, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routeName"></param>
        /// <param name="url"></param>
        /// <param name="actionName"></param>
        /// <param name="constraint"></param>
        /// <param name="hasOptionalId"></param>
        /// <returns>IWithAction</returns>
        public IWithAction withAction(string routeName, string url, string actionName, object constraint, bool hasOptionalId = false) {
            RouteBuilder.LinkRoute(RouteBuilder.Build(routeName, url, actionName, _controllerName, _nameSpace, constraint, false), _area, _nameSpace);
                return this;
        }


        /// <summary>
        /// Automatically maps names to routes and controller actions
        /// for example:
        /// public class HomeController: Controller {
        ///     
        ///     public ActionResult About() { return View(); }
        ///     public ActionResult Contacts() { return View(); }
        /// 
        /// }
        /// 
        /// and you need something like: ~/about, ~/contacts (same, like action names)
        /// 
        /// </summary>
        /// <param name="names">Name which you want to map</param>
        /// <returns>IWithAction interface</returns>
        public IWithAction withActions(params string[] names) {

            if (names.Length > 0) {

                foreach (var name in names) {
                    this.withAction(name, name, name, true);
                }

            }


            return this;
        }
    }
}
