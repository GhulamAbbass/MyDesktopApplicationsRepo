using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CrystalDecisions;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace PMS_UI_3
{
    /// <summary>
    /// Interaction logic for CRVSample.xaml
    /// </summary>
    public partial class CRVSample : Window
    {
        public CRVSample()
        {
            InitializeComponent();
        }

        private void btnPrintReport_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id",typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Qty", typeof(Int32));
            dt.Columns.Add("Rate", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            for (int i = 0; i < 200; i++)
            {
                int id = 1;
                string name = "lahore madical store 10 Tab 10/5";
                int qty = 10;
                float rate =float.Parse( 102.25.ToString());
                float tot =float.Parse( 1022.5.ToString());

                dt.Rows.Add(id,name,qty,rate,tot);
            }

            SampleReport sr = new SampleReport();
            sr.Database.Tables["DTSample"].SetDataSource(dt);

            sampleCRV.ViewerCore.ReportSource = null;
            sampleCRV.ViewerCore.ReportSource = sr;
        }
    }
}
