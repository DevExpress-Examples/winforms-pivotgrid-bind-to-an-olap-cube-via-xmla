using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_XMLA {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e) {

            // Creates an XMLA datasource object that will be used
            // to access OLAP data.
            PivotGridXmlaDataSource ds = new PivotGridXmlaDataSource();

            // Configures a data connection.
            // Specifies a string that encapsulates connection parameters 
            // required to access the desired OLAP cube.
            ds.ConnectionString = "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll" +
                                  ";Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works";

            // Assigns the configured XMLA datasource object to the pivot grid.
            pivotGridControl1.DataSource = ds;
        }
    }
}