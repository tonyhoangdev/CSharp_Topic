using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    interface ISpeak
    {
        void Speak();
    }

    class Animal : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Animal's speaking...");
        }
    }

    class Cat : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Cat's speaking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ISpeak> lstSpeak = new List<ISpeak>();

            ISpeak ani = new Animal();
            ani.Speak();
            ISpeak cat = new Cat();
            cat.Speak();

            lstSpeak.Add(ani);
            lstSpeak.Add(cat);

            foreach (var item in lstSpeak)
            {
                item.Speak();
            }
        }
    }
}
