using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors // Constructor, bir sınıf genel anlamda new'lendiğinde çalışacak kod bloğudur.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(10); // parantez o sınıfın constructor'ını parametresiz bir şekilde çalıştırması anlamına gelir. 10 parametresi verdik.
            customerManager.List();


            Product product = new Product { Id = 1, Name = "Laptop" }; // bu şekilde yazmak yerine ↓
            Product product2 = new Product(2, "Computer"); // bu şekilde constructor kullanarak yapılabilir.


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger()); // Nereye loglama yapılacağı parantez içerisinde belirtilir.            
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager // bu sınıfın ihtiyaç duyduğu farklı parametreler varsa ve bu parametreler kullanımıma göre değişkenlik gösteriyorsa constructor'lardan yararlanırız. Bir sınıfın ihtiyaç duyduğu farklı parametreler varsa bu parametreleri constructor ile set ederiz.
    {
        private int _count; // kaç tane listelemek istediğimizi constructor ile geçelim.
        // private int _count=15; // yazarsak ve yukarıdaki CustomerManager() metoduna değer verilmezse default değer 15 olacaktır. Değer verilirse buradaki değer alınmaz.
        public CustomerManager(int count) // ctor tab tab → constractor çağırır.
        {
            _count = count; // best practice privete bir field _ ile başlatılır. metod halinde ise alt çizgi kullanılmaz.
        }

        public CustomerManager() // İkinci bir constructor daha tanımlayalım. Constructor'ları overload edebiliriz.
        {
            // parametresiz(içi boş) constructor oluşturuldu.
        }

        public void List() // List metodu oluşturuldu. 
        {
            Console.WriteLine("Listed {0} items", _count);
        }


        public void Add() // Add metodu oluşturuldu. 
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger) // cosntructor ile gönderilen ILogger neyse _logger'a eşitlendi, database gönderildiyse database, file gönderildiyse file.
        {
            _logger = logger; // burada eşitlendi.
        }     
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }


    // constructor'larla ilgili sık kullanılan özelliklerden bir tanesi de base sınıfa parametre göndermektir.
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;

        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Veritabanına eklendi!");
            Message();
        }
    }


    static class Teacher // static nesneler direkt nesne seviyesinde yani class seviyesinde olabilir. (class'ın başına static ekleriz.)
    {
        // 

    }
}
