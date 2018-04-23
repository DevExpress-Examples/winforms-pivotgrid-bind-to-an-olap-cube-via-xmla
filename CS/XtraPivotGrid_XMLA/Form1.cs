using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_XMLA {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {

            // Specifies that PivotGridControl should use the XMLA data access standard
            // to bind to an OLAP cube.
            pivotGridControl1.OLAPDataProvider = OLAPDataProvider.Xmla;

            // Configures a data connection.
            // Specifies a string that encapsulates connection parameters 
            // required to access the desired OLAP cube.
            pivotGridControl1.OLAPConnectionString = 
                "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" +
                "Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works";
        }
    }
}