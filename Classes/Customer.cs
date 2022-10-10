using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; } // (prop + tabtab) Temel anlamda bir müşterinin özelliklerini tutmak için kullandığımız nesnedir. Genellikle veritabanlarındaki kolonların karşılıklarını class için tutabilir. 

        public string FirstName { get; set; } // Bir prop tanımladık. Field değil.

        // ENCAPSULATION ( aşağıdaki örnek fazla kullanılmaz)
        /*
        private string firstName;
        public string FirstName 
        { 
            get{ return "Mrs." + _firstName; } 
            set{ _firstName = value; } 
        }
        Bir field üzerinde get veya set ederken yani değeri verirken veya değeri okurken başka bir şey yapmak istediğimizde bu şekilde gerçekleştirebiliriz. Bu duruma implementasyon değerinin gizlenmesi denir.
        */
        public string LastName { get; set; }
        public string Address { get; set; }

        // public string FirstName; → Bir değişken tanımladık, buna aynı zamanda field denir.
        
    }
}

// Classların bir diğer özelliği ise property dediğimiz nesneleri(özellikleri) tutmaktır.
