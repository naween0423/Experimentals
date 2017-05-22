using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// No of Islands
    /// </summary>
    public class NoOfIsLands
    {
        /// <summary>
        /// Return No of Islands
        /// </summary>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int GetNumBerIsLands(int[,] M)
        {
            int rows = M.GetLength(0);
            int cols = M.GetLength(1);
            int MaxIsLand = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (M[i, j] == 1)
                    {
                        if ((i == 0 || M[i - 1, j] == 0) &&
                            (j == 0 || M[i, j - 1] == 0))
                            MaxIsLand++;
                    }
                }             
            }
            return MaxIsLand;
        }
    }
}
