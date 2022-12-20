using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(2, 3); // Topla2 buradaki gelen değerlerle çalışır.
            Console.WriteLine(dortIslem.Topla2()); // Topla2 direkt constructor'dan gelen değerlerle çalışır.

            Console.WriteLine(dortIslem.Topla(3, 4)); // Topla methodu ile gelen değerlerle çalışır. Bu methodu kullanırken kullanıcıdan değerleri parantez içerisinde alıyoruz.

            Console.ReadLine();
        }
    }

    public class DortIslem
    {

        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2) // Kullanıcıdan sayıları aldık. 
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2) // Kullanıcıdan direkt sayıları aldık.
        {
            return sayi1 + sayi2;
        }
        
        public int Carp(int sayi1, int sayi2) // Kullanıcıdan direkt sayıları aldık.
        {
            return sayi1 * sayi2;
        }

        public int Cikar() // Sayıları constructor'dan aldık.
        {
            return _sayi1 - _sayi2;
        }

        public int Topla2() // Sayıları constructor'dan aldık.
        {
            return _sayi1 + _sayi2;
        }
    }
}

