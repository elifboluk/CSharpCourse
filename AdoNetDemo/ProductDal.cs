using System;
using System.Collections.Generic;
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

        public List<Product> GetAll() // Ürünleri listeleyeceğimiz method
        {

            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true"); // @ burada yazdığım her şeyi tamamen bir string kabul et demektir.
        }
    }
}
