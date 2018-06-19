using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DaHinh
{
    abstract class Animal
    {
        public abstract void Speak();
  //      {
 //           Console.WriteLine("Animal's speaking..");
  //      }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat's speaking..");
        }
    }
    
    class Dog : Animal
        {
        public override void Speak()
        {
            Console.WriteLine("Dog's speaking..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Speak();
            dog.Speak();

        }
    }
}
