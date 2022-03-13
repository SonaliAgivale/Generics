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

            //Testing max value in 3 different positions
            
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("*******Int Tests********");
            TestCase.IntTest();
            Console.WriteLine("*******Float tests*******");
            TestCase.FloatTest();
            Console.WriteLine("*******String Test*******");
            TestCase.StringTest();
            Console.ReadKey();
        }
    }
}
