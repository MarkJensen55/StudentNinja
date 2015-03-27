using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNinja
{
    // Student acheivement exercise for .net class
    public class Student
    {
        private int studentLevel = 0;
        private Rank studentRank = Rank.Beginner;

        // class contructor requires name
        public Student(string name) 
        {
            this.studentLevel = 0;
            this.studentRank = Rank.Beginner;
            this.StudentName = name;
        }

        // each time a student completes a program they uplevel by one point
        // if level is 5 they inrcease rank & level is reset
        // don't increase rank if already ninja
        public void CompleteProgram()
        {
            studentLevel += 1;
            if (studentLevel >= 5)
            {
                if (studentRank != Rank.Ninja)
                {
                    studentRank = studentRank + 1;
                }
                studentLevel = studentLevel -5;
            }

        }

        // each time a student helps a peer they uplevel by two points
        // if level is 5 they inrcease rank & level is reset
        // don't increase rank if already ninja
        public void HelpAPeer()
        {
            studentLevel += 2;
            if (studentLevel >= 5)
            {
                if (studentRank != Rank.Ninja)
                {
                    studentRank = studentRank + 1;
                    studentLevel = studentLevel - 5;
                }
            }

        }

        public string StudentName
        {
            get;
            private set;
        }

        public Rank StudentRank
        {
            get { return studentRank; }
         
        }
    }



    public enum Rank
    {
        Beginner,
        Grasshopper,
        Journeyman,
        RockStar,
        Ninja,
        Jedi
    }
}
