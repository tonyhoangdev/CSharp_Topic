using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generics
{
    // Generic classes
    class Stack2<T>
    {
        int index = 0;
        T[] innerArray = new T[100];
        public void Push(T item)
        {
            innerArray[index++] = item; 
        }
        public T Pop()
        {
            return innerArray[--index];
        }

        public T Get(int k)
        {
            return innerArray[k];
        }
    }


    class Program
    {
        // Generic methods
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            // Generic methods
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);

            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);

            // Generic classes
            Stack2<int> stackInt = new Stack2<int>();
            stackInt.Push(3);
            stackInt.Push(7);
            stackInt.Push(6);
            Console.WriteLine(stackInt.Get(2));

            Stack2<string> stackString = new Stack2<string>();

            // Collections generic
            List<int> lstInt = new List<int>();
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            SortedList<int, string> sortList = new SortedList<int, string>();
            Stack<int> stackCollection = new Stack<int>();
            Queue<int> queueCollection = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            // Collection non-generic
            ArrayList arrayList = new ArrayList();
            SortedList sortedList = new SortedList();
            Stack stack = new Stack();
            Queue queue = new Queue();
            Hashtable hashtable = new Hashtable();
            BitArray bitArray = new BitArray(9);


            // List<T>
            List<int> lstT = new List<int>();
            lstT.Add(12);
            lstT.Add(34);
            lstT.Add(43);
            lstT.Add(63);
            lstT.Add(45);
            lstT.RemoveAt(1);

            Console.WriteLine("List:" + lstT.Capacity);
            for (int i = 0; i < lstT.Count; i++)
            {
                Console.WriteLine(lstT[i]);
            }

            lstT.Sort();
            Console.WriteLine("Sorted List:");
            for (int i = 0; i < lstT.Count; i++)
            {
                Console.WriteLine(lstT[i]);
            }

            // SortedList<K, V>
            SortedList<string, int> sortedLists = new SortedList<string, int>();
            sortedLists.Add("Tony", 10);
            sortedLists.Add("Mobi", 20);
            sortedLists.Add("Navi", 30);
            sortedLists.Add("Sophi", 40);
            sortedLists.Add("Noti", 80);
            sortedLists.Add("Hapy", 50);
            sortedLists.Remove("Navi");
            
            Console.WriteLine("SortedList<K,V>:" + sortedLists.Capacity);
            foreach (string item in sortedLists.Keys)
            {
                Console.WriteLine(item + ": " + sortedLists[item]);
            }
            Console.WriteLine("SortedList<K,V> count:" + sortedLists.Count);

            // BitArray
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.Set(3, true);

            ba1.Set(2, false);
            ba2.Set(3, true);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());

            // Stack<T>
            Stack<int> s = new Stack<int>();
            s.Push(12);
            s.Push(34);
            s.Push(43);
            s.Push(63);
            s.Push(45);
            Console.WriteLine("Stack: ");
            foreach (int item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCount: " + s.Count);
            Console.WriteLine("Top: " + s.Peek());
            Console.WriteLine("Pop: " + s.Pop());

            Console.WriteLine("Stack: ");
            foreach (int item in s)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCount: " + s.Count);

            // Queue<T>
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(15);
            q.Enqueue(10);
            q.Enqueue(2);

            Console.WriteLine("Queue: ");
            foreach (int item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCount: " + q.Count);
            Console.WriteLine("Dequeue: " + q.Dequeue());

            Console.WriteLine("Queue: ");
            foreach (int item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCount: " + q.Count);

            // Dictionary<K, V>
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("One", 1);
            d.Add("Two", 2);
            d.Add("Three", 3);
            d.Remove("One");

            Console.WriteLine("Dictionary: ");
            foreach (string item in d.Keys)
            {
                Console.WriteLine(item + ": " + d[item]);
            }
            Console.WriteLine("Count: " + d.Count);

            // HashSet<T>
            HashSet<int> hs = new HashSet<int>();
            hs.Add(5);
            hs.Add(4);
            hs.Add(2);
            hs.Add(67);

            Console.WriteLine("HashSet: ");
            foreach (int item in hs)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Count: " + hs.Count);

            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(5);
            hs2.Add(2);
            Console.WriteLine("{5, 2} is a subset of {5, 4, 2, 67}: " + hs2.IsSubsetOf(hs));

            Console.ReadKey();
        }

        static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + ": ");
            for (int i = 0; i < ba.Length; i++)
            {
                Console.Write(ba.Get(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
