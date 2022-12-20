using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer); // customerDal'ın add metoduna yukarıda oluşturduğumuz customer metodunu gönderiyoruz. 
            Console.ReadLine();
        }
    }

    [ToTable("Customers")] // Attribute: Veritabanında customer classına denk gelir.
    [ToTable("TblCustomers")] // Attribute: Veritabanında customer classına denk gelir.
    // AllowMultiple = true ile aynı attribute'ü aynı class'ta birden fazla kez kullanabildik.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] // "Attribute: FirstName zorunludur." RequiredProperty attribute'ünü biz oluşturduk ama bu attribute'ün ne anlama geldiğini nasıl bulacağız? İşte bu noktada reflection devreye giriyor.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }        
    }
    
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")] // Obsolete ile Add metodunu kullanma mesajı veriyoruz, AddNew metodunu kullan önerisinde bulunuyoruz. (Senaryo: Bu metodu önceden yazdık projenin farklı yerlerinde kullandık,; fakat daha sonra bu metodun yerine daha güncel hali olan AddNew metodunu yazdık. Bu yüzden Add metodunu kullanma, AddNew metodunu kullan diyerek kullanıcıyı uyarıyoruz.)
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", 
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] // AttributeUsage ile bu attribute'ün hangi classlarda kullanılacağını belirtiyoruz. Bu attribute'ün sadece property ve field'larda kullanılmasını istiyoruz.
    class RequiredPropertyAttribute : Attribute // 
    {
    }

    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] // Bu attribute'ün sadece classlarda kullanılmasını istiyoruz. Ayrıca bu attribute'ün birden fazla kullanılmasına izin veriyoruz. 
    class ToTableAttribute : Attribute // Attribute'e parametre yolladığımızda constructor ile set etmeliyiz. 
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    
}

