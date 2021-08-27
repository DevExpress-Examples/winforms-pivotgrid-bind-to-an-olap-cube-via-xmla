<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581604/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3708)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_XMLA/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_XMLA/Form1.vb))
<!-- default file list end -->
# How to: Bind to an OLAP Cube via XMLA


<p>The following example demonstrates how to bind a <strong>PivotGridControl</strong> to an OLAP cube via the XMLA data access standard.</p>


<h3>Description</h3>

<p>In this example, a PivotGridXmlaDataSource object is created and assigned to the PivotGridControl.DataSource property. OLAP connection parameters are specified in a connection string passed to the PivotGridXmlaDataSource.ConnectionString property. The following parameters are provided:<br />
<strong>Data Source</strong> - a path to a data pump. <br />
<strong>Initial Catalog</strong> - a data catalog that contains cubes. <br />
<strong>Cube Name</strong> - the name of the cube that provides OLAP data. </p>

<br/>


