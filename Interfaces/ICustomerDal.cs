using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Gerçek uygulamalarda interface'ler farklı implementasyonlar için kullanılır. SQL Server, Oracle, MySQL vb. destekli bir sistem yazmak istersek herbiri için kullanacağımız teknoloji farklıdır. Bu yüzden ICustomerDal'ı herbiri için ayrı ayrı implemente etmek gerekir. 
namespace Interfaces
{
    interface ICustomerDal // Data Access Layer: Veritabanı işlemlerini yapmak için kullancağımız sınıftır; insert, update, delete... 
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Delete!");
        }

        public void Update()
        {
            Console.WriteLine("SQL Update!");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update!");
        }
    }

    class MySqlCustomerDal : ICustomerDal // Verileri yeni bir veritabanına eklemek istediğimizde.

    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Delete!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Update!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) // Ekleme işlemini SQL'e göre mi yoksa Oracle'a göre mi yapacağız?
        {
            customerDal.Add();
        }
    }
}
