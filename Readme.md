<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/WindowsApplication35/Data.cs) (VB: [Data.vb](./VB/WindowsApplication35/Data.vb))
* [Form1.cs](./CS/WindowsApplication35/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication35/Form1.vb))
<!-- default file list end -->
# How to bind a report at design time and provide data at runtime


<p>This example demonstrates how you can use the <strong>System.Windows.Forms.BindingSource</strong> component to bind a report at design time, and provide actual data at runtime.</p><p>In this example, the application contains a class (named <strong>Data</strong>), which is specified as the BindingSource component's DataSource type. Then, in the Form_Load event, the data source is populated, and assigned to the report's DataSource property.</p>

<br/>


