using AvanceradDotNet_Labb7.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace AvanceradDotNet_Labb7_Tests
{
    public class LogStackTests
    {
        [Fact]
        public void WriteLogsToFile_Expect_Lines_Written_To_File()
        {
            // Arrange
            CalcLog test1 = new CalcLog(5, 5, 10, "Addition", "2000-01-01 00:00:00");
            CalcLog test2 = new CalcLog(5, 6, 11, "Addition", "2000-01-01 00:00:00");
            LogStack.AddToLog(test1);
            LogStack.AddToLog(test2);
            int expected = 3;

            // Act
            LogStack.WriteLogsToFile("C:\\Users\\pette\\source" +
                "\\repos\\AvanceradDotNetLabb7\\AvanceradDotNet-Labb7-Tests" +
                "\\LogStackTestFile.txt");
            StreamReader sr = new StreamReader("C:\\Users\\pette\\source" +
                "\\repos\\AvanceradDotNetLabb7\\AvanceradDotNet-Labb7-Tests" +
                "\\LogStackTestFile.txt");
            string[] linesAfter = sr.ReadToEnd().Split("\n");
            int actual = linesAfter.Length;
            sr.Close();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetLogsFromFile_Expect_Correct_Data_Fetched()
        {
            // Arrange
            CalcLog expected = new CalcLog(5, 5, 10, "Addition", "2000-01-01 00:00:00");

            // Act
            LogStack.GetLogsFromFile("C:\\Users\\pette\\source" +
                "\\repos\\AvanceradDotNetLabb7\\AvanceradDotNet-Labb7-Tests" +
                "\\LogStackTestFile.txt");
            CalcLog actual = LogStack.logs.First();

            Assert.Equal(expected.First, actual.First);
            Assert.Equal(expected.Second, actual.Second);
            Assert.Equal(expected.Result, actual.Result);
            Assert.Equal(expected.CalculationMethod, actual.CalculationMethod);
            Assert.Equal(expected.TimeCreated, actual.TimeCreated);
        }
    }
}
