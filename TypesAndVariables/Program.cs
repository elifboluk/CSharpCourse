using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.ReadLine();


            int number1 = 5; // number1 bir değişkendir, int ise veri tipidir. 
            // int, tam sayıları tutmaya yarayan veri tipidir. Değer (Value types) veri tiplerinden bir tanesidir. 
            Console.WriteLine("Number1 is {0}", number1);

            // Küme parantezi içerisine yazılan {0} virgülden sonraki ilk parametreyi temsil eder. integer veri tipi; -2147483648 ile +2147483647 arasında değer alabilir. Int 32 bitlik yer kaplar.


            long number2 = 2147483647;
            // Long, integerin tam iki katı kadar bellekte yer kaplayan veri tipidir.
            Console.WriteLine("Number2 is {0}", number2);

            // 19 karaktere kadar tam sayı tutabilir.-9223372036854775808 ile -9223372036854775807 arasında değer alabilir. Long, 64 bitlik yer kaplar.

            short number3 = 32767;
            // Short veri tipi, bellekte 16 bitlik yer kaplar. -32768 ile +32767 arasında tam sayı değeri alabilir. 
            Console.WriteLine("Number3 is {0}", number3);



            byte number4 = 255;
            // Byte veri tipi, 0 ile 255 arasında tam sayı değeri alabilir..
            Console.WriteLine("Number4 is {0}", number4);


            bool condition = true; // condition = false;
            // boolean mantıksal bir veri tipidir. aslında tuttuğu değer true veya false'dur. genellikle if (şart bloklarında) bloklarında sıklıkla karşılaşırız. Değer (Value types) veri tiplerinden bir tanesidir.

            char character = 'A'; // Atama yapmak için tek tırnak kullanılır.
            Console.WriteLine("Character is {0}:", character);
            Console.WriteLine("Character is {0}:", (int)character);
            // char veri tipi rahatlıkla integer veri tipine (ASCII) çevirilebilir. Bu bağlamda (int)character yazılabilir.
            string city = "Ankara"; // city altı tane karakterden oluşan bir dizidir.

            double number5 = 10.4;
            // double veri tipinde ondalıklı sayıları da tanımlayabiliriz. Bellekte 64 bitlik yer kaplar. Virgülden sonra 15-16 tane değer tutabilir.
            Console.WriteLine("Number5 is {0}", number5);
            Console.ReadLine();

            decimal number6 = 10.4m; //ondalık olmadığında m olmadan atama yapabiliriz.
                                     //int için long neyse double için decimal o'dur diyebiliriz. Yapacağımız hesaplamalar için hassasiyet önemliyse (para tutarı için) double veri tipini kullanırız. Virgülden sonra 28-29 tane değer tutabilir.

            Console.WriteLine((int)Days.Friday); // enum sabitleri değerlerini 0. indisten başlatacak şekilde gerçekleştirir. Monday=10 şeklinde bir atama yaparsak Tuesday=11, Wednesday;=12 ... olacak şekilde diğer değerler için atama otomatik olarak sırayla yapılır.


            var number7 = 10;
            // number7 = 'A';
            // Var keywordu aslında bir değişken değildir fakat değişken tutmak için kullanılır. 
            // Atadığımız değer ne ise veri tipi o olarak algılanır. 

        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    // enum, değerleri string gibi yazmamızı önler ve magic string ile uğraşmak durumunda kalmayız.
}
