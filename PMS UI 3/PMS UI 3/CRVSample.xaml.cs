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
            dt.Columns.Add("Age", typeof(Int32));
            dt.Columns.Add("Salary", typeof(decimal));

            for (int i = 0; i < 6; i++)
            {
                int id = 1;
                string name = "Rana Abbas";
                int age = 22;
                decimal sal = 2000;

                dt.Rows.Add(id,name,age,sal);
            }

            SampleReport sr = new SampleReport();
            sr.Database.Tables["DTSample"].SetDataSource(dt);

            sampleCRV.ViewerCore.ReportSource = sr;
        }
    }
}
