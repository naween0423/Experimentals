using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.DynamicProgramming
{
    /// <summary>
    /// Climbing steps
    /// </summary>
    public static class ClimbingSteps
    {
        /// <summary>
        /// Number Of Ways
        /// </summary>
        /// <param name="numberOfStems"></param>
        /// <param name="ways"></param>
        /// <returns></returns>
        public static int NumberOfWays(int numberOfSteps, int ways)
        {
            int[] memo = new int[numberOfSteps + 1];
            return GetNumberOfWays(numberOfSteps, ways, memo);
        }

        /// <summary>
        /// GetNumberOfWays
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public static int GetNumberOfWays(int i, int n, int []memo)
        {
            if (i > n)
                return 0;

            if (i == n)
                return 1;
            if (memo[i] > 0)
                return memo[i];

            memo[i] = GetNumberOfWays(i + 1, n, memo) + GetNumberOfWays(i + 2, n, memo);
            return memo[i];
        }

    }
}
