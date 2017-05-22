using System;

namespace Experimental
{
    public static class MatrixRotation
    {        
        public static void RotateMatrix(int[,] matrix, int degree)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int[,] ret = new int[n, n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    ret[i, j] = matrix[n - j - 1, i];
                }
            }
            PrintMatrix(ret);
        }

        public static void PrintMatrix(int[,] mat)
        {
            int m = mat.GetLength(0);
            int n = mat.GetLength(1);
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(string.Format("{0}", (mat[i,j] + "   ")));
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Counts the number of negative numbers in a given sorted matrix
        /// 1. Start at the right upper corner and travers toward left
        /// </summary>
        /// <param name="M"></param>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int CountNegativeNumbersInSortedMatrix(int[,] M, int n, int m)
        {
            int i = 0, j = 0, count = 0;
            //int mLength = M.Length;
            while (j >= 0 && i < n)
            {
                if (M[i, j] < 0)
                {
                    count += j + 1;
                    i += 1;
                }
                else
                {
                    j -= 1;
                }
            }
            return count;
        }
    }
}
