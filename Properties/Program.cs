using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.Number1);
            obj.Number1 = 8;
        }
    }

    public class MyClass
    {
        int number1;
        public int Number1
        {
            get  // int get() { ... }
            {
                Console.WriteLine("Getter");
                return number1;
            }
            internal set  // void set(int value) { ... }
            {
                Console.WriteLine("Setter");
                number1 = value;
            }
        }

        public int Number2 { get; set; }

    }
}
