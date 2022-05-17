using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses //Abstract'lar birer classdır. Interface ve virtual methodların birleşimi gibi düşünülebilir.Tamamen inheritance amacıyla kullanılır. 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Database database new Database(); // yazamayız. Interface'ler gibi abstract classları da new'leyemeyiz. Bunun yerine SqlServer veya Oracle'ı implemente edebiliriz. 

            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            // Kodu çalıştırdığımızda ekleme methodunun hepsinde aynı fakat delete methodunun veritabanlarına göre farklılık gösterdiğini görürüz. Çünkü abstract sınıfı add'in aynı, delete'in farklı olduğunu implemente eder.  
            // Abstract'lar de birer inheritance özelliğidir, dolayısıyla SqlServer sadece bir abstract'tan inherit edilebilir. Abstract'lar bir class gibidir dolayısıyla başka bir class'tan ya da abstract'tan inherit edilemez. Abstract'ları katiyen new'leyemeyiz.
            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add() // Varsayalım ki ekleme işlemi bütün veritabanlarında aynı. Tamamlanmış method
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // Varsayalım ki silme işlemi bütün veritabanlarında farklı. Tamamlanmamış method.
                                       // Abstract'larla hem tamamlanmış hem de tamamlanmamış methodlar yapılabilir.
    }
    class SqlServer : Database
    {
        public override void Delete() // override olarak sadece "delete" geldi!
        {
            Console.WriteLine("Deleted by Sql!");
        }
        // Abstract'lar içi dolu olmayan virtual methodlardır. Yani delete işlemi her ortamda farklı olduğu için herkesin ayrı ayrı implemente etmesi gerekir.
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle!");
        }
    }

}
