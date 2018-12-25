using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oldArray = { 2, 0, 6, 9, 1, 4, 3, 0, 1 };
            var newArray = from item in oldArray
                           where item % 2 == 0
                           select item * 2;
            Console.WriteLine("Before");
            foreach (var number in newArray)
                Console.Write(" {0}", number);
            Console.WriteLine();

            oldArray[2] = 8;

            Console.WriteLine("After");
            foreach (var number in newArray)
                Console.Write(" {0}", number);
            Console.WriteLine();

            if (oldArray.All(n => n % 2 == 0))
                Console.WriteLine("All are even :-)");
            else
                Console.WriteLine("Some are not even :-(");

            if (newArray.All(n => n % 2 == 0))
                Console.WriteLine("All are even :-)");
            else
                Console.WriteLine("Some are not even :-(");
        }
    }
}
