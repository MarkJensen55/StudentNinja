using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNinja
{
    class Program
    {
        // exercise the student class for testing
        // build a collection of students 
        static void Main(string[] args)
        {
            
            // test set up & print of a sample student
            //var newStudent = new Student("Me");
            //newStudent.CompleteProgram();
            //newStudent.HelpAPeer();
            //newStudent.HelpAPeer();
            //newStudent.HelpAPeer();
            //Console.WriteLine(newStudent.StudentName + " has rank of: " + newStudent.StudentRank);
            //Console.ReadLine();

            var classList = new Dictionary<string, Student>();
            classList = MakeList();

            var testName = "Keonna";
            classList[testName].HelpAPeer();
            classList[testName].CompleteProgram();
            classList[testName].HelpAPeer();
            Console.WriteLine(classList[testName].StudentName + " is a " + classList[testName].StudentRank);
            Console.ReadLine();



        }

        // fake up the list of students for now
        static Dictionary <string, Student> MakeList()
        {
            var studentList = new Dictionary <string, Student>();

            studentList.Add("Nick", new Student("Nick"));
            studentList.Add("Justin", new Student("Justin"));
            studentList.Add("Keonna", new Student("Keonna"));
            studentList.Add("Johnathon", new Student("Johnathon"));
            studentList.Add("Mark", new Student("Mark"));
            studentList.Add("Seth", new Student("Seth"));

            return studentList;

        }
    }
    
}
