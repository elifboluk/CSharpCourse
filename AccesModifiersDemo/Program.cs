using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesModifiers; // Başka bir projedeki sınıfı kullanmak istiyorsak using kullanmalıyız. Ve sınıfın "public" olması gerekir.

namespace AccesModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Course course = new Course(); // Course class'ı gelmiyor çünkü internal class ve ayrıca başka bir proje içerisinde yer alıyor. 
            // Bir projede başka bir projedeki nesneyi kullanmamız için atmamız gereken bir adım vardır. Bu projede kullanmak için referanslara gelip add referans deriz ve kullanmak istediğimiz nesnenin bulunduğu projeyi seçeriz.

        }
    }
}
