using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// LongestIncreasingSubSequence
    /// </summary>
    public static class LongestIncreasingSubSequence
    {
        /// <summary>
        /// LenghOfLIS
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LengthOfLIS(int[] A)
        {
            if (A == null || A.Length <= 0)
                return 0;

            int[] max = new int[A.Length];
            for (int i = 0; i < max.Length; i++)
                max[i] = 1;

            int result = 1;

            for(int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(A[i] > A[j])
                    {
                        max[i] = Math.Max(max[i], max[j] + 1);
                    }
                }

                result = Math.Max(max[i], result);
            }
            return result;
        }
    }
}
