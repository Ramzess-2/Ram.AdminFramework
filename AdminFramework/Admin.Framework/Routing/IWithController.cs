namespace Admin.Framework.Routing {

    public interface IWithController {

        IWithAction withController(string controllerName);

        IWithController ignoreRoute(string url);

    }
}
