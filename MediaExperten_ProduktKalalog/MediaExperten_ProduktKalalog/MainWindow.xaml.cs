using System;
using System.Collections.Generic;
using System.Data;
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
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace MediaExperten_ProduktKalalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DB_Controll dB_Controll = new DB_Controll();
            dB_Controll.Connect(); // method that connect to DB and hold stabile connection
        }
       
         //SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");

        public void ClearFields()
        {
            TB_ProductID.Text = "";
            TB_ProductName.Text = "";
            TB_ProductPreis.Text = "";
            TB_ProductQuantity.Text = "";
            TB_ProductSize.Text = "";
            TB_ProductType.Text = "";

        }

        public void SearchProduktNachint(int eigenschaft, string searchfaktor)
        {


            SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");
            //string searchfaktor;
            string sqlString1 = "SELECT * FROM dbo.Produkte WHERE Produkt"+searchfaktor + "=" +eigenschaft + ";";




            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                MessageBox.Show("ok");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString1);

                dataAdapter.Fill(dataTable);
                DataGridProducts.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);



                sqlConnection.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void SearchProduktNachstring(string eigenschaft, string searchfaktor)
        {


            SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");
            //string searchfaktor;
            string sqlString1 = "SELECT * FROM dbo.Produkte WHERE Produkt" + searchfaktor + "='"+eigenschaft+"' ;";




            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                MessageBox.Show("ok");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString1);

                dataAdapter.Fill(dataTable);
                DataGridProducts.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);



                sqlConnection.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void BTN_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BTN_ShowDBProducts_Click(object sender, RoutedEventArgs e)
        {
           
            SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");
            string sqlString1 = "SELECT * FROM dbo.Produkte";
            string remove;

            string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                MessageBox.Show("DB OPENED");
                SqlCommand sqlCommand = new SqlCommand(sqlString1, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable(sqlString1);

                dataAdapter.Fill(dataTable);
                DataGridProducts.ItemsSource = dataTable.DefaultView;
                dataAdapter.Update(dataTable);



                sqlConnection.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BTN_Remove_Click(object sender, RoutedEventArgs e)
        {
            int produktID = int.Parse(TB_ProductID.Text);
            string sqlString2 = "DELETE FROM Produkte WHERE ProduktID = "+ produktID + ";";

            string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString2, sqlConnection);
                sqlCommand.ExecuteNonQuery();


                MessageBox.Show(produktID + " Removed");
                ClearFields();



            }
            catch (SqlException ex)
            {
               
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong");

            }
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            //Przekatanie wartoci z TextBoxow do zmiennych
            int produktID = int.Parse(TB_ProductID.Text);
             string produktName = TB_ProductName.Text;
            string produktSize = TB_ProductSize.Text;
            int produktQuantity = int.Parse(TB_ProductQuantity.Text);
            float produktPreis = float.Parse(TB_ProductPreis.Text);
            int produktTyp =int.Parse(TB_ProductType.Text);

            string sqlString2 = "INSERT INTO dbo.Produkte (ProduktID, ProduktName, ProduktPreis, ProduktQuantity, ProduktSize, ProduktTyp) values ( " + produktID + ",'" + produktName +"'," + produktPreis + "," + produktQuantity + ",'"+ produktSize +"'," + produktTyp + ") ";
            //string sqlString3 = "INSERT INTO dbo.Produkte(ProduktID,	ProduktName,ProduktPreis, ProduktQuantity,ProduktSize,ProduktTyp)values(5, 'EX-200x', 1399, 3, 'L', 1); ";
            string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString2, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Succesful");
                ClearFields();



            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong");

            }
            


        }

        private void SearchIP_Click(object sender, RoutedEventArgs e)
        {
            string searchfaktor = "ID";
            int idnummer = int.Parse(TB_ProductID.Text);
            SearchProduktNachint(idnummer, searchfaktor );
            ClearFields();

           // SqlConnection sqlConnection = new SqlConnection("Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True");
            

           // string sqlString1 = "SELECT * FROM dbo.Produkte WHERE ProduktID =" + idnummer + ";";
            //string remove;

           // string _connectionString = "Data Source=ASUSLAPTOPROG;Initial Catalog=Shop;Integrated Security=True;TrustServerCertificate=True";

           // try
            //{
                //SqlConnection sqlConnection = new SqlConnection(_connectionString);
                //sqlConnection.Open();
                //MessageBox.Show("Complete");
                //SqlCommand sqlCommand = new SqlCommand(sqlString1, sqlConnection);
                //sqlCommand.ExecuteNonQuery();
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable dataTable = new DataTable(sqlString1);

                //dataAdapter.Fill(dataTable);
                //DataGridProducts.ItemsSource = dataTable.DefaultView;
                //dataAdapter.Update(dataTable);



                //sqlConnection.Close();
                //ClearFields();
            //}

            //catch (SqlException ex)
            //{
              //  MessageBox.Show(ex.Message);
            //}

        }

        private void SearchName_Click(object sender, RoutedEventArgs e)
        {
            string eigenschaft = TB_ProductName.Text;
            string searchfaktor = "Name";
            SearchProduktNachstring(eigenschaft, searchfaktor);
        }

        private void SearchType_Click(object sender, RoutedEventArgs e)
        {
            int eigenschaft = int.Parse(TB_ProductType.Text);
            string searchfaktor = "Typ";
            SearchProduktNachint(eigenschaft, searchfaktor);

        }



        private void SLIDER_ProductPreis_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int k = (int)SLIDER_ProductPreis.Value;

            TB_ProductPreis.Text = k.ToString();
       
        }

       
    }
    }

