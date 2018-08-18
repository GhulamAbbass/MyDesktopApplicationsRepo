using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PMS_UI_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            DemarcationEntry f = new DemarcationEntry();
            f.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            LetterPrinting f = new LetterPrinting();
            f.Show();

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            PossessionDemarcation f = new PossessionDemarcation();
            f.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PossessionofPlot f = new PossessionofPlot();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SitePlanQuery f = new SitePlanQuery();
            f.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PossessionofPlot2 f = new PossessionofPlot2();
            f.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SitePlanIssue f = new SitePlanIssue();
            f.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PrintofSitePlan f = new PrintofSitePlan();
            f.Show();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            OwnershipDescription f = new OwnershipDescription();
            f.Show();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            RelationDescription f = new RelationDescription();
            f.Show();
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            CRVSample f = new CRVSample();
            f.Show();
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            UploadImageForm f = new UploadImageForm();
            f.Show();
        }
    }
}
