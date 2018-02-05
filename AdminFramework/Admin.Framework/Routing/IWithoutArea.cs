
namespace Admin.Framework.Routing {

    public interface IWithoutArea<TAction> where TAction: IWithAction {

        /// <summary>
        /// Use this method if you dont use areas in you application
        /// </summary>
        /// <param name="controllerName">Name of controller</param>
        /// <returns></returns>
        TAction withoutAreaController(string controllerName);

    }
}
