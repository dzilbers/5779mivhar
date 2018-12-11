using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _DL;

namespace _BL
{
    public class BL
    {
        IDL dl = _DL.Factory.getDL("data"); // DL.Instance; // new DL();

        public _BO.Student getStudent(int id)
        {
            _DO.Student data = dl.getStudent(id);
            _BO.Student stud = new _BO.Student { ID = data.ID, Name = data.Name };
            stud.Courses = (from c in dl.getCoursesForStudent(id)
                            select new _BO.Course { Number = c.Number, Name = c.Name }
                            ).ToList();
            return stud;
        }
    }
}
