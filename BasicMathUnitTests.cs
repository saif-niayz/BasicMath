using System;
using Xunit;
using BasicMathLib;

namespace BasicMathTests
{
    public class BasicMathUnitTests
    {
        private readonly BasicMath math = new BasicMath();

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            double result = math.Add(5.0, 3.0);
            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            double result = math.Subtract(10.0, 4.0);
            Assert.Equal(6.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            double result = math.Multiply(3.0, 4.0);
            Assert.Equal(12.0, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            double result = math.Divide(10.0, 2.0);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => math.Divide(10.0, 0));
        }
    }
}
