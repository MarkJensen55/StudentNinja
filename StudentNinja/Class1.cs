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

        public Student() 
        {
            this.studentLevel = 0;
            this.studentRank = Rank.Beginner;
        }

        public void CompleteProgram()
        {
            studentLevel += 1;
            if (studentLevel >= 5)
            {
                studentRank = studentRank + 1;
                studentLevel = studentLevel -5;
            }

        }

        public void HelpAPeer()
        {
            studentLevel += 2;
            if (studentLevel >= 5)
            {
                studentRank = studentRank + 1;
                studentLevel = studentLevel -5;
            }

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
