using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
global using NUnit.Framework;

namespace se1
{
    internal class tests
    {
        public tests()
        {
            functions functions = new functions();

            Console.WriteLine(Test_add(functions));

        }
        
        [Test]
        static bool Test_add(functions functions)
        {
            // Given
            string numbers = "//[***][;;]\n22;;13***20";
            int expected_value = 55;
            int result;

            // When
            if (String.IsNullOrEmpty(numbers))
            {
                Console.WriteLine("empty string");
                return false;
            }

            result = functions.Add(numbers);

            // Then
            return result.Equals(expected_value);
        }
    }
}
