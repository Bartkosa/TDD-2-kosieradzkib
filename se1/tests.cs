using NUnit.Framework;
using System;

namespace se1
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test_add()
        {
            // Given
            functions functions = new functions();
            string numbers = "//[***][;;]\n22;;13***20";
            int expected_value = 55;

            // When
            int result = functions.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }
    }
}
