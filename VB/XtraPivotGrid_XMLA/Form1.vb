Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_XMLA
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Creates an XMLA datasource object that will be used
			' to access OLAP data.
			Dim ds As New PivotGridXmlaDataSource()

			' Configures a data connection.
			' Specifies a string that encapsulates connection parameters 
			' required to access the desired OLAP cube.
			ds.ConnectionString = _
                "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll" & _
                    ";Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works"

			' Assigns the configured XMLA datasource object to the pivot grid.
			pivotGridControl1.DataSource = ds
		End Sub
	End Class
End Namespace