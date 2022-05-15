using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods // Bir class'ımız var ve bu class içerisinde çeşitli operasyonlar var mesela database işlemleri.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();

        }
    }

    class Database
    {
        public virtual void Add() // Virtual 
        {
            Console.WriteLine("Added by default!"); // Buraya yazdığımız kod bütün veritabanları için geçerli fakat class SqlServer'a veya class MySql'e geldiğimizde durum daha farklıdır. Yani ekleme yaparken daha farklı kod yazmamız gerekir.

        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default!");
        }
    }

    class SqlServer : Database // SqlServer için Database'in Add ve Delete methodlarını kullanabiliriz anlamına gelir.
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code!"); // Bu kod class SqlServer'ın içerisinden gelir.
            // base.Add(); // base: temel. Burada SqlServer'in base'i Database'tir. Bu kod database'in Add'ini çalıştırır.
        } 
        // override dediğimizde inheritance olan sınıfın(Database) içinde virtual keyword'üne sahip methodlar (Add() ve Delete()) en üstte gelir. 
    }
    class MySql : Database // MySql için Database'in Add ve Delete methodlarını kullanabiliriz anlamına gelir.
    {
        // MySql'de virtual'ı override etmediğim için Database'teki temel kod çalışır.
    }
}

