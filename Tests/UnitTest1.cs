using Xunit;
using TEST;

namespace Tests
{
    public class UnitTest1
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_Test()
        {
            int result = _calculator.Add(2, 3);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Subtract_Test()
        {
            int result = _calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_Test()
        {
            int result = _calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_Test()
        {
            double result = _calculator.Divide(10, 2);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}