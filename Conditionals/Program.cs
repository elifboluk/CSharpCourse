using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
            var number = 10;
            if (number == 10) // Eğer sayı 10 ise
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20) // Eğer sayı 20 ise
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            Console.ReadLine();
            */




            // Single Line İf Metodu 
            /* 
            var number = 11;
            Console.WriteLine(number == 10 ? "Number is 10 : Number is not 10");
            Console.ReadLine();
            */




            // SWITCH Bloğuyla Çalışmak
            // if bloklarıyla yazdığımız koşulları alternatif olarak switch bloğu ile de yazabiliriz.
            /*
            var number = 10;
            switch (number)
            {
                case 10: // Sayı 10 ise
                    Console.WriteLine("Number is 10");
                    break;
                case 20: // Sayı 20 ise 
                    Console.WriteLine("Number is 20");
                    break;
                default: // Yukarıdaki koşulların dışındaki durumlarda
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            Console.ReadLine();
            */




            // Comment CTRL+K+C 
            // Uncomment CTRL+K+U





            //Bir sayının yüzlük dilimlerde nereye geldiğini bulmaya çalıştığımız bir örnek yapalım.
            /*
            var number = 20;
            if (number >= 0 && number <= 100) // Sayı sıfırdan büyük eşitse, yüzden küçük eşitse 
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");

                // Yukarıdaki tasarlanan şartlar haricinde (int veri tipinde) bir şart olmadığı için else yazmaya gerek yoktur. 
            }
            Console.ReadLine();
            */




            // İÇ İÇE İF BLOKLARI
            var number = 11;
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
                else
                {

                }
                if (true)
                {
                    if (true)
                    {

                    }
                }

            }
            Console.ReadLine();
        }
    }
}
