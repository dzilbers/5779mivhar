using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPrinter printer = new MyPrinter();
            User u1 = new User("Meir", printer);
            User u2 = new User("Shlomi", printer);
            //printer.PageOver();
            Console.WriteLine("Please enter pages to print:");
            int x = int.Parse(Console.ReadLine());
            printer.Print(x);

        }
    }
}
