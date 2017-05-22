using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// Search element in a Matrix
    /// </summary>
    public static class SearchElementInSortedMatrix
    {

        /// <summary>
        /// Floodfills the matrix
        /// </summary>
        /// <param name="A"></param>
        /// <param name="colour"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public static int[,] FloodFill(int[,] A, int colour, int m, int n)
        {
            if (A == null)
                return null;

            if (m >= 0 && m < A.GetLength(0) && n >= 0 && n < A.GetLength(1) && A[m, n] != colour)
            {
                A[m, n] = colour;
                FloodFill(A, colour, m, n + 1);
                FloodFill(A, colour, m + 1, n);
                FloodFill(A, colour, m - 1, n);
                FloodFill(A, colour, m, n - 1);
            }
            return A;
        }


        /// <summary>
        /// SearchElementInSortedRowsMatrix
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool SearchElementInSortedRowsMatrix(int[,] A, int target, int m, int n)
        {
            if (A == null)
                return false;
            if (m + 1  > A.GetLength(0) || n - 1 < 0)
                return false;
            if (target == A[m, n])
            {
                return true;
            }
            else if (target < A[m, n])
                return SearchElementInSortedRowsMatrix(A, target, m, n - 1);
            else if (target > A[m, n])
                return SearchElementInSortedRowsMatrix(A, target, m + 1, n);

            else
                return false;
        }


        /// <summary>
        /// searches if an element exists in the given sorted array
        /// returns true if exists or false if does'nt
        /// </summary>
        /// <param name="M"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="searchElement"></param>
        /// <returns></returns>
        public static bool IsElelementExistsInSortedMatrix(int[,] M, int rows, int cols, int searchElement)
        {
            int row = 0, col = cols-1;

            while(row < rows-1 && col >=0)
            {
                if (M[row, col] == searchElement)
                    return true;
                else if (M[row, col] > searchElement)
                    col--;
                else
                    row++;
            }
            return false;
        }

        /// <summary>
        /// returns number of zeros in a matrix
        /// </summary>
        /// <param name="M"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static int CountZerosInASortedMatrix(int[,]M, int rows, int cols)
        {
            int row = 0, col = cols - 1;
            int zeroCount = 0;
            while(row < rows -1 && col >= 0)
            {
                if (M[row, col] == 1)
                    col--;
                else
                {
                    zeroCount += col + 1;
                    row++;
                }
            }
            return zeroCount;
        }
    }
}
