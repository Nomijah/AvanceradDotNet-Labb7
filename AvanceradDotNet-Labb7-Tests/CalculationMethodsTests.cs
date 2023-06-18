using AvanceradDotNet_Labb7;

namespace AvanceradDotNet_Labb7_Tests
{
    public class CalculationMethodsTests
    {
        [Theory]
        [InlineData(4,5,9)]
        [InlineData(4.3,5.3,9.6)]
        [InlineData(104,7000,7104)]
        [InlineData(-10,20,10)]
        [InlineData(50.5,-50.5,0)]
        public void Add_Should_Return_Correct_Calculation(double a,
            double b, double expected)
        {
            double actual = CalculationMethods.Add(a,b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 5, 4)]
        [InlineData(8.9, 5.3, 3.6)]
        [InlineData(104, 7000, -6896)]
        [InlineData(-10, 20, -30)]
        [InlineData(50.5, -50.5, 101)]
        public void Subtract_Should_Return_Correct_Calculation(double a,
            double b, double expected)
        {
            double actual = CalculationMethods.Subtract(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 5, 45)]
        [InlineData(8.9, 5.3, 47.17)]
        [InlineData(104, 100, 10400)]
        [InlineData(-10, 20, -200)]
        [InlineData(-30, -5, 150)]
        public void Multiply_Should_Return_Correct_Calculation(double a,
            double b, double expected)
        {
            double actual = CalculationMethods.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(45, 5, 9)]
        [InlineData(10, 20, 0.5)]
        [InlineData(100, 100, 1)]
        [InlineData(-10, 2, -5)]
        [InlineData(-30, -5, 6)]
        public void Divide_Should_Return_Correct_Calculation(double a,
            double b, double expected)
        {
            double actual = CalculationMethods.Divide(a, b);

            Assert.Equal(expected, actual);
        }
    }
}