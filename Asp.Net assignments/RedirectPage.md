- Response.Redirect
- Server.Transfer
- Server.Execute
- Cross page posting

# Response.Redirect:
- It redirects a client to a new URL. Specifies the new URL and whether execution of the current page should terminate
- It also maintains the history of an URL from where it has got navigated to, meaning we can return using the back button.
- It redirects the user to a web page hosted on the same server or a different server.
-Example:

protected void Button1_Click(object sender, EventArgs e) { Response.Redirect("HomePage.aspx"); }

# Server.Transfer:
- It is a navigation technique in an ASP.NET web application to move from one web form to another on the same server without changing the URL in an address bar.
- It preserves server resources and avoids the unnecessary round trips to the server.
- It cannot maintain the history.
- There is no URL changes in the address bar in this case so the back button cannot be used.
-example:

protected void Button1_Click(object sender, EventArgs e) { Server.Transfer("registerpage.aspx"); }

# Server.Execute
- When using the server.Execute method for navigation it helps to retain the execution control from the source web form.
- it retains the control from the source web page and returns to the original page after execution of the target page.
- Example:
- 
protected void Button1_Click(object sender, EventArgs e) { Server.Execute("registerpage.aspx"); }

# Cross page posting
- The Cross Page posting technique allows a web form to post on another web form on button click.
- The PostbackUrl property of the button is set to the page where you want to do cross-page posting.
- Example:
 display.aspx
 
 <form id="form1" runat="server">
  
 <asp:Label Text="text" name="lblValue" ID="lblValue" runat="server" /> 
 
 </div>
 
 </form>
    
    display.aspx.cs:
    
     protected void Page_Load(object sender, EventArgs e)
    {
        if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
        {
            TextBox txtName = (TextBox)PreviousPage.FindControl("txtName");
            lblValue.Text = "Welcome " + txtName.Text;
        }

    }
    
    default.aspx:
    
    <form id="form1" runat="server">
    
            <asp:TextBox ID="txtName" name="data" runat="server" />  
            
   <asp:Button Text="ClickPostBack" runat="server" PostBackUrl="~/Display.aspx" />
   
       
    </form>
