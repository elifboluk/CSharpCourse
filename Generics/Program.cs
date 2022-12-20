using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generics and Generic Constraints: Genericler ve Generic Kısıtları

namespace Generics
{
    class Program
    {
        static void Main(string[] args) // Generic'leri interface, class veya abstract class'larla kullanabiliriz demiştik fakat istersek interface'in veya class'ların tamamı için değil de bir metot için de kullanabiliriz. 
        {

            Utilities utilities = new Utilities(); // Utilities'i genellikle işlemleri içerisine koymak için kullandığımız araçlar nesnesi gibi düşünebiliriz.
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana"); // Burada BuildList metodunu kullanarak string bir liste oluşturduk .BuildList<string> ile hangi tipte yazarsam bana bu tipte bir liste oluştur, yani datayı o tipte bir liste haline getir.
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Elif" }, new Customer()); // Burada çalıştığım tip ise customer sınıfıdır.
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }


    }
}
class Utilities
{
    public List<T> BuildList<T>(params T[] items)  // List<string> result = utilities.BuildList<>: string döndürüyor ama başka bir durumda integer döndürmesini de isteyebilirdik. Öyleyse burayı class içerisinde tanımlarken generic formda tanımlamalıyız (BuildList<T>) ki daha sonrasında parametre değiştiğinde dahi problem çıkartmasın. Kaç tane değer göndereceğimizi bilemeyeceğimiz için ise "params" kullanıyoruz. Params ile gönderdiğimiz değerleri bir dizi haline getiriyoruz. 

    {
        return new List<T>(items);
    }
}


// Generic'lerin kullanım alanları şekilleri: ↓

class Product : IEntity // IEntity'den implemente edilen bir sınıf, veritabanı nesnesidir demektir.
{
}

interface IProductDal : IRepository<Product> // Çalışma tipi Product sınıfı. 
{
    //List<Product> GetAll(); // Çoklu veri getir. 
    //Product Get(int id); // Tek veri getir. 
    //void Add(Product product); // Veri ekle
    //void Delete(Product product); // Veri sil. 
    //void Update(Product product); // Veri güncelle.
}

class Customer : IEntity // IEntity'den implemente edilen bir sınıf, veritabanı nesnesidir demektir.
{
    public string FirstName { get; set; }
}

interface ICustomerDal : IRepository<Customer> // Çalışma tipi: Customer sınıfı.
{
    //List<Customer> GetAll();
    //Customer Get(int id);
    //void Add(Customer product);
    //void Delete(Customer product);
    //void Update(Customer product);
}



//↑ Generic'ler, yukarıdaki -yorum satırı ile kapatılmış- örneklerde olduğu gibi sıklıkla yaptığımız operasyonları nesne bazlı olarak değiştirebilceğimiz bir yapıdır. Bizleri kod tekrarından kurtarır. Generic yapı oluşturabilmek için örneğin interface, class veya abstract class sonuna <Type> yazmamız yeterlidir. örn: interface IRepository<T>



//↓ "IRepository" generic repository olarak adlandırılır. Verilen T parametresine göre işlemleri yapar. (entity=varlık, genel bir isim kullandık.) Buradaki T parametresi ile bir değişken oluşturduk ve artık customer için de product için de bu T parametresi geçerlidir.
//↓ where T: class → Generic kısıtları: Generic'lerin kullanım alanlarını sınırlamak için kullanılır. Burada T'nin  class olarak işaretlenmiş olması yani class'tan kasıt sadece class'a işaret etmez, class olabilir demek değildir. Aslında buraya yazılan T bilinenin aksine referans tip'e işaret eder, referans tip olmak zorundadır. (string yazarsak kızmaz. Çünkü string referans tip'dir.)
//↓ where T: class, new() → dediğimizde ise buraya yazılan tip new'lenebilir olmalıdır kısıtı koyarız. Ve artık string kullanılamaz çünkü string new'lenemez. (new'lenebilir olmak için class olması gerekir. new() yazarak böylelikle kısıtlamadaki kastımızın tam anlamıyla classs olduğunu belirtmiş oluruz.)
 
interface IRepository<T> where T : class, IEntity, new() // new() her zaman sonda olmalıdır.
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}
//↓ where T : class, new() dediğimizde referans tipli ve new'lenebilir kısıtı koymuştuk generic repository'mize; fakat aşağıda görüldüğü üzere interface IStudentDal: IRepository<CustomerDal> şeklindeki yazımda CustomerDal yazabiliyoruz bu kısıt içerisinde. Bizim burada T tipi olarak sadece veritabanı tablolarını kullanmamız gerekir, bu profesyonel ve en doğru kullanımdır. Sadece veritabanı tabloları olarak görev yapan class'larımızı almak için IEntity interface'ini implemente ederek kullanırız. Bu şu anlamına gelir; IEntity'den implemente edilen bir sınıf, veritabanı nesnesidir demektir.

//↓ Sadece değer tipleri koymak isteseydik, değer tip şartı getirmek isteseydik ne yapmalıydık? →↓
// interface IRepository<T> where T : struct yazmalıydık. Böylelikle int gibi değer tipleri kullanabilirdik.

/*
interface IStudentDal : IRepository<CustomerDal> // Customer Dal IEntity'den implemente olmadığı için burada kod hata veriyor.
{ 
    
}
*/

class Student : IEntity // IEntity'den implemente edilen bir sınıf, veritabanı nesnesidir demektir.
{
    
}

interface IEntity
{

}
// ↓↓↓↓↓↓ //


// ProductDal sınıfı IProductDal interface'ini implemente eder ve metodları çağırır.
// class ProductDal : IRepository<Product> da denebilirdi; fakat sadece ProductDal'a özel bir operasyon yazmak istediğimizde -tekrar implemente etmek gerektiği için- bizi zorlar. Bu yüzden IRepository<Product> yerine IProductDal interface'ini implemente etmemiz daha doğru bir kullanımdır.
class ProductDal : IProductDal 
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}

class CustomerDal : ICustomerDal // CustomerDal sınıfı ICustomertDal interface'ini implemente eder ve metodları çağırır. 
{
    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }
}




