**Action Result**

Action Result is actually a data type. When it is used with action method, it is called return type. As you know, an action is referred to as a method of the controller, the Action Result is the result of action when it executes

|                        |                                          |                        |
| ---------------------- | ---------------------------------------- | ---------------------- |
| Result Class           | Description                              | Base Controller Method |
| ViewResult             | Represents HTML and markup.              | View()                 |
| EmptyResult            | Represents No response.                  |                        |
| ContentResult          | Represents string literal.               | Content()              |
| FileResult             | Represents the content of a file.        | File()                 |
| JavaScriptResult       | Represents a JavaScript script.          | JavaScript()           |
| RedirectResult         | Represents a redirection to a new URL.   | Redirect()             |
| RedirectToRouteResult  | Represents redirection to another route. | RedirectToRoute()      |
| PartialViewResult      | Represents the partial view result.      | PartialView()          |
| HttpUnauthorizedResult | Represents HTTP 404 response.            |                        |

```
public ViewResult Index()
        {
            return View();
        }

        public PartialViewResult Partial()
        {
            

            return PartialView("SecondView");
        }
        public ContentResult ContentRst()
        {
            return Content("<h3>Asp.Net </h3>");
        }
        public EmptyResult EmptyRst()
        {
            return new EmptyResult();
        }
        public FileResult FileMsg()
        {
            return File("~/indicator path.txt", "text/plain");
        }
        public JavaScriptResult javaScript()
        {
            return JavaScript("Welcome to javascript result");
        }
        public RedirectResult Redirect()
        {
            return Redirect("https://www.google.com/");
        }
        public RedirectToRouteResult RedirectRoute()
        {
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
        public HttpStatusCodeResult HttpStatus()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }
        public HttpNotFoundResult HttpFound()
        {
            return HttpNotFound("Sorry! You don't have access.");
        }
```

