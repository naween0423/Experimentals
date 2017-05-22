using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// MaxSumSubArray
    /// </summary>
    public static class MaxSumSubArray
    {
        /// <summary>
        /// GetMaxSumSubArray
        /// </summary>
        /// <param name="A"></param>
        public static void GetMaxSumSubArray(int[] A)
        {
            if(A.Length <= 0)
            {
                return;
            }

            int maxSum = A[0];
            int maxSumStart = 0;
            int maxSumEnd = 0;
            int currentStart = 0;
            int currentSum = A[0];

            for(int i=1; i < A.Length; i++)
            {
                if(currentSum < 0)
                {
                    currentSum = A[i];
                    currentStart = i;
                }
                else
                {
                    currentSum += A[i];
                }

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumStart = currentStart;
                    maxSumEnd = i;
                }
            }
            Console.WriteLine("Max Sub sum is : {0} and it start at: {1} and ends at : {2}", maxSum, maxSumStart, maxSumEnd);
        }
    }
}
