![ASP.NET Page Life Cycle](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET%20Page%20Life%20Cycle.png)

## PreInit

1. Check the IsPostBack property to determine whether this is the first time the page is being processed.

2. Create or re-create dynamic controls.

3. Set a master page dynamically.

4. Set the Theme property dynamically.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET1.jpg)

## Init

1. This event fires after each control has been initialized.

2. Each control's UniqueID is set and any skin settings have been applied.

3. Use this event to read or initialize control properties.

4. The "Init" event is fired first for the bottom-most control in the hierarchy, and then fired up the hierarchy until it is fired for the page itself.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET2.jpg)

## InitComplete

1. Until now the viewstate values are not yet loaded, hence you can use this event to make changes to the view state that you want to ensure are persisted after the next postback.

2. Raised by the Page object.

3. Use this event for processing tasks that require all initialization to be complete.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET3.jpg)

## OnPreLoad

1. Raised after the page loads view state for itself and all controls, and after it processes postback data that is included with the Request instance.

2. Before the Page instance raises this event, it loads view state for itself and all controls, and then processes any postback data included with the Request instance.

3. Loads ViewState: ViewState data are loaded to controls.

4. Loads Postback data: Postback data are now handed to the page controls.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET4.jpg)

## Load

1. The Page object calls the OnLoad method on the Page object, and then recursively does the same for each child control until the page and all controls are loaded. The Load event of individual controls occurs after the Load event of the page.

2. This is the first place in the page lifecycle that all values are restored.

3. Most code checks the value of IsPostBack to avoid unnecessarily resetting state.

4. You may also call Validate and check the value of IsValid in this method.

5. You can also create dynamic controls in this method.

6. Use the OnLoad event method to set properties in controls and establish database connections.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET5.jpg)

## Control PostBack Event(s)

1. ASP.NET now calls any events on the page or its controls that caused the PostBack to occur.

2. Use these events to handle specific control events, such as a Button control's Click event or a TextBox control's TextChanged event.

3. In a postback request, if the page contains validator controls, check the IsValid property of the Page and of individual validation controls before performing any processing.

4. This is just an example of a control event. Here it is the button click event that caused the postback.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET6.jpg)

## LoadComplete

1. Raised at the end of the event-handling stage.

2. Use this event for tasks that require that all other controls on the page be loaded.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET7.jpg)

## OnPreRender

1. Raised after the Page object has created all controls that are required in order to render the page, including child controls of composite controls.

2. The Page object raises the PreRender event on the Page object, and then recursively does the same for each child control. The PreRender event of individual controls occurs after the PreRender event of the page.

3. The PreRender event of individual controls occurs after the PreRender event of the page.

4. Allows final changes to the page or its control.

5. This event takes place before saving ViewState, so any changes made here are saved.

6. For example: After this event, you cannot change any property of a button or change any viewstate value.

7. Each data bound control whose DataSourceID property is set calls its DataBind method.

8. Use the event to make final changes to the contents of the page or its controls.

   ![ASP.NET7.5.jpg](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET7.5.jpg)

## OnSaveStateComplete

1. Raised after view state and control state have been saved for the page and for all controls.

2. Before this event occurs, ViewState has been saved for the page and for all controls.

3. Any changes to the page or controls at this point will be ignored.

4. Use this event perform tasks that require the view state to be saved, but that do not make any changes to controls.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET8.jpg)

## Render Method

1. This is a method of the page object and its controls (and not an event).
2. The Render method generates the client-side HTML, Dynamic Hypertext Markup Language (DHTML), and script that are necessary to properly display a control at the browser.

## UnLoad

1. This event is used for cleanup code.

2. At this point, all processing has occurred and it is safe to dispose of any remaining objects, including the Page object.

3. Cleanup can be performed on:

   - Instances of classes, in other words objects

   - Closing opened files

   - Closing database connections.

4. This event occurs for each control and then for the page.

5. During the unload stage, the page and its controls have been rendered, so you cannot make further changes to the response stream.

6. If you attempt to call a method such as the Response.Write method then the page will throw an exception.

   ![Page Life Cycle In ASP.NET](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8911c4/page-life-cycle-with-examples-in-Asp-Net/Images/ASP.NET9.jpg)