using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                // throw; throw hatayı yeniden fırlat demektir.
            }

            // Yukarıdaki try catch kod bloğu görünümünü aşağıdaki HandleException methoduyla da yazabiliriz. Daha büyük kodlar için uygundur.            
            // Aşağıdaki HandleException methodundaki "(() => { })" ne anlama gelir? () ile parametresiz bir method göndereceğimizi söyleriz o kod bloğunun karşılığı da {} şeklindeki bir kod kümesidir demiş oluruz.
            HandleException(() =>
            {
                Find();

            });

            Console.ReadLine();
        }

        private static void HandleException(Action action) // action burada yukarıdaki HandleException methodunun içerisine karşılık gelir, orayı kasteder.
        {
            try
            {
                action.Invoke(); // action.Invoke() HandleException methodu içerisinde gnderdiğimiz Find() methodunu try'ın içerisinde çalıştır demektir.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" }; // Üç elemanlı liste oluşturalım.

            if (!students.Contains("Ahmet")) // Eğer students listesinin içerisinde Ahmet yok ise aşağıdaki hatayı fırlat. ↓
            {
                throw new RecordNotFoundException("Record not found!"); 
            }
            else // Varsa ekrana mesajı yazdır. ↓
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                // try hata olmazsa çalıştır diye yazılan koddur.
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception) // Alacağımız hata türü IndexOutOfRangeException ise bu catch'e girer. Değilse alttaki Exception catch'ine girer. Hataların tamamı Ecxeption'dan inherit edilir, inanmazsan F12 ile base'e git, gör. IndexOutOfRangeException, DivideByZeroException vs. gibi de özel hata türleri vardır.
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) // Yukarıda bir hata olduğunda hata bilgisi exception nesnesine aktarılıyor dolayısıyla burada şöyle bir mesaj yazılabilir. ↓ Hataların tamamı Ecxeption'dan inherit edilir, inanmazsan F12 ile base'e git, gör.  
            {
                // try'da hata olursa cath içerisine geçiş yapılır.
                // Console.WriteLine(exception.Message); // Hata son kullanıcıya gösterilmez. Bu yüzden log'lama yapılır.
                // Console.WriteLine(exception.InnerException); // InnerException, exception hakkında varsa daha detaylı bilgi verir.

            }
        }
    }
}
