using Microsoft.Data.SqlClient;
using Microsoft.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Testarbeit_ProduktKatalogWinForms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM dbo.Produkte";
            string _connectionString = "Server=ASUSLAPTOPROG;Database=Shop;Trusted_Connection=True;TrustServerCertificate=True";
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            try
            { sqlConnection.Open();
                MessageBox.Show("DB OPENED");
                SqlCommand sqlCommand = new SqlCommand(sqlString);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                //sqlConnection.Close();
            }
           
            catch (SqlException ex){
            MessageBox.Show(ex.Message);
            }
        }
    }
}