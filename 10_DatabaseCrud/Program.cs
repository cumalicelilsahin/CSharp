using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read-Update-Delete

            #region Eklemeİşlemi
            //Console.WriteLine("İşlem Paneli");
            //Console.WriteLine("eklemek istediğin isim");
            //string isim = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into FirstTable (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", isim);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Başarıyla Eklendi");
            #endregion

            #region ÜrünEklemeİşlemi

            //string name;
            //decimal price;
            //bool status;

            //Console.WriteLine("Eklemek istediğin ürün: ");
            //name = Console.ReadLine();
            //Console.WriteLine("Fiyatı ne kadar olsun: ");
            //price = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Stok var ise true yok ise false yazın: ");
            //status = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into SecondTable (Name,Price,Status) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", name);
            //command.Parameters.AddWithValue("@p2", price);
            //command.Parameters.AddWithValue("@p3", status);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ekleme Başarılı");

            #endregion

            #region Listelemeİşlemi

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from SecondTable", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Güncelleme İşlemi

            //Console.WriteLine("Güncelleme yapılacak id: ");
            //int id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncel ürün adı: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Güncel ürün fiyatı: ");
            //decimal price = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update SecondTable set name=@Name,Price=@Price where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@Name", name);
            //command.Parameters.AddWithValue("@Price", price);
            //command.Parameters.AddWithValue("@productID", id);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı.");
            #endregion

            #region Silmeİşlemi

            //Console.WriteLine("Silmek istediğin id gir: ");
            //int id = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-L2DCMKI;Database=CSharpDB;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from FirstTable where CategoryId=@id", connection);
            //command.Parameters.AddWithValue("@id", id);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Başarılı.");

            #endregion


            //-------------
            Console.Read();
        }
    }
}
