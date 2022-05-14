using System;
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new string[] {"Engin", "Derin", "Salih"}; // string[] students2 = {"Engin", "Derin", "Salih"}; şeklinde de yazılabilir.
            students2[3] = "Ahmet"; //Hata verir çünkü 3 yazmak demek 4. elemanı vermek demektir ama biz new string[3] olarak belirledik, dolayısıyla sayıyı aşamayız.

            foreach (var student in students2)
            {
                Console.WriteLine(students);
            }

            Console.WriteLine();
            Console.ReadLine();


            // foreach ile bütün öğrencileri gezebiliriz.
            // string ile metinsel veri tipleri kullanılır, referans tiptir.
            // Aynı tipteki değerleri, değişkenleri tek bir noktada, tek bir değişkenle yönetme şeklinde ona hızlıca ulaşma ve döngüyle gezme ihtiyacında arraylerden yararlanırız.
        }
    }
}
