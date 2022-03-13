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

    //create test case int number
    static TestCase()
    {
        intTestCase1 = new int[] { 5, 3, 9 };
        intTestCase2 = new int[] { 0, 4, 3 };
        intTestCase3 = new int[] { 7, 5, 4 };
    }

    // Properties to get the test cases
    public static int[] IntTestCase1 => intTestCase1;
    public static int[] IntTestCase2 => intTestCase2;
    public static int[] IntTestCase3 => intTestCase3;

    
    public static string GetString<T>(T[] testCase)
    {
        return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
    }
    }
}
