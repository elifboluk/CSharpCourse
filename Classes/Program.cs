using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes // Yapmak istediğimiz işlemlei gruplara ayırmak o grup üzerinden işlemlerimizi yapmak ve rahatlıkla gruba ulaşmak için classları kullanırız.
{
    internal class Program
    {
        static void Main(string[] args) //bu çerçevede kullanmak için bir class'ı onun bir örneğini oluşturmamız gerekir. Örneğin;
        {
            CustomerManager customerManager = new CustomerManager(); //class'ın örneği oluşturulduğunda ise (custormerManager  Camel Case kullanılır.
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.Address = "İstanbul";
            customer.Id = 1;
            customer.Name = "Elif"; // set edildi, değer veriliyor.
            customer.LastName = "Bölük";

            Customer customer2 = new Customer
            {
                Name = "Elif", // ctrl+space yaparak bu şekilde de müşteri ile ilgili bilgileri yazabilirdik.
                LastName = "Bölük",
                Id = 1,
                Address = "İstanbul",
            };
            Console.WriteLine(customer2.Name); // get çalıştı, değer okunuyor.


            Console.ReadLine();

            // Yani hangi nesne ile çalışacaksak o nesneye ait class'ın örneğini oluştururuz sonra içindeki metodları istediğimiz gibi çağırabiliriz.

            // Bir class içerisinde o class'la ilgili metodları barındırır.


            
        }
    }
        
    
}
