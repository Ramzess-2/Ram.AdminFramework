# Ram.AdminFramework
Administration framework for asp.net mvc

> The basic idea of this library is crating administration dashboard without area named like ##Admin 

* For now is realized only beatiful routing which you can map areas without AreaRegistration class needed*

> Example 1: basic HomeController in area Home


 ```CSharp
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
```

> And AreaRegistration class

```CSharp
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
```

> Now, you can just do this without AreaRegistrationContext class needed

```CSharp

RouteManager.GetProvider()
    .WithArea("Home")
        .WithController("Home")
            .withAction("", "index", "index")
            .withAction("about", "about")
            .withAction("contacts", "contacts");

```
> Or, if you want use routes with same name as controller actions you can use:

```CSharp
RouteManager.GetProvider()
    .WithArea("Home")
    .WithController("Home")
        .withActions("index", "about", "contacts");

```
> It's will be mapped to /index, /about, /contacts 