using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// NQueenProblem
    /// </summary>
    public static class NQueenProblem
    {
        public static int[] result;

        /// <summary>
        /// PlaceQueens
        /// </summary>
        /// <param name="row"></param>
        /// <param name="MazeSize"></param>
        public static void PlaceQueens(int row, int mazeSize)
        {
            for(int y = 0; y < mazeSize; y++)
            {
                if (canPlace(row, y))
                {
                    result[row] = y;

                    if(row == mazeSize -1)
                    {
                        Console.WriteLine("\nOrder Of " + mazeSize + " queens : ");
                        foreach (var t in result)
                            Console.Write(t + "\t");
                    }
                    PlaceQueens(row + 1, mazeSize);
                }
            }
        }

        // result[i]=j; means queen at i-th row is placed at j-th column.
        // Queens placed at (x1, y1) and (x2,y2)
        // x1==x2 means same rows, y1==y2 means same columns, |x2-x1|==|y2-y1| means
        // they are placed in diagonals.
        public static bool canPlace(int row, int col)
        {
            for(int x = 0; x < row; x++)
            {
                if((result[x] == col) || Math.Abs(x - row) == Math.Abs(result[x] - col))
                {
                    return false;
                }
            }            
            return true;
        }

        public static void TestPlaceQueens()
        {
            int n = 4;
            result = new int[n];
            PlaceQueens(0, n);
        }

    }
}
