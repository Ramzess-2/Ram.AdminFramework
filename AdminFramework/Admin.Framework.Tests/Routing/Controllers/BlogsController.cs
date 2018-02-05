using System.Web.Mvc;

namespace Admin.Framework.Tests.Routing.Controllers
{
    public class BlogsController: Controller {


        public ActionResult GetPost(string name) {
            return Content($"the post with postname: {name} was not found");
        }


    }
}
