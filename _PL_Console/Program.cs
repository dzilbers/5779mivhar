using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _BO;
using _BL;

namespace _PL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL();
            int id = 66200569;
            Student stud = bl.getStudent(id);
            Console.WriteLine("Courses for {0}:", stud.Name);
            foreach (var c in stud.Courses)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
