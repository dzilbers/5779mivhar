using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dad
    {
        static int oops()
        {
            Console.WriteLine("Dad init");
            return 18;
        }

        protected int f1 = oops();
        public Dad(int n)
        {
            Console.WriteLine("Dad: " + f1);
            f1 = n;
        }

        protected int f3 = 1;
    }

    class Son : Dad
    {
        static int oops()
        {
            Console.WriteLine("Son init");
            return 28;
        }
        int f2 = oops();

        int f3 = 2;

        public Son(int n, int m) : base(n)
        {
            Console.WriteLine("Son: " + f1 + " : " + f2);
            f2 = m;
            base.f3 = f3;
        }
    }

    class Inheritance
    {
        public static void Main(string[] args)
        {
            Dad obj = new Son(31, 32);
            Console.WriteLine("Boom");
            Son obj3 = obj is Son ? (Son)obj : null;
            Son obj2 = obj as Son;

        }
    }
}
