using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; } // Temel anlamda bir müşterinin özelliklerini tutmak için kullandığımız nesnedir. Genellikle veritabanlarındaki kolonların karşılıklarını class için tutabilir. 

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        
    }
}

// Classların bir diğer özelliği ise property dediğimiz nesneleri(özellikleri) tutmaktır.
