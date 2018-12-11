using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DO;

namespace _DL
{
    public interface IDL
    {
        Student getStudent(int id);

        Course getCourse(int num);

        List<Course> getCoursesForStudent(int id);
    }
}
