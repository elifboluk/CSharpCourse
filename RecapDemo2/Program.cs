using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Interface'leri kullanarak temel bir implementasyon örneği yapalım.
// Amaç: Kullanıcılardan biri müşteri eklediği zaman hangi kullanıcı, hangi datayı, ne zaman logladı diye loglama yapmak istiyoruz. (Loglamayı bu amaçla kullanırız, biri bir veri çağırdığı zaman veritabanına bir kayıt daha atılır ve örneğin Elif add metodunu şu tarihte, şu parametrelerle çalıştırdı gibi bilgiler içerir.)
// Amaç2: Verilerin veritabanına, herhangi bir dosyaya veya sms gönderilerek loglama yapılmasını istiyoruz.
namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaaseLogger(); //Veritabanına logladı.
            customerManager.Logger = new FileLogger(); // Dosyaya logladı.
            customerManager.Logger = new SmsLogger(); // Sms olarak logladı.
            customerManager.Add();
            Console.ReadLine();

        }
    }
    
    class CustomerManager // Customer Manager müşteri ile ilgili iş classlarını gerçekleştiriyor.
    {
        public Ilogger Logger { get; set; }
        public void Add() // Add metodu oluşturuldu.
        {

            /* DatabaaseLogger logger = new DatabaaseLogger();
            logger.Log(); 
            // Bu yazım biçimi doğru değildir çünkü eklemeyi her zaman veritabanına loglamak durumunda kalırız. Halbuki bazen dosyaya bazen veitabanına loglamak isteyebiliriz. */
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaaseLogger : Ilogger // Database'e loglama yapacak DatabaseLogger sınıfı oluşturuldu. Bir class'ın (loglama işlemi ise) mutlaka bir base'i olmalı.
    {
        public void Log() // Log metodu oluşturuldu.
        {
            Console.WriteLine("Logged!");
        }
    }

    class FileLogger : Ilogger // Dosyaya loglama yapacak FileLogger sınıfı oluşturuldu. (Müşteri veritabanı yerine herhangi bir dosyaya loglama yapılmasını isterse...)
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : Ilogger // Sms olarak loglama yapacak SmsLogger sınıfı oluşturuldu. (Müşteri veritabanı veya dosya yerine sms ile loglama yapılmasını isterse...)
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
    interface Ilogger
    {
        void Log();
    }
}
