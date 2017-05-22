using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// PrintAllPathsFromTopLeftToBottomRight
    /// </summary>
    public class PrintAllPathsFromTopLeftToBottomRight
    {
        public int rowCount = 5;
        public int colCount = 5;

        static int[,] A = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
        //static int[,] A = { { 1, 2 }, { 3, 4 } };

        /// <summary>
        /// PrintAllPaths
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <param name="path"></param>
        public void PrintAllPaths(int currentRow, int currentCol, string path)
        {
            if(currentRow == rowCount -1)
            {
                for(int i = currentCol; i < colCount; i++)
                {
                    path += " -> " + A[currentRow,i];
                }
                Console.WriteLine(path);
                return;
            }
            if(currentCol == colCount -1)
            {
                for(int i = currentRow; i < rowCount; i++)
                {
                    path += " -> " + A[i,currentCol];
                }
                Console.WriteLine(path);
                return;
            }

            path = path + " -> " + A[currentRow,currentCol];
            PrintAllPaths(currentRow + 1, currentCol, path);
            PrintAllPaths(currentRow, currentCol + 1, path);       

        }

        /// <summary>
        /// PrintTopLeftToBottomRight
        /// </summary>
        public void PrintTopLeftToBottomRight()
        {
            string path = "";
            PrintAllPaths(0, 0, path);
        }
    }
}
