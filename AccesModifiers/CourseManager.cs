using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    internal class CourseManager
    {
        public void Add()
        {
            Course course = new Course();
            {
                // private sadece o sınıf içinde tanımlanmışsa o sınıfta, metod içinde tanımlanmışsa o metodta, hatta if bloğu içindeyse sadece o if bloğu içerisinde geçerlidir. Kısacası tanımlandığı blok içerisinde geçerlidir.
                // protected private gibi kullanılıyor ve aynı zamanda inheritance aldığı yerde de geçerlidir.
                // internal ise bulunduğu proje içerisinde istediğimiz noktada çağırabileceğimiz anlamına gelir.
                // public ise referans verildiği zaman başka projede kısacası herhangi bir erişim kısıtını koymak istemediğimiz zaman kullanabiliyoruz.

                // Kodun okunurluğunu arttırmak ve programcıyı yanlış yönlendirmemek için classlarda hangi Acces Modifiers gerekiyorsa o verilmedilir. 
            }
        }
    }
}
