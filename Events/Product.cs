using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events // Eventler aslında bir delegate'dir. 
{
    public delegate void StockControl(); // Delegate tanımladık.
    public class Product
    {

        private int _stock;

        public Product(int stock) // mevcuttaki stoğu gönderiyoruz ve _stok'a atıyoruz.
        {
            _stock = stock;
        }


        public event StockControl StockControlEvent; // StockControlEvent adıyla StockControl türünde bir event tanımladık.
        public string ProductName { get; set; } // Ürünün adını tutacak property.
        public int Stock // Kişi stok konusunda uyarılmalıysa bu event tetiklecenektir. 
        {
            get { return _stock; }
            set
            {
                _stock = value; // stok değeri kişinin verdiği değere eşitlendi.
                if (_stock <= 15 && StockControlEvent != null) // stok değeri 15'e eşit veya küçük olduğunda ve StockControlEvent null değilse yani kullanıcı bu event'e abone olmuşsa event'i tetikle.
                {
                    StockControlEvent(); // Event tetiklendi.
                }
            }
        }
        // Stock'a değer atadığımızda StockControlEvent'i tetikliyoruz.


        public void Sell(int amount)
        {
            Stock -= amount; // Stoktan satılan satış miktarını çıkarıyoruz.
            Console.WriteLine("{1} Stock amount: {0}", Stock, ProductName); // Ekrana kalan stock adetini yazdırıyoruz. 
        }
    }
}
