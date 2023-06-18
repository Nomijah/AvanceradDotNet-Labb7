using AvanceradDotNet_Labb7.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNet_Labb7_Tests
{
    public class CalcLogTests
    {
        [Fact]
        public void Print_Writes_The_Correct_Text_To_Console()
        {
            //Arrange
            var testLog = new CalcLog(5, 5, 10, "Addition");
            string expected = "5 + 5 = 10\n";

            //Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                testLog.Print();
                string actual = sw.ToString();

                //Assert
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void PrintWithDate_Writes_The_Correct_Text_To_Console()
        {
            //Arrange
            var testLog = new CalcLog(5, 5, 1, "Division");
            testLog.TimeCreated = "2023-01-01 12:00:00";
            string expected = "2023-01-01 12:00:00 5 / 5 = 1\n";

            //Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                testLog.PrintWithDate();
                string actual = sw.ToString();

                //Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
