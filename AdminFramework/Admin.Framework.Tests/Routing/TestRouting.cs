using Admin.Framework.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using System.Web.Routing;
using Admin.Framework.Tests.Routing.Controllers;

namespace Admin.Framework.Tests.Routing
{
    [TestClass]
    public class TestRouting {

        private IDefaultRouteProvider _provider;

        public TestRouting() {
            _provider = RouteManager.GetProvider();
        }

        [TestMethod]
        public void TestDefaultRouting() {

            RouteTable.Routes.Clear();

            _provider
                .withoutAreaController("Home")
                .withAction("", "index", "index")
                .withAction("about", "about")
                .withAction("contacts", "contacts");

            "~/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());


            RouteTable.Routes.Clear();

            _provider
                .withoutAreaController("Home")
                .withActions("index", "about", "contacts");


            "~/index".Route().ShouldMapTo<HomeController>(x => x.Index());
            "~/about".Route().ShouldMapTo<HomeController>(x => x.About());
            "~/contacts".Route().ShouldMapTo<HomeController>(x => x.Contacts());

        }

        [TestMethod]
        public void TestRouteWithConstraints() {

            RouteTable.Routes.Clear();

            _provider
                .withoutAreaController("Blogs")
                .withAction("p/{name}", "GetPost");

            "~/p/the-biggest-post"
                .Route()
                .ShouldMapTo<BlogsController>(x => x.GetPost("the-biggest-post"));


            RouteTable.Routes.Clear();

            _provider
                .withoutAreaController("Blogs")
                .withAction("p/{name}", "GetPost", new { name = "[\\w|\\-]+" }); //same route with constraint

            "~/p/112233-the-biggest-post"
                .Route()
                .ShouldMapTo<BlogsController>(x => x.GetPost("112233-the-biggest-post"));

        }




    }
}
