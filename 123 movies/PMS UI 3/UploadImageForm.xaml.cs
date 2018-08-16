using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
using System.Windows.Shapes;

namespace PMS_UI_3
{
    /// <summary>
    /// Interaction logic for UploadImageForm.xaml
    /// </summary>
    public partial class UploadImageForm : Window
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-196JTRG\\SQLEXPRESS; Database=dbTestImage;Integrated Security=true");
        public static string filename = "";
        public static string path = "";
        public UploadImageForm()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Select Image";
            of.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (of.ShowDialog()==true)
            {
                BitmapImage img = new BitmapImage(new Uri(of.FileName));
                
                pictureBox.Source = img;
                filename = of.SafeFileName;   // <---
                path = of.FileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //string pic = File.ReadAllBytes(path).ToString();

            //SqlCommand cmd = new SqlCommand("Insert into TestImage (ImgaeUrl) Values (@pic)", con);
            //cmd.Parameters.AddWithValue("@Pic", pic);


            //try
            //{ 
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message); 
            //}
            //finally
            //{
            //    con.Close();
            //}

            string appPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }
            filename = DateTime.Now.ToString("yymmssfff") + filename;
            File.Copy(path, appPath + filename);

            SqlCommand cmd = new SqlCommand("Insert into TestImage (ImgaeUrl) Values (@pic)", con);
            cmd.Parameters.AddWithValue("@Pic", filename);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Image Save successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            SqlCommand command = new SqlCommand("select ImgaeUrl from TestImage where Id=1", con);

            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("MyImages");
            byte[] MyData = new byte[0];

            dp.Fill(ds, "MyImages");
            DataRow myRow;
            myRow = ds.Tables["MyImages"].Rows[1];
            MyData = (byte[])myRow["ImgaeUrl"];

            MemoryStream stream = new MemoryStream(MyData);
            //BitmapImage img = new BitmapImage(MyData);
           



        }
    }
}
