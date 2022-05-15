using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance // Kalıtım(Miras)
// Interface'ler de bir inheritance örneği gibi çalışırlar fakat inheritance değillerdir, bir implementasyondurlar. (Yeni nesil dillerde inheritance gibi kullanılırlar.)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirsName = "Elif";

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirsName = "Elif",
                    LastName = "Bölük"
                },
                new Student
                {
                    FirsName = "Abcd",
                    LastName = "Efgh"
                },
                new Person
                {
                    FirsName = "Jklmn",
                    LastName = "Prsşt"
                }
                // new Person() da olabiliyor, peki niye? Çünkü Interface'lerde interface tek başına bir anlam ifade etmiyor fakat class'larda class Person tek başına bir anlam ifade ediyor veya inheritance verdiği noktada da.
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirsName + " " + person.LastName);
            }
            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirsName { get; set; }
            public string LastName { get; set; }

        }

        // class Person2 
        // {

        // }

        interface IPerson
        {

        }

        class Customer : Person, IPerson
        // Person2'yi ekleyemeyiz çünkü bir class. Bir nesneyi yalnız bir kere inheritance alabiliriz ama birden fazla imlementasyon yapabiliriz. Interface IPerson'u ekleyebiliriz.
        // Customer, person'dan meydana gelmiş bir nesnedir gibi düşünülebilir.
        {
            public string City { get; set; }

        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
