<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581604/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3708)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - Bind to an OLAP Cube with the XMLA Data Provider

This example demonstrates how to add connection settings to the Adventure Works cube on the OLAP server.

![Pivot Grid](images/pivotgrid.png)

To bind the Pivot Grid control to an OLAP cube, follow the steps below.

1. Set the [PivotGridControl.OLAPDataProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPDataProvider) property to Xmla.
2. Specify connection settings in the [PivotGridControl.OLAPConnectionString](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPConnectionString) property. The following connection string is used in this example:
    ```
    OLAPConnectionString = Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" +
                "Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works";
    ``` 
    Note that a valid connection string should include the following parameters: Provider, Data Source, Initial Catalog, and Cube Name.


## Files to Review

* [Form1.cs](./CS/XtraPivotGrid_XMLA/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_XMLA/Form1.vb))

## Documentation

- [OLAP Mode](https://docs.devexpress.com/CoreLibraries/403809/devexpress-pivot-grid-core-library/pivot-grid-modes/olap-mode)
- [Binding to Data](https://docs.devexpress.com/WindowsForms/1842/controls-and-libraries/pivot-grid/binding-to-data)

## More Examples 

- [Pivot Grid for WinForms - How to Connect the Pivot Grid to an OLAP Data Source](https://github.com/DevExpress-Examples/winforms-pivot-grid-connect-to-an-olap-datasource)
- [Pivot Grid for WinForms - Bind to an OLAP Cube with the ADOMD.NET Data Provider](https://github.com/DevExpress-Examples/winforms-pivotgrid-bind-to-an-olap-cube-with-the-adomdnet-data-provider)
- [WPF Pivot Grid - Bind a PivotGrid to an OLAP Cube (.NET 6.0)](https://github.com/DevExpress-Examples/wpf-pivot-grid-connect-to-an-olap-cube-net6)
- [ASP.NET Pivot Grid - Bind a Pivot Grid to an OLAP Cube at Design Time](https://github.com/DevExpress-Examples/aspnet-pivot-grid-getting-started-bind-a-pivot-grid-to-an-olap-cube-runtime-sample-t540972)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-bind-to-an-olap-cube-via-xmla&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid-bind-to-an-olap-cube-via-xmla&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
