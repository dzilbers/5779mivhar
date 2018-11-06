using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnonymousObject
{
    class MyClass
    {
        public int Id;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //PrintInfo("", typeof(MyClass));
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(new MyClass());
            //Console.WriteLine("-----------------------------------");
            //var anonymousObject = new { Id = 1234, Name = "Dani" };
            //PrintInfo("", anonymousObject.GetType());
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(anonymousObject);
            //Console.WriteLine("-----------------------------------");
            var obj1 = new { Id = 1234, Name = "Weizmann" };
            var obj2 = new { Id = 1234, Name = "Weizmann" };
            Console.WriteLine("hash: " + (obj1.GetHashCode() == obj2.GetHashCode()));
            Console.WriteLine("equals: " + (obj1.Equals(obj2)));
            Console.WriteLine("==: " + (obj1 == obj2));
            //PrintInfo("", obj1.GetType());
            //Console.WriteLine("-----------------------------------");
            //PrintInfo("", obj2.GetType());
            //Console.WriteLine("-----------------------------------");
        }

        static void PrintInfo(string suffix, Type type)
        {
            Console.WriteLine(suffix + "Type Name: " + type.Name);
            Console.WriteLine(suffix + "Base Type: ");
            if (type.BaseType == null)
                Console.WriteLine(suffix + suffix + "None");
            else
                PrintInfo(suffix + "  ", type.BaseType);
            Console.WriteLine(suffix + "Member Info:");
            MemberInfo[] members = type.GetMembers();
            foreach (var item in members)
                Console.WriteLine(suffix + "name: {0,-15} type: {2,-11} in: {1}",
                                  item.Name, item.DeclaringType.Name, item.MemberType);
        }

    }
}
