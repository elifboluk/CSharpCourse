using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// S → Single Responsibility Principle
// O → Open/Closed Principle
// L → Liskov Substitution Principle
// I → Interface Segregation Principle
// D → Dependency Inversion

namespace InterfacesDemo // Interface'lerin doğru planlanması çok önemlidir! SOLID Principles → I → Interface Segregation Principle
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] // Worker array'i oluşturuldu.
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();

            }


            IEat[] eats = new IEat[2] 
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();

            }
        }
    }

    interface IWorker
    {
        void Work();
                
    }


    interface IEat
    {
        void Eat();
    }


    interface ISalary
    {
        void GetSalary();
    }


    class Manager : IWorker, IEat, ISalary // Bir class birden fazla interface'i implemente edebilir!
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
           
}
