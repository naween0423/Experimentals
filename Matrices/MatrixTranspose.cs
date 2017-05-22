using System;

namespace Experimental
{
    class MatrixTranspose
    {
        int[,] _a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
        
        /// <summary>
        /// Inplace Matrix transpose
        /// </summary>
        /// <param name="M"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static void InPlaceMatrixTranspose(int[,] M, int m, int n)
        {
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j< n; j ++)
                {
                    int data = M[i, j];
                    M[i, j] = M[j, i];
                    M[j, i] = data;
                }
            }
        }

        /// <summary>
        /// Transpose of a matrix using extra space
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static void MatricTransposeFunc(int[,] a, int m, int n)
        {
            m = 4; n = 2;

            PrintMatrix(a);
            var b = new int[4, 2];
            for (var i = 0; i < m; i++)
            {
                for(var j = 0; j < n; j++)
                {
                    b[i,j] = a[j,i];
                }
            }
            PrintMatrix(b);
        }

        public static void PrintMatrix(int[,] m)
        {
            var r = m.GetLength(0);
            var c = m.GetLength(1);
            Console.WriteLine("\t######Printing Given Matrix#####\t\n");
            for(var i =0; i <= r-1; i++)
            {
                for(var j = 0; j <= c-1; j++)
                {
                    Console.Write("{0}\t", m[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
