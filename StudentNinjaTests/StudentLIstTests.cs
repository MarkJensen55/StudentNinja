using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNinja;
using Xunit;

namespace StudentNinjaTests
{
    public class StudentLIstTests
    {
        [Fact]
        public void InListShouldReturnFalseOnEmptyList()
        {
            var testStudent = new Student("My name is Test");
            var testLIst = new StudentList("Econ 101");

            Assert.False(testLIst.InList("My name is Test"));
            Assert.False(testLIst.InList(testStudent));

        }

        [Fact]
        public void ListNamePropertyIsReturned()
        {
            var testList = new StudentList("Another Class");

            Assert.Equal("Another Class", testList.ListName);
        }

        [Fact]
        public void InListMethodWithStudentName()
        {
            var testList = new StudentList("Econ 101");

            testList.Add(new Student("Nick"));
            testList.Add(new Student("Justin"));
            testList.Add(new Student("Keonna"));
            testList.Add(new Student("Johnathon"));
            var secondStudent = new Student("That Guy");
            testList.Add(secondStudent);
            testList.Add(new Student("Mark"));
            testList.Add(new Student("Seth"));

            Assert.True(testList.InList("Keonna"));
            Assert.False(testList.InList("Keona"));
            Assert.True(testList.InList(secondStudent));


        }

    }
}
