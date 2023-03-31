using NUnit.Framework;
using System;

namespace se1tdd
{
    public class Tests
    {
        functions function;

        [SetUp]
        public void Setup()
        {
            function = new functions();
        }

        [Test]
        public void Test_add_1()
        {
            // Given = 
            string numbers = "1,2";
            int expected_value = 3;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_2()
        {
            // Given = 
            string numbers = "1,2,3";
            int expected_value = 6;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_3()
        {
            // Given = 
            string numbers = "2,3\n5";
            int expected_value = 10;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_4()
        {
            // Given = 
            string numbers = "//;\n1;2";
            int expected_value = 3;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }


        [Test]
        public void Test_add_5()
        {
            // Given = 
            string numbers = "//;\n1;3;-3";
            int expected_value = -1;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_6()
        {
            // Given = 
            string numbers = "//;\n1;3;2003";
            int expected_value = 4;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_7()
        {
            // Given = 
            string numbers = "//[***]\n1***2***3";
            int expected_value = 6;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }


        [Test]
        public void Test_add_8()
        {
            // Given = 
            string numbers = "//[*][%]\n1*3%3";
            int expected_value = 7;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }

        [Test]
        public void Test_add_9()
        {
            // Given = 
            string numbers = "//[***][;;]\n22;;13***20";
            int expected_value = 55;

            // When
            int result = function.Add(numbers);

            // Then
            Assert.AreEqual(expected_value, result);
        }
    }
}