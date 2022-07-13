using System;
using System.Collections; // ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities = new string[3]; // Yeni bir referans oluşturduğumuz anda yukarıdaki new string uçar gider. Yeni aldığımız referansın içi ise boş çünkü değer ataması yapılmadı.
            //Console.WriteLine(cities[0]);


            // ArrayList(); // ArrayList'ler tip güvenli değildir. Ne tip veri atarsa atalım uygulama onu kabul ediyor. 
            // List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Dictionary, bir anahtar kelime vasıtasıyla onun değerine ulaşmayı hedeflediğimiz anahtar yapılardır. Örn: İngilizce Türkçe sözlükte; kelime book karşılığı ise kitap gibi. Başka bir örnek; key computer karşılığı yani değeri ise bilgisayar gibi. Dictionary'de çalışırken anahtar hangi türde, değeri hangi türde elmas içinde belirtmeliyiz <string, string> gibi. 
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "bilgisayar");
            // Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["glass"]); // Listede olmayan bir key'in değerini istersek eğer uygulama hata fırlatır. 
            foreach (var item in dictionary) // Bir de foreach ile bütün değerleri gezelim.
            {
                Console.WriteLine(item); // item'dan sonra item.Key ile key'lere veya item.Value ile ise değerlere ulaşabiliriz. 
            }

            dictionary.ContainsKey("glass"); // ContainsKey ile glass key'i olmadığından hata almamak için dictionary'de glass key'i var mıdır diye bakabiliriz. Glass key'i olmadığı için bize bool yani false döndürür.
            dictionary.ContainsKey("table"); // ContainsKey ile table key'ini dictionary'de table key'i var mıdır diye bakabiliriz. Table key'i var olduğudan için bize bool yani true döndürür.
            dictionary.ContainsValue("table"); //ContainsValue ile table value'sunu dictionary'de table değeri var mıdır diye bakabiliriz. Table değeri var olduğudan için bize bool yani true döndürür.


            Console.ReadLine();

        }

        private static void List()
        {
            List<string /* Çalışmak istediğimiz veri tipini içerisine yazıyoruz. */> cities2 = new List<string>();// Tip güvenli koleksiyonların en çok kullanılanı List<>'tir ve generic denir.
            cities2.Add("Ankara");
            cities2.Add("İstanbul");

            Console.WriteLine(cities2.Contains("Adana")); // Listede şehirlerin içerisinde Adana varsa true döner, yoksa false döner. 
            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{ Id = 1, FirstName = "Elif" });
            //customers.Add(new Customer { Id = 2, FirstName = "Bölük" });
            // Yukarıdaki 3 satırlık kodu şu şekilde de yazabiliriz:

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "Elif"},
                new Customer{Id = 2, FirstName = "Aslı"}
            };

            // var count = customers.Count; // Şu ana kadar customers içerisindeki listede kaç eleman vardır? İki; Elif ve Aslı.
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Sema"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer { Id=4, FirstName="Ali"},
                new Customer { Id=5, FirstName="Ayşe"}
            });

            /*Console.WriteLine(customers.Contains(new Customer { Id=1, FirstName="Elif"}));*/ // False dönecektir. Çünkü new dediğimizde yeni bir referans oluşturmuş oluruz. Yani numara ile ilgili karşılaştırma yapılır, gerçekten referansı tutan bir şey göndermeliyiz. Doğrusu şu şekildedir:

            Console.WriteLine(customers.Contains(customer2)); // True döner.

            // customers.Clear(); // Clear ile listede herhangi bir eleman bırakmamış oluruz.

            var index = customers.IndexOf(customer2); // IndexOf listedeki elemanın listede (baştan) kaçıncı sırada olduğunu bize verir.
            Console.WriteLine("Index : {0}", index);


            var index2 = customers.LastIndexOf(customer2); // LastIndexOf listedeki elemanın listede (sondan) kaçıncı sırada olduğunu bize verir. yani customer2'yi aramaya sondan başlar. Sondan başlamasının nedeni ilk bulduğu anda diğerlerine bakmamasıdır. Dolayısıyla sona yakın olduğunu düşündüğümüz durumlarda zamandan tasarruf için sondan arama daha avantajlı olabilir.
            Console.WriteLine("Index2 : {0}", index2);


            customers.Insert(0, customer2); // Kaçıncı sıraya neyi eklemek istediğimizi Insert ile yaparız. Add listenin hep sonuna ekleme yapar.

            customers.Remove(customer2); // Remove bulduğu ilk değeri uçurur ve bulduğu anda da aramayı keser.
            customers.Remove(customer2); // Remove bulduğu ilk değeri uçurur ve bulduğu anda da aramayı keser.
            customers.Remove(customer2); // Remove bulduğu ilk değeri uçurur ve bulduğu anda da aramayı keser. // Bütün Sema değerlerini sırayla uçurduk.

            customers.RemoveAll(c => c.FirstName == "Sema"); // Predicate yani delege gndermemiz gerekiyor. Müşterilerden ismi Sema olanları bul ve sil demektir.

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName); // Neden nesneler ile çalışıyoruz? Çünkü genellikle veritabanı programlama yaptığımız için veritabanındaki tablolarımızın karşılığını nesneler halinde tutarız. Müşteri bir tablo ise tablonun kayıtlarını (id, firstname, lastname gibi) özelliklerini, veritabanından veri olarak çektiğimizde bir listeye atar ve kullanıcıya bunu gösteririz. Bu yüzden nesneler ile çalışmak önemlidir. 
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities2 = new ArrayList(); // ArrayList kullanmak için "using System.Collections" yazılmalıdır. 
            cities2.Add("Ankara"); // İstediğimiz kadar elemean ekliyoruz.
            cities2.Add("Adana ");


            cities2.Add("İstanbul");
            cities2.Add(1);
            cities2.Add('A');

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }


            //cities2.Add("İstanbul"); // // İstediğimiz noktada yeni bir ekleme yapabiliriz.
            //Console.WriteLine(cities2[2]);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
