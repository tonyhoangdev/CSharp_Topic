using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DaHinh
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }

        public virtual void Draw()
        {
            Console.WriteLine("Base Draw");
        }

    }

    class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("Circle Created");
        }

        public override void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    // Lop truu tuong
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

            Shape s = new Shape();
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();

            s.Draw();
            s1.Draw();
            s2.Draw();
        }
    }
}
