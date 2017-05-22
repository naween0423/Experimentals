using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    public static class MatrixSpiralTraversal
    {
        /// <summary>
        /// Prints a Matrix in spiral
        /// </summary>
        /// <param name="M"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public static void PrintSpiralTraversal(int[,] M, int rows, int cols)
        {
            if (M.Length <= 0)
                return;
                        
            int rStart = 0, rEnd = rows - 1;
            int cStart = 0, cEnd = cols - 1;

            while(rStart < rEnd && cStart < cEnd)
            {
                //Print Left to Right
                for(int i = rStart; i < cEnd; i ++)
                {
                    Console.Write(M[rStart, i] + "/t");
                }
                //right Print top to right bottom
                for(int i = rStart + 1; i < rEnd; i++)
                {
                    Console.Write(M[i, cEnd] + "/t");
                }
                if (rStart + 1 <= rEnd)// if Matrix contains Only one Row
                {
                    //print right bottom to left bottom
                    for (int i = cEnd - 1; i > cStart; i--)
                    {
                        Console.Write(M[rEnd, i] + "/t");
                    }
                }

                if(cStart + 1 <= cEnd) // if Matrix contains onlt one column.
                {
                    //print left bottom to left top
                    for(int i = rEnd + 1; i > rStart; i--)
                    {
                        Console.Write(M[i, cStart] + "/t");
                    }
                }

                rStart++;
                rEnd--;
                cStart++;
                cEnd--;
            }            
        }
    }
}
