using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Private erişim bildirgeci sadece tanımlandığı blok içerisinde geçerli olan yapıdır. (class, field, property  olabilir, her şeyi private yapabiliriz.)


namespace AccesModifiers // (ErişimBildirgeçleri) private - protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        // private int Id { get; set; } // Id default olarak private'dir.
        protected int Id { get; set; } // protected private'ın bütün özelliklerini karşılar. Tanımlandığı blok içerisinde her yerde geçerlidir, class seviyesinde tanımlanır.
        public void Save()
        {
            // private id burada kullanılabilir. 
        }
    }

    class Student : Customer
    {
        public void Save2()
        {

            // Customer customer = new Customer();
            // customer.id; // id gelmez çünkü id private bir değişkendir. private değişken sadece tanımlandığı blok içerisinde geçerlidir.

            Id // Protected'da ise Id buraya gelir. Protected ve private farkı: protected olarak tanımladığımız değişken; özellik, metod her ne ise.. inherite edildiği sınıflarda kullanılabilir, yani private'ı inheritence sınıfına çıkarabiliyoruz.
        }
    }
}
