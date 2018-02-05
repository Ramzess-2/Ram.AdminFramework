namespace Admin.Framework.Routing {


    /// <summary>
    /// The basic route provider
    /// </summary>
    /// <typeparam name="TController">Implemented by IWithController interface</typeparam>
    /// <typeparam name="TAction">Implemented by IWithAction interface</typeparam>
    public interface IRouteProvider<TController, TAction> where TController: IWithController where TAction: IWithAction {

        /// <summary>
        /// With Basic Area
        /// </summary>
        /// <param name="area">area name</param>
        /// <param name="nameSpace">optional namespace (you can use typeof(YourController).Namespace) </param>
        /// <returns>Controller</returns>
        TController withArea(string areaName, string nameSpace = "");

        /// <summary>
        /// With Basic Area and Controller name
        /// </summary>
        /// <param name="area">area name</param>
        /// <param name="nameSpace">optional namespace (you can use typeof(YourController).Namespace) </param>
        /// <returns>Controller</returns>
        TController withArea(string controllerName, string area, string nameSpace = "");
        
    }

    public interface IRouteProvider : IRouteProvider<IWithController, IWithAction> {
        
    }

}