using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linqXml
{
    class XmlStudents
    {
        XElement studentRoot;
        string path = @"students.xml";
        public XmlStudents()
        {
            studentRoot = new XElement("students");
        }

        public void SaveStudents()
        {
            studentRoot.Save(path);
        }

        public void LoadStudents()
        {
            studentRoot = XElement.Load(path);
        }

        XElement createStudent(Student item)
        {
            //XElement id = new XElement("id", item.Id);

            //XElement firstName = new XElement("firstName", item.FirstName);
            //XElement lastName = new XElement("lastName", item.LastName);

            //XElement name = new XElement("name", firstName, lastName);

            //XElement student = new XElement("student", id, name);

            //return student;

            return new XElement("student",
                        new XElement("id", item.Id),
                        new XElement("name",
                           new XElement("firstName", item.FirstName),
                           new XElement("lastName", item.LastName)
                        )
                      );
        }
    }
}
