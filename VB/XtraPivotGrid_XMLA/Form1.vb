Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_XMLA

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Specifies that PivotGridControl should use the XMLA data access standard
            ' to bind to an OLAP cube.
            pivotGridControl1.OLAPDataProvider = OLAPDataProvider.Xmla
            ' Configures a data connection.
            ' Specifies a string that encapsulates connection parameters 
            ' required to access the desired OLAP cube.
            pivotGridControl1.OLAPConnectionString = "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" & "Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works"
        End Sub
    End Class
End Namespace
