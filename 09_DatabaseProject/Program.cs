using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
         

            SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("select * from FirstTable", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            //---
            Console.Read();
        }
    }
}
