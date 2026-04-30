using Xunit;
using TEST;

namespace Tests
{
    public class UnitTest1
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void 더하기_테스트()
        {
            int result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void 빼기_테스트()
        {
            int result = _calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void 곱하기_테스트()
        {
            int result = _calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void 나누기_테스트()
        {
            double result = _calculator.Divide(10, 2);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void 나누기_0으로나누면_예외발생()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}