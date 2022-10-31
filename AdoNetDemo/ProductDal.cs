using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ProductDal, veritabanından veriyi çekme, veritabanına yeni veri gönderme, silme, güncelleme (Insert, Update, Delete, Select) işlemlerini içerir.
// initial catalog: hangi veritabanına bağlacağımızı söyler.
// integrated security: veritabanına windows authentication ile bağlan demektir.
namespace AdoNetDemo
{
    public class ProductDal
    {

        public List<Product> GetAll() // Ürünleri listeleyeceğimiz method.
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true"); // @ burada yazdığım her şeyi tamamen bir string kabul et demektir.
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection); // Sorguyu bağlantıya gönder.
            SqlDataReader reader = command.ExecuteReader(); // ExecuteReader metodu ile komut çalıştırılır. 

            List<Product> products=new List<Product>();
            while (reader.Read()); // reader'daki kayıtları tek tek oku, okuyabildiğin sürece döngü içerisinde çalıştır. 
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product); // Her okuduğun elemanı product'a aktar, sonra da listeye ekle. 
            }
            reader.Close();
            connection.Close();
            return products;
        }


        public DataTable GetAll2() // Ürünleri listeleyeceğimiz method.
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true"); // @ burada yazdığım her şeyi tamamen bir string kabul et demektir.
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection); // Sorguyu bağlantıya gönder.
            SqlDataReader reader = command.ExecuteReader(); // ExecuteReader metodu ile komut çalıştırılır. 

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
