using CodeShare.Examples;
using System;
using Xunit;

namespace CodeShare.Tests.Examples
{
    public class SquareRootTests
    {
        [Fact]
        public void SquareRoot_SqrtRoot2_WithRealNumerInput_ShouldFindTheSquare()
        {
            //Arrange
            var input = 5d;
            var expectedResult = Math.Sqrt(input);

            //Act
            var actualResult = SquareRoot.SqrtRoot2(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
