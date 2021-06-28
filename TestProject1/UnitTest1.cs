using System;
using Xunit;
using DevSecOpsProject1;


namespace TestProject1
{
    public class MathTests
    {
        [Fact]
        public void AdditionTest()
        {
            //Arrange

            //Act
            int result = Arithmetic.Add(2, 2);

            //Assert
            Assert.Equal(4, result);
        }
    }
}
