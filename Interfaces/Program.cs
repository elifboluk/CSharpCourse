using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
// Interface'lerin amacı bir temel nesne oluşturup bütün nesneleri ondan implemente etmektir.
// Gerçek hayat uygulamalarında interface'leri katmanlar arası geçişlerde yoğun ölçüde kullanırız. Burada amacımız uygulamaların bağımlılıklarını minimize etmektir. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            // Bir interface hiçbir zaman new'lenemez çünkü tek başına bir anlamı yoktur. → (X) IPerson person = new IPerson();
            // Demo();


            // Elimizdeki verileri hem sql hem de oracle veritabanına yazmak istersek ne yapacağız? ↓ 
            ICustomerDal[] customerDals = new ICustomerDal[3] // ICustomerDal türünde array tanımladık ve üç elemanlı(üç veri tabanı için) olacağını belirledik.
            {
                new SqlServerCustomerDal(), // class'ı kullanmak için new'lememiz gerekir. Array'in ilk elemanı.
                new OracleCustomerDal(), // Array'in ikinci elemanı.
                new MySqlCustomerDal() // Array'in üçüncü elemanı. (Sonradan MySql eklemek istersek.)

            };
            foreach (var customerDal in customerDals) // customerDals'ı gezdik ve herbiri için add'i çalıştırdık.
            {
                customerDal.Add();

            };

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Elif",
                LastName = "Bölük",
                Addres = "İstanbul"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Alim",
                LastName = "Bölük",
                Department = "Computer Sciences"
            };
            manager.Add(student);
            manager.Add(customer);

            // Veya böyle de yazabiliriz:
            // manager.Add(new Customer { Id=1,FirstName="Elif", LastName="Bölük", Addres="İstanbul"});
        }
    }
    interface IPerson // Soyut nesne (Tek başına hiçbir anlam ifade etmez.)
                      // IPerson'da tanımlanmış her şeyi customer ve student sınıfında görebiliriz.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson // Somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
    }

    class Student : IPerson // Somut nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) // (Customer customer): Parametre olarak bir ekleme yapacağım, parametre olarak bir müşteri nesnesi ver demektir. Bir nesne(Customer) de parametre olabilir.
        {
            Console.WriteLine(person.FirstName);

        }
    }
}
