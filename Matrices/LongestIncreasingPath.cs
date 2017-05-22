using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Matrices
{
    /// <summary>
    /// Longest Increasing Path
    /// </summary>
    public class LongestIncreasingPathClass
    {
        //up, down, left, right
        public int[] dx = { -1, 1, 0, 0 };
        public int[] dy = { 0, 0, -1, 1 };

        public int LongestIncreasingPath(int[,] M)
        {
            if (M == null || M.GetLength(0) == 0 || M.GetLength(1) == 0)
                return 0;

            int[,] Mem = new int[M.GetLength(0), M.GetLength(1)];
            int longest = 0;

            for(int i=0; i < M.GetLength(0); i++)
            {
                for(int j =0;  j<M.GetLength(1); j++)
                {
                    longest = Math.Max(longest, Dfs(M, i, j, Mem));
                }
            }

            return longest;
        }

        /// <summary>
        /// Depth first search in a Matrix
        /// </summary>
        /// <param name="M"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="Mem"></param>
        /// <returns></returns>
        public int Dfs(int[,] M, int i, int j, int[,] Mem)
        {
            if (Mem[i, j] != 0)
                return Mem[i, j];

            for(int m = 0; m < 4; m++)
            {
                int x = i + dx[m];
                int y = j + dy[m];

                if(x >= 0 && y >= 0 && x<M.GetLength(0) && y<M.GetLength(1) && M[x,y] > M[i,j])
                {
                    Mem[i, j] = Math.Max(Mem[i, j], Dfs(M, x, y, Mem));
                }
            }

            return ++Mem[i, j];
        }

    }
}
