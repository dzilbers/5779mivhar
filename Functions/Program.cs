using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj; // = new MyClass { Number = 7 };
            MyClass.values(out obj);
            Console.WriteLine(obj.Number);
        }
    }

    class MyClass
    {
        public int Number = 0;
        public static void values(out MyClass parm)
        {
            //parm.Number = 8;
            //Console.WriteLine(parm.Number);
            parm = new MyClass { Number = 10 };
            parm.Number = 8;
            Console.WriteLine(parm.Number);
            Print("asdasd", 1, 2, 3, 4, new MyClass());
            Named(1, f3: 8, f2: 10);
        }

        public static void Print(string format, params object[] parms)
        {

        }
        public static void Named(int f1, int f2, int f3, int f4 = 0)
        {

        }

    }

}
