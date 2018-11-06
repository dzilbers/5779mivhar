using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyClass
    {
        int[] numbers = Enumerable.Range(1, 20).ToArray<int>();
        public string this[double index]
        {
            get
            {
                if (index >= numbers.Length)
                    index = 19.0;
                if (index < 0)
                    index = 0.0;
                return "N=" + numbers[(int)index];
            }
            set
            {
                numbers[(int)index] = value.Length;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            Console.WriteLine(obj[17.5]);
            obj[5.9] = "Perlov Shlomo Chaim";
            Console.WriteLine(obj[5.9]);
        }
    }
}
