using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType // int, boolean, enum, double, decimal = değer tip
                                // claslar, string, interface, abstract sınıflar, arrayler = reference tip

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            //----------------------------//

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; // 101 referans numarası atandı diyelim
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; // 102 referans numarası atandı. // Yeni referans 102 yerine 101 yapıldı.
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            //----------------------------//

            DataTable dataTable; // = new DataTable(); // dataTable = dataTable2; dediği için aslında bu satırda new'lememizin bir anlamı yoktur.
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
