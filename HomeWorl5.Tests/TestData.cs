using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    public class TestData
    {
        public static int[,] FindTheMinimumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
                _ => new int[,] { { } },
            };
        } 
        public static int[] FindExpectedTheMinimumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[] { 2, 1 },
                1 => new int[] { 2, 1 },
                _ => new int[] { },
            };
        }
    }
}
