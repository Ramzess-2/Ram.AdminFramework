using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Admin.Framework.Tests.Routing.Controllers
{
    public class HomeAreaRegistration: AreaRegistration {
        public override void RegisterArea(AreaRegistrationContext context) {

            context.Routes.MapRoute("index", "", new {
                controller = "Home", 
                action = "index"
            });

            context.Routes.MapRoute("about", "about", new {
                controller = "Home", 
                action = "about"
            });

            context.Routes.MapRoute("contacts", "contacts", new {
                controller = "Home", 
                action = "contacts"
            });

        }

        public override string AreaName { get; } = "Home";
    }
}
