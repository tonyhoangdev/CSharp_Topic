using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            try
            {
                int[] arr = new int[] { 4, 5, 6, 8 };
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Exception!!");
            }

            Console.ReadKey();
        }
    }
}
