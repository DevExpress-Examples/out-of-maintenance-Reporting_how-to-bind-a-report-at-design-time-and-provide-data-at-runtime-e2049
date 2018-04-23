# How to bind a report at design time and provide data at runtime


<p>This example demonstrates how you can use the <strong>System.Windows.Forms.BindingSource</strong> component to bind a report at design time, and provide actual data at runtime.</p><p>In this example, the application contains a class (named <strong>Data</strong>), which is specified as the BindingSource component's DataSource type. Then, in the Form_Load event, the data source is populated, and assigned to the report's DataSource property.</p>

<br/>


