**WEB API**

- ASP.NET Web API is a framework for building HTTP services that can be accessed from any client including browsers and mobile devices.

- API is some kind of interface which has a set of functions that allow programmers to access specific features or data of an application, operating system or other services.

- Web API as the name suggests, is an API over the web which can be accessed using HTTP protocol.

- The ASP.NET Web API is an extensible framework for building HTTP based services that can be accessed in different applications on different platforms such as web, windows, mobile etc.

- | Web API Controller                                           | MVC Controller                                |
  | ------------------------------------------------------------ | --------------------------------------------- |
  | Derives from System.Web.Http.ApiController class             | Derives from System.Web.Mvc.Controller class. |
  | Method name must start with Http verbs otherwise apply http verbs attribute. | Must apply appropriate Http verbs attribute.  |
  | Specialized in returning data.                               | Specialized in rendering view.                |
  | Return data automatically formatted based on Accept-Type header attribute. Default to json or xml. | Returns ActionResult or any derived type.     |
  | Requires .NET 4.0 or above                                   | Requires .NET 3.5 or above                    |



[![img](https://www.tutorialsteacher.com/Content/images/webapi/webapi-overview.png)](https://www.tutorialsteacher.com/Content/images/webapi/webapi-overview.png)

















**HTML tag helpers**

- The `HtmlHelper` class renders HTML controls in the razor view.
-  It binds the model object to HTML controls to display the value of model properties into those controls and also assigns the value of the controls to the model properties while submitting a web form. 
- So always use the `HtmlHelper` class in razor view instead of writing HTML tags manually

| **Extension Method** | **Html Control**                                             |
| -------------------- | ------------------------------------------------------------ |
| Html.ActionLink()    | <a></a>                                                      |
| Html.TextBox()       | <input type="textbox">                                       |
| Html.TextArea()      | <input type="textarea">                                      |
| Html.CheckBox()      | <input type="checkbox">                                      |
| Html.RadioButton()   | <input type="radio">                                         |
| Html.DropDownList()  | <select> <option> </select>                                  |
| Html.ListBox()       | multi-select list box: <select>                              |
| Html.Hidden()        | <input type="hidden">                                        |
| Html.Password()      | <input type="password">                                      |
| Html.Display()       | HTML text: ""                                                |
| Html.Label()         | <label>                                                      |
| Html.Editor()        | Generates Html controls based on data type of specified model property e.g. textbox for string property, numeric field for int, double or other numeric type. |