using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNinja
{

    // create a list of students in a class or group
    public class StudentList
    {
        private Dictionary<string, Student>  classList = new Dictionary <string, Student>();

        // class must have a name
        public StudentList (string name)
        {
            this.ListName = name;
        }

        //check to see if student is in the list using student's name
        public bool InList(string name)
        {
            var xx = new Student(" ");
            return  classList.TryGetValue(name, out xx);
        }

        // check to see if student is in the list using student
        public bool InList(Student InStudent)
        {
            var xx = new Student(" ");
            return classList.TryGetValue(InStudent.StudentName, out xx);
        }

        public string ListName
        {
            get;
            private set;
        }
            
    }
}
