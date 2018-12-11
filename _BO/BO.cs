using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BO
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
