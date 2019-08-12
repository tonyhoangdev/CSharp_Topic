using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KeThua
{
    class Animal
    {
        protected double weight;
        protected double height;
        protected static int legs;

        public Animal()
        {
            Console.WriteLine("Animal created");
        }

        ~Animal()
        {
            Console.WriteLine("Animal deleted");
        }

        public Animal(double w, double h, int l)
        {
            Console.WriteLine("Animal created");

            weight = w;
            height = h;
            legs = l;
        }

        public void Info()
        {
            Console.WriteLine(String.Format("weight: {0}, height: {1}, legs: {2}", weight, height, legs));
        }

    }

    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat created");
            weight = 400;
            height = 30;
            legs = 2;
        }

        ~Cat()
        {
            Console.WriteLine("Cat deleted");
        }

        public Cat(double w, double h, int l) : base(w, h, l)
        {
            Console.WriteLine("Cat created");
        }
        public new void Info() 
        {
            base.Info();
            Console.WriteLine(String.Format("weight2: {0}, height: {1}, legs: {2}", weight, height, legs));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat blackCat = new Cat();

            blackCat.Info();
        }
    }
}
