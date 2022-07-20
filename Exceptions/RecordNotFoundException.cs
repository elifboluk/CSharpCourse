using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bir listede kayıt aranıp bulunamadığı zaman bunu bir exception haline getirmek ve arayüze exception olarak göndererek kontrol altına almak için RecordNotFoundException oluşturalım. (Kısacası kendi hata metodumuzu oluşturacağız.)

namespace Exceptions
{
    internal class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message):base(message) // ctor tab tab, base'e constructor bloğu vasıtasıyla base'in constructor'ına parametre gönderdik.
        {

        }
    }
}
