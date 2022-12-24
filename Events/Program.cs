using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product product = new Product(20); // Product nesnesi oluşturduk ve stok değerini 20 olarak atadık.
            // product.ProductName = "Laptop"; // Ürünün adını Laptop olarak atadık.

            // -------------------------------------------------- //
            
            // Hem harddisk hem de gsm'in satıldığı bir senaryoda;
            
            Product harddisk = new Product(50); // Product nesnesi "harddisk" oluşturduk ve stoktaki harddisk değerini 50 olarak atadık.
            harddisk.ProductName = "Harddisk"; // Ürünün adını Harddisk olarak atadık.

            Product gsm = new Product(50); // Product nesnesi "gsm" oluşturduk ve stoktaki gsm değerini 50 olarak atadık.
            gsm.ProductName = "Gsm"; // Ürünün adını Gsm olarak atadık.
            gsm.StockControlEvent += Gsm_StockControlEvent; // Gsm_StockControlEvent eventini tetiklemek için gsm.StockControlEvent'e abone olduk.

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10); // harddisk satıldı.
                gsm.Sell(10); // gsm satıldı.
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent() // Gsm_StockControlEvent eventi tetiklendiğinde bu method çalışacak.
        {
            Console.WriteLine("Gsm stock is low!"); // Ekrana "Gsm stock is low!" yazdır.
        }
    }
}
