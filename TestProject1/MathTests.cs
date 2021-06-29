// <copyright file="MathTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestProject1
{
    using DevSecOpsProject1;
    using Xunit;

    /// <summary>
    /// MathTests.
    /// </summary>
    public class MathTests
    {
        /// <summary>
        /// AdditionTests.
        /// </summary>
        [Fact]
        public void AdditionTest()
        {
            // Arrange

            // Act
            int result = Arithmetic.Add(2, 2);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
