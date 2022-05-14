using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CustomerManager // Katmanlı mimaride manager bizim iş kodlarımıza karşılık gelir. Customer Manager ise müşteri ile ilgili işlemler içindir. Class oluşturulurken (CustomerManager) Pascal Case kullanılır.
    {
        public void Add() // Add metodu oluşturuldu.
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update() // Update metodu oluşturuldu.
        {
            Console.WriteLine("Customer Updated!");
        }

    }
}
