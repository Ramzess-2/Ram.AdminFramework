using System.Web.Mvc;

namespace Admin.Framework.Tests.Routing.Controllers {

    public class HomeController: Controller {

        public ActionResult Index() {
            return Content("this is home page... ");
        }

        public ActionResult About() {
            return Content("this is about page... ");
        }

        public ActionResult Contacts() {
            return Content("this is contacts page... ");
        }

    }
}
