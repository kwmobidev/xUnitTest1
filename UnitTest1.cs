using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void xUnitWorks()
        {
            Assert.True(true);
        }

        [Fact]
        public void WhenAddTwoNumberThenSumIsCorrect()
        {
            var sum = 1 + 2;
            Assert.Equal(3, sum);
        }

        [Fact]
        public void WhenSubtractTwoNumberThenDifferenceIsCorrect()
        {
            var diff = 5 - 2;
            Assert.Equal(3, diff);
        }

    }
}
