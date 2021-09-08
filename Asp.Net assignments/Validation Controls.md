## Validation Controls in ASP.NET

 

An important aspect of creating ASP.NET Web pages for user input is to be able to check that the information users enter is valid. ASP.NET provides a set of validation controls that provide an easy-to-use but powerful way to check for errors and, if necessary, display messages to the user.

 

There are six types of validation controls in ASP.NET

1. RequiredFieldValidation Control
2. CompareValidator Control
3. RangeValidator Control
4. RegularExpressionValidator Control
5. CustomValidator Control
6. ValidationSummary

The below table describes the controls and their work,

 

| Validation Control         | Description                                                  |
| -------------------------- | ------------------------------------------------------------ |
| RequiredFieldValidation    | Makes an input control a required field                      |
| CompareValidator           | Compares the value of one input control to the value of another input control or to a fixed value |
| RangeValidator             | Checks that the user enters a value that falls between two values |
| RegularExpressionValidator | Ensures that the value of an input control matches a specified pattern |
| CustomValidator            | Allows you to write a method to handle the validation of the value entered |
| ValidationSummary          | Displays a report of all validation errors occurred in a Web page |

## RequiredFieldValidation Control

 

- The RequiredFieldValidator control is simple validation control, which checks to see if the data is entered for the input control. 

- You can have a RequiredFieldValidator control for each form element on which you wish to enforce Mandatory Field rule.

  example:

  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvalidate" runat="server" ControlToValidate ="TextBox1" ErrorMessage="Please enter name" ></asp:RequiredFieldValidator><br />

  ## CompareValidator Control

   

  The CompareValidator control allows you to make comparison to compare data entered in an input control with a constant value or a value in a different control.

   

  It can most commonly be used when you need to confirm password entered by the user at the registration time. The data is always case sensitive.

  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"ErrorMessage="password required"  ControlToValidate="TextBox3"></asp:RequiredFieldValidator> 

  ## RangeValidator Control

   

  The RangeValidator Server Control is another validator control, which checks to see if a control value is within a valid range. 

  The attributes that are necessary to this control are: MaximumValue, MinimumValue, and Type.

  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              <asp:RangeValidator ID="rvclass" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your phone number" MaximumValue="12" MinimumValue="6" Type="Integer">
              </asp:RangeValidator>

  ## RegularExpressionValidator Control

   

  A regular expression is a powerful pattern matching language that can be used to identify simple and complex characters sequence that would otherwise require writing code to perform.

   

  Using RegularExpressionValidator server control, you can check a user's input based on a pattern that you define using a regular expression.

   

  It is used to validate complex expressions. These expressions can be phone number, email address, zip code and many more. Using Regular Expression Validator is very simple. Simply set the ValidationExpression property to any type of expression you want and it will validate it.

  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              <asp:RegularExpressionValidator ID="remail" runat="server"  ControlToValidate="TextBox3" ErrorMessage="Enter your email" 
                 ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> </asp:RegularExpressionValidator>

  ## ValidationSummary

  The ValidationSummary control does not perform any validation but shows a summary of all errors in the page. The summary displays the values of the ErrorMessage property of all validation controls that failed validation.

  The following two mutually inclusive properties list out the error message:

  - **ShowSummary** : shows the error messages in specified format.
  - **ShowMessageBox** : shows the error messages in a separate window.

  <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        DisplayMode ="BulletList" ShowSummary ="true" HeaderText="Errors:" />

  