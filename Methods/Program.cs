using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir kullanıcının bilgilerini veritabanına kaydetmeye ihtiyaç duyduğumuzu düşünelim. Bu işlemi yaptığımız her noktada kaydetme metodunu kodun içerisine tekrar tekrar yazarsak daha sonrasında güncellemek istediğimizde kod içerisinde çok fazla değişiklik yapmak zorunda kalacağız. Metodlarla bir işlemi yaptığımızda o işlemi güncellemek veya tekrar kullanmak istersek tek merkezden aynı metodu kontrol edebilme imkanı buluyoruz. 


            Add(); // Metodu yazzdıktan sonra metodun çağırımını yaparız.
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30); // Elimizdeki result'ın bu metodun çalışması sonucunda ortaya çıkan integer olduğunu söyleyebiliriz.
            Console.WriteLine(result); // Sonucu ekrana yazdır.            
            Console.ReadLine();
        }

        static void Add() // Toplama işlemi yapalım.
        {
            Console.WriteLine("Added!"); // Metodun içerisindeki mesajı değiştirmek istersek tek merkezden yapabiliriz.
        }

        
        static int Add2(int number1, int number2) // Add iki metodunda number1 ve number2 isimli int tipinde iki adet değişken parametre mevcuttur.
        {
            /* var result = number1 + number2;
               return result; 
            //şeklinde de yazabilirdik.
            */
            // void işlem yap; yaz, kayıt yap vs. demektir. Burada işlem yapıp geriye bir sonuç döndereceğimiz için void yerine ne tipte bir veri döndürmek istiyorsak o veri tipini yazıyoruz. 
            return number1 + number2;            
        }




        /*
        //6.3_DEFAULT PARAMETRELİ METODLARLA ÇALIŞMAK 

        static int Add2(int x, int number1, int number2 = 30) // Eğer number2'ye bir parametre girilmezse default olarak 30 al. Default değerlerin her zaman metodun en sonunda olması gerekir.
        return number1 + number2;
        return result;
        }
        */
    }
}
