global using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1
{
    public class functions
    {
        static void Main(string[] args)
        {
        }

        public int Add(string numbers)
        {
            string[] delimeters =  { ",", "\n"};
            var results = numbers.Split(',', '\n');
            int res = 0;
            bool are_negatives = false;
            string string_delimeter;

            if (numbers[0] == '/' && numbers[1] == '/')
            {
                int i = 2, j;
                while (numbers[i]=='[') {
                    string_delimeter = "";
                    for (j=i+1; j<numbers.Length; j++)
                    {
                        if (numbers[j] == ']')
                        {
                            break;
                        }
                        string_delimeter += numbers[j];
                    }
                    i = j+1;
                    Array.Resize(ref delimeters, delimeters.Length + 1);
                    delimeters[delimeters.Length - 1] = string_delimeter;
                }

                numbers = numbers.Substring(i+1);
                results = numbers.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            }
            
            for(int i=0; i<results.Length; i++)
            {
                if(int.Parse(results[i])<0)
                {
                    if (!are_negatives)
                    {
                        are_negatives = true;
                        Console.WriteLine("negatives not allowed");
                    }
                    Console.WriteLine(results[i]);
                }

                if(int.Parse(results[i]) < 1000)
                    res += int.Parse(results[i]);
            }

            if(are_negatives)
            {
                return -1;
            }

            return res;
        }
    }
}
