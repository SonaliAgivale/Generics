﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class TestCase
    {
        private static readonly int[] intTestCase1;
        private static readonly int[] intTestCase2;
        private static readonly int[] intTestCase3;
        private static readonly float[] floatTestCase1;
        private static readonly float[] floatTestCase2;
        private static readonly float[] floatTestCase3;
        private static readonly string[] stringTestCase1;
        private static readonly string[] stringTestCase2;
        private static readonly string[] stringTestCase3;

        //create test case int number
        static TestCase()
    {
        intTestCase1 = new int[] { 5, 3, 9 };
        intTestCase2 = new int[] { 0, 4, 3 };
        intTestCase3 = new int[] { 7, 5, 4 };
        floatTestCase1 = new float[] { 1.3f, 2.5f, 5.7f };
        floatTestCase2 = new float[] { 2.3f, 7.5f, 5.7f };
        floatTestCase3 = new float[] { 9.3f, 8.5f, 5.7f };
        stringTestCase1 = new string[] { "Apple", "Banana", "Chocolate" };
        stringTestCase2 = new string[] { "Choco", "Chocolate", "Banana" };
        stringTestCase3 = new string[] { "Zoom", "Zap", "Zip" };
        }

    // Properties to get the test cases
    public static int[] IntTestCase1 => intTestCase1;
    public static int[] IntTestCase2 => intTestCase2;
    public static int[] IntTestCase3 => intTestCase3;

    
    public static string GetString<T>(T[] testCase)
    {
        return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
    }
        public static void FloatTest()
        {
            Console.WriteLine("Test case 1: " + GetString(floatTestCase1));
            MaximumNumber.FloatMax(floatTestCase1[0], floatTestCase1[1], floatTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(floatTestCase2));
            MaximumNumber.FloatMax(floatTestCase2[0], floatTestCase2[1], floatTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(floatTestCase3));
            MaximumNumber.FloatMax(floatTestCase3[0], floatTestCase3[1], floatTestCase3[2]);
        }
        public static void StringTest()
        {
            Console.WriteLine("Test case 1: " + GetString(stringTestCase1));
            MaximumNumber.StringMax(stringTestCase1[0], stringTestCase1[1], stringTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(stringTestCase2));
            MaximumNumber.StringMax(stringTestCase2[0], stringTestCase2[1], stringTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(stringTestCase3));
            MaximumNumber.StringMax(stringTestCase3[0], stringTestCase3[1], stringTestCase3[2]);
        }
    }
}
