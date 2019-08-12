using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Object
{
    class Dog
    {
        public int age;
        public string name;
    }

    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();

            Dog d1 = new Dog();
            d1.age = 3;
            d1.name = "Ngao";

            Console.WriteLine(d1.age);

            Console.ReadKey();
        }
    }
}
