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
        { }

        public Animal(double w, double h, int l)
        {
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
            weight = 400;
            height = 30;
            legs = 2;
        }

        public Cat(double w, double h, int l) : base(w, h, l)
        {

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
