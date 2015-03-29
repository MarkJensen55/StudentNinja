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

    }
}
