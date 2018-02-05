

using System.Web.Mvc;

namespace Admin.Framework.Controllers
{
    [Authorize(Roles = "Admin, admin, superadmin")]
    public class AdminController: Controller {

    }
}
