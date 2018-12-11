using _DO;
using System.Collections.Generic;
using System.Linq;

namespace _DL
{
    sealed class DL : IDL
    {
        static readonly DL instance = new DL();
        DL() { }
        static DL() { }

        public static DL Instance { get { return instance; } }

        public Student getStudent(int id)
        {
            return (from stud in Data.students
                    where stud.ID == id
                    select new Student { ID = stud.ID, Name = stud.Name }).FirstOrDefault();
        }
        public Course getCourse(int num)
        {
            return (from c in Data.courses
                    where c.Number == num
                    select new Course { Number = c.Number, Name = c.Name }).FirstOrDefault();
        }

        public List<Course> getCoursesForStudent(int id)
        {
            return (from sc in Data.studCourses
                    where sc.StudentId == id
                    from c in Data.courses
                    where c.Number == sc.CourseNum
                    select new Course { Number = c.Number, Name = c.Name }).ToList();
        }
    }
}
