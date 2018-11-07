using System;
using System.Reflection;

namespace ExtensionFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            int i = str.ToInt();
            Console.WriteLine(i);
            //DateTime.Now.ToStringProperty();
            new { Id = 123, Name = "Vazana" }.ToStringProperty();
        }
    }

    static class MyTools
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }

        /// <summary>
        /// פונקציית ההרחבה האהובה עליי
        /// </summary>
        /// <typeparam name="T">Generic - any type :=)</typeparam>
        /// <param name="t">this is the context object</param>
        public static void ToStringProperty<T>(this T t)
        {
            string str = "";
            foreach (var item in t.GetType().GetProperties())
            {
                str += "\n" + item.Name + ": " + item.GetValue(t, null);
            }
            Console.WriteLine(str);
        }
    }

}
