using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DO;

namespace _DL
{
    class Data
    {
        internal static List<Student> students = new List<Student>();
        internal static List<Course> courses = new List<Course>();
        internal static List<StudentCourse> studCourses = new List<StudentCourse>();
        static Data()
        {
            students.Add(new Student { ID = 66200569, Name = "Uriel Erlich" });
            students.Add(new Student { ID = 305343931, Name = "Moshe Weizman" });
            students.Add(new Student { ID = 201530508, Name = "Roni Pakter" });
            students.Add(new Student { ID = 301269502, Name = "Avner Shechter" });

            courses.Add(new Course { Number = 153007, Name = "Windows System Miniproject" });
            courses.Add(new Course { Number = 123456, Name = "Infi B" });
            courses.Add(new Course { Number = 654321, Name = "Statistics" });

            studCourses.Add(new StudentCourse { StudentId = 66200569, CourseNum = 153007 });
            studCourses.Add(new StudentCourse { StudentId = 66200569, CourseNum = 123456 });
            studCourses.Add(new StudentCourse { StudentId = 66200569, CourseNum = 654321 });
            studCourses.Add(new StudentCourse { StudentId = 305343931, CourseNum = 153007 });
            studCourses.Add(new StudentCourse { StudentId = 305343931, CourseNum = 654321 });
            studCourses.Add(new StudentCourse { StudentId = 201530508, CourseNum = 153007 });
            studCourses.Add(new StudentCourse { StudentId = 301269502, CourseNum = 123456 });
        }
    }
}
