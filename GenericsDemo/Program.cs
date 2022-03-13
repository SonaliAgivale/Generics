using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Find Max using Generics----------");

            // Testing max value in 3 different positions
            Console.WriteLine("Test case 1: " + TestCase.GetString(TestCase.IntTestCase1));
            MaximumNumber.FindIntMax(TestCase.IntTestCase1[0], TestCase.IntTestCase1[1], TestCase.IntTestCase1[2]);
            Console.WriteLine("Test case 2: " + TestCase.GetString(TestCase.IntTestCase2));
            MaximumNumber.FindIntMax(TestCase.IntTestCase2[0], TestCase.IntTestCase2[1], TestCase.IntTestCase2[2]);
            Console.WriteLine("Test case 3: " + TestCase.GetString(TestCase.IntTestCase3));
            MaximumNumber.FindIntMax(TestCase.IntTestCase3[0], TestCase.IntTestCase3[1], TestCase.IntTestCase3[2]);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("*******Float tests*******");
            TestCase.FloatTest();
            Console.ReadKey();
        }
    }
}
