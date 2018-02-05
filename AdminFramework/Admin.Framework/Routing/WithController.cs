using System.Web.Routing;

namespace Admin.Framework.Routing {


    public class WithControllerAction: IWithController {

        private readonly string _area;
        private readonly string _nameSpace;

        protected string _controller;

        /// <summary>
        /// Default constructor
        /// </summary>
        public WithControllerAction() {
            
        }

        /// <summary>
        /// Constructor with default areaName and namespace
        /// </summary>
        public WithControllerAction(string areaName, string nameSpace) {
            _area = areaName;
            _nameSpace = nameSpace;
        }

        /// <summary>
        ///  Initializes IWithAction implements class with default controller name
        /// </summary>
        public IWithAction withController(string controllerName) {
            return new WithAction(_area, _nameSpace, controllerName);
        }


        /// <summary>
        /// ignores url
        /// </summary>
        /// <param name="url">url path you want to ignore</param>
        /// <returns></returns>
        public IWithController ignoreRoute(string url) {
            RouteTable.Routes.Ignore(url);
                return new WithControllerAction();
        }
    }
}
