<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633735/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3209)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/QueryResourceColorSchema/Form1.cs) (VB: [Form1.vb](./VB/QueryResourceColorSchema/Form1.vb))
<!-- default file list end -->
# How to associate a specific color schema with a particular resource


<p>This example demonstrates how to link a specific color schema to each visible resource and specify a custom color schema for the selected resource if more than one resources are displayed in the scheduler view.</p>


<h3>Description</h3>

<p>To associate each resource from the <strong>ResourceStorage</strong> storage with a specific color schema from the <strong>SchedulerColorSchemaCollection</strong> collection, do the following:<br />
1. Prepare a collection of color schemas to paint resources by getting currently used resource color schemas (determined by the currently set skin). To do this, call the <strong>SchedulerControl.GetResourceColorSchemasCopy</strong> method.<br />
2. Handle the <strong>SchedulerControl.QueryResourceColorSchema</strong> event to specify a particular color schema for each visible resource. Use the <strong>QueryResourceColorSchemaEventArgs.Resource</strong> property to get access to the resource for which the color schema should be specified and use the <strong>QueryResourceColorSchemaEventArgs.ResourceColorSchema</strong> property to specify the resource color schema.</p>

<br/>


