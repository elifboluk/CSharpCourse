using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegeate(); // Delegate'in görevi, herhangi bir dönüş değeri olmayan kısacası void döndüren ve parametre almayan operasyonlara delegelik yapar.
    public delegate void MyDelegate2(string text); // string bir parametre alan methodlara delegelik yapar.
    public delegate int MyDelegate3(int number1, int number2); // int döndüren ve int bir parametre alan methodlara delegelik yapar.

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegeate myDelegeate = customerManager.SendMessage; // Bir delegeden birden fazla benzer işleri yapan delege oluşturabiliriz. Burada şu anlama geliyor, myDelegate elçisi customerManager.SendMessage'a delegelik yapar.
            myDelegeate += customerManager.ShowAlert; // += operatörü ile delegeye birden fazla operasyon ekleyebiliriz. Bu operasyonlar sırayla çalışır.
            myDelegeate -= customerManager.SendMessage; // -= operatörü ile delegeye eklenen operasyonları çıkarabiliriz, geri alabiliriz.

            
            
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;



            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp; // En son verilen delegate ne ise o çalıştırılır. 
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);



            myDelegate2("Hello"); // Delegeye parametre göndermek için delegeyi çağırırken parametre göndermemiz yeterlidir. 


            myDelegeate(); // myDelegate elçisi SendMessage'i çalıştırır. Delegate'i çağırdığımız zaman bu işlem gerçekleşir. Çağırmazsak console ekranında boş döner. 

            
            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage() // Mesaj gönderen method oluşturduk.
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert() // Uyarı gösteren bir method oluşturduk.
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message) // string bir parametre alan method oluşturduk.
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert) // Uyarı gösteren bir method oluşturduk.
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2) // int döndüren ve int bir parametre alan method oluşturduk.
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2) // int döndüren ve int bir parametre alan method oluşturduk.
        {
            return sayi1 * sayi2;
        }
    }
}
