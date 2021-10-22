using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    public class TestData
    {
        public static int[,] FindTheMinimumNumberInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
            };
        } 
        public static int[,] FindTheMaximumNumberInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
            };
        } 
        public static int[,] FindTheMinimumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
            };
        } 
        public static int[,] FindTheMaximumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
            };
        }
        public static int[,] FindFearOfNeighborsTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 8, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
            };
        } 
        public static int[,] TransposeMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, 
                                { 0, 2, 3 }, 
                                { 1, -5, 6 }},
                1 => new int[,] { { 1 },    
                                  { 1 }, },
            };
        } 
        public static int[,] TransposeMatrixExpect(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 1 },
                                  { 2, 2, -5 },
                                  { 3, 3, 6 }},
                1 => new int[,] { { 1 },
                                  { 1 }, },
            };
        } 
        
    }
}
