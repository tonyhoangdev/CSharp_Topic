using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Access modifiers: public, protected, private, internal, protected internal. 
// Constructor
// Properties
namespace OOP_Encapsulation
{
    class BankAccount
    {

        private double balance = 0;
        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
    }

    class Person
    {
        private int age;
        private string name;

        public Person()
        {
            Console.WriteLine("Hi there");
        }

        public Person(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AutoProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Person p = new Person();

            Person p2 = new Person("Tony");
            Console.WriteLine(p2.GetName());

            p2.Name = "Tony2";
            Console.WriteLine(p2.Name);

            p2.AutoProperty = "Auto Property";
            Console.WriteLine(p2.AutoProperty);

            Console.ReadKey();
        }
    }
}
