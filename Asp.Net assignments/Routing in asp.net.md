**Routing in asp.net:**

- Routing is **used to map requests to route handlers**.

-  Routes are configured when the application starts up, and can extract values from the URL that will be used for request processing.

-  Routing functionality is also responsible for generating links using the defined routes in ASP.NET apps.

- routing is a process of mapping the browser request to the controller action and return response back.

- Each MVC application has default routing for the default **HomeController**.

-  We can set custom routing for newly created controller.

- The **RouteConfig.cs** file is used to set routing for the application.

- ```
   public class RouteConfig
      {
          public static void RegisterRoutes(RouteCollection routes)
          {
              routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
    
              routes.MapRoute(
                  name: "Default",
                  url: "{controller}/{action}"
                  //OR
                  Url:"{controller}/{action}/{argument}"
                
              );
          }
      }
  ```

- If we look at the address bar, it contains only **localhost:52174**. There is no controller and action is specified because MVC router maps the controller from the **RouteConfig.cs.**

- ```
  http://localhost:52463/Home/signup
  ```




Default Route:

The default route table contains a single route (named Default). The Default route maps the first segment of a URL to a controller name, the second segment of a URL to a controller action, and the third segment to a parameter named **id**.

The Default route maps this URL to the following parameters:

- controller = Home

- action = Index

- id = UrlParameter.Optional

- ```
   public class RouteConfig
      {
          public static void RegisterRoutes(RouteCollection routes)
          {
              routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
  
              routes.MapRoute(
                  name: "Default",//Route Name
                  url: "{controller}/{action}/{id}",//Route Pattern
                  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
              );
          }
      }
  ```

  The Default route includes defaults for all three parameters. If you don't supply a controller, then the controller parameter defaults to the value **Home**. If you don't supply an action, the action parameter defaults to the value **Index**. Finally, if you don't supply an id, the id parameter defaults to an empty string.

  ```
   public class HomeController : Controller
      {
          public ViewResult Index()
          {
              return View();
          }
      }
  ```

  ```
  index.cshtml:
  @{
      ViewBag.Title = "Home Page";
  }
  
  <div class="jumbotron">
      <h1>ASP.NET</h1>
      <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
      <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
  </div>
  
  <div class="row">
      <div class="col-md-4">
          <h2>Getting started</h2>
          <p>
              ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
              enables a clean separation of concerns and gives you full control over markup
              for enjoyable, agile development.
          </p>
          <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
      </div>
      <div class="col-md-4">
          <h2>Get more libraries</h2>
          <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
          <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
      </div>
      <div class="col-md-4">
          <h2>Web Hosting</h2>
          <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
          <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
      </div>
  </div>
  ```

  

**Route Constraints:**

The Route Constraint in ASP.NET MVC Routing allows us to apply a regular expression to a URL segment to restrict whether the route will match the request. In simple words, we can say that the Route constraint is a way to put some validation around the defined route.

There is another overloaded version of the MapRoute extension method which takes constraints as a parameter. Using this parameter we can set a regular expression that will validate the incoming URL route parameters. In the below code, you can observe, we have passed **constraints :new { id = @”\d+” }** as the fourth parameter to the MapRoute extension method, and this regular expression will restrict the id parameter to be numeric only,

```
 public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { id = @"\d+" } //Restriction for id
                 constraints: new { id = @"[a-zA-Z]*$" } //restriction for string
            );
        }
    }
```



**View Data v/s View Bag** 

| View Data                                                    | View Bag                                                     |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| It is Key-Value Dictionary collection                        | It is a type object                                          |
| ViewData is a dictionary object and it is property of ControllerBase class | ViewBag is Dynamic property of ControllerBase class.         |
| ViewData is Faster than ViewBag                              | ViewBag is slower than ViewData                              |
| ViewData is introduced in MVC 1.0 and available in MVC 1.0 and above | ViewBag is introduced in MVC 3.0 and available in MVC 3.0 and above |
| It requires type casting for complex data types and checks for null values to avoid errors. | It doesn’t require type casting for complex data types.      |

