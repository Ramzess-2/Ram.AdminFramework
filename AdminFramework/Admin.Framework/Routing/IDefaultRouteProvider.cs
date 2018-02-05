

namespace Admin.Framework.Routing {

    public interface IDefaultRouteProvider: IRouteProvider<IWithController, IWithAction>, IWithoutArea<IWithAction> {



    }
}
