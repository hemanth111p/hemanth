## User Controls

User controls behaves like miniature ASP.NET pages or web forms, which could be used by many other pages. These are derived from the System.Web.UI.UserControl class. These controls have the following characteristics:

- They have an .ascx extension.

- They may not contain any <html>, <body>, or <form> tags.

- They have a Control directive instead of a Page directive.

  - footer.ascx.

    ```
    <%@ Control Language="C#" AutoEventWireup="true" CodeBehind="footer.ascx.cs" 
       Inherits="customcontroldemo.footer" %>
       <table>
       <tr>
          <td align="center"> Copyright ©2010 TutorialPoints Ltd.</td>
       </tr>
    
       <tr>
          <td align="center"> Location: Hyderabad, A.P </td>
       </tr>
    </table>
    ```

    

    default.aspx:

    ```
    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="customcontroldemo._Default" %>
       
    <%@ Register Src="~/footer.ascx" TagName="footer" TagPrefix="Tfooter" %>
    
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    
    <html xmlns="http://www.w3.org/1999/xhtml" >
    
       <head runat="server">
          <title>
             Untitled Page
          </title>
       </head>
       
       <body>
       
          <form id="form1" runat="server">
             <div>
             
                <asp:Label ID="Label1" runat="server" Text="Welcome to ASP.Net Tutorials "></asp:Label>
                <br />  <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click"  Text="Copyright Info" />
                
             </div>
             <Tfooter:footer ID="footer1" runat="server" />
          </form>
          
       </body>
    </html>
    ```

​           

