using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// Matrix Problems
    /// </summary>
    public static class MatrixProblems
    {

        /// <summary>
        /// Set matrix zeros : if a element in the matrix is zero 
        /// then set all the row elements and the column elements to zero
        /// </summary>
        /// <param name="M"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public static void SetMatrixZero(int[,] M, int rows, int cols)
        {
            if (M.Length <= 0)
                return;

            bool[] row = new bool[rows];
            bool[] col = new bool[cols];
            //Set the row array and col array 
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(M[i,j] == 0)
                    {
                        row[i] = true;
                        col[i] = true;
                    }
                }
            }
            //instead of 2 seperate loops as below we can club them with single loop.
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (row[i] || col[j])
                        M[i, j] = 0;
                }
            }


            ////Set row zeros
            //for (int i = 0; i < rows; i++)
            //{
            //    if (row[i] == true)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            M[i, j] = 0;
            //        }
            //    }
            //}
            ////Set col zeros
            //for(int i = 0; i < cols; i++)
            //{
            //    if (col[i] == true)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            M[i, j] = 0;
            //        }
            //    }                
            //}
        }
    }
}
