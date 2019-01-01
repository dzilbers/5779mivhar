using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqXml
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student() {Id = 1, FirstName = "Yossi", LastName="Ivry", Age = 16},
            new Student() {Id = 2, FirstName = "Yanki", LastName="Ivry", Age = 17},
            new Student() {Id = 3, FirstName = "Avi", LastName="Ivry", Age = 18},
            new Student() {Id = 4, FirstName = "Yitzi", LastName="Ivry", Age = 19},
            new Student() {Id = 5, FirstName = "Dudi", LastName="Yehudi", Age = 20}
        };

        static void Main(string[] args)
        {
            XmlStudents manager = new XmlStudents();
            manager.SaveStudents();
        }
    }
}
