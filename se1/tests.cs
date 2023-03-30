using NUnit.Framework;
using System;

namespace se1
{
    [TestFixture]
    public class CalculatorTests
    {
        functions function;
        [SetUp]
        public void Setup()
        {
            function = new functions();
        }

        [TestCase("//[***][;;]\n22;;13***20")]
        public void Test_add(string numbers)
        {
            // Given
            int expected_value = 55;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }
    }
}
