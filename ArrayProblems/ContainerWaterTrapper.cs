using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Container water trapper class
    /// From : http://www.geeksforgeeks.org/trapping-rain-water/
    /// Solution from : https://discuss.leetcode.com/topic/5125/sharing-my-simple-c-code-o-n-time-o-1-space/2
    /// </summary>
    public static class ContainerWaterTrapper
    {
        /// <summary>
        /// Gets max container water
        /// </summary>
        /// <param name="A"></param>
        public static void GetMaxContainerWater(int[] A)
        {
            if (A == null || A.Length <= 0)
                return;

            int left = 0;
            int right = A.Length - 1;
            int maxLeft = 0;
            int maxRight = 0;
            int result = 0;

            while(left <= right)
            {
                if(A[left] <= A[right])
                {
                    if (A[left] >= maxLeft)
                        maxLeft = A[left];
                    else
                    {
                        result += maxLeft - A[left];
                    }
                    left++;
                }
                else
                {
                    if (A[right] >= maxRight)
                        maxRight = A[right];
                    else
                    {
                        result += maxRight - A[right];
                    }
                    right--;
                }                
            }
            Console.WriteLine("Max water trapper is : {0}", result);
        }
    }
}
