﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class MaximumNumber
    {
        public static void FindIntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num1}");
            else if (num2.CompareTo(num3) >= 0)
                Console.WriteLine($"Max value is: {num2}");
            else
                Console.WriteLine($"Max value is: {num3}");
        }
    }
}