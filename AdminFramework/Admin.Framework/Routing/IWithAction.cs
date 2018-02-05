using System.Web.Routing;

namespace Admin.Framework.Routing {

    /// <summary>
    /// Interface defines routes 
    /// </summary>
    public interface IWithAction {
        
        IWithAction withController(string controller);

        /// <summary>
        /// Names of area, namespace, controller
        /// </summary>
        /// <param name="areaName">name of area</param>
        /// <param name="nameSpace">name of namespace</param>
        /// <param name="controllerName">name of controller name</param>
        IWithAction withAction(string url, string actionName, IRouteConstraint constraint);

        IWithAction withAction(string routeName, string url, string actionName, IRouteConstraint constraint);

        IWithAction withAction(string url, string actionName, object constraint);

        IWithAction withAction(string routeName, string url, string actionName, object constraint);

        IWithAction withAction(string url, string actionName, bool hasOptionalId = false);

        IWithAction withAction(string routeName, string url, string actionName, bool hasOptionalId = false);

        IWithAction withAction(string url, string actionName, object constraint, bool hasOptionalId = false);

        IWithAction withAction(string routeName, string url, string actionName, object constraint, bool hasOptionalId = false);

        IWithAction withActions(params string[] names);

    }
}
