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
                2 => new int[,] { { } },
            };
        }
        public static int[,] FindTheMaximumNumberInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
                2 => new int[,] { { } },
            };
        }
        public static int[,] FindTheMinimumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
                2 => new int[,] { { } },

            };
        }
        public static int[,] FindTheMaximumIndexInAnArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 9, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
                2 => new int[,] { { } },

            };
        }
        public static int[,] FindFearOfNeighborsTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 0, 2, 3 }, { 1, -5, 6 }, { 1, 8, 8 } },
                1 => new int[,] { { 1 }, { 1 }, { 0 } },
                2 => new int[,] { { } },
                3 => new int[,] { {10, 5 },
                                  {5,10 } },
                4 => new int[,] { {1, 2, 3 },
                                  {4, 5, 6 },
                                   { 7, 8, 9 }},

            };
        }
        public static int[,] TransposeMatrixTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 },
                                { 0, 2, 3 },
                                { 1, -5, 6 }},

                1 => new int[,] { { 1 },{ 1 },
                                  { 1 },{ 1 }},

                2 => new int[,] { { } },
                3 => new int[,] { { 1 } },


            };
        }
        public static int[,] TransposeMatrixExpect(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 1 },
                                  { 2, 2, -5 },
                                  { 3, 3, 6 }},
                1 => new int[,] { { 1 },{ 1 },
                                  { 1 },{ 1 }},
                2 => new int[,] { { } },
                3 => new int[,] { { 1 } },

            };
        }

    }
}
