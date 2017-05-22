using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Container with maxium water class
    /// </summary>
    public static class ContainerWithMaxWater
    {
        /// <summary>
        /// From : http://qa.geeksforgeeks.org/3808/maximum-area-of-water-that-can-be-contained
        /// Get Max water
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static void GetMaxWater(int[] A)
        {
            if (A == null || A.Length <= 0)
                return;

            int i = 0;
            int j = A.Length - 1;
            int minHeight = 0;
            int area = 0;
            int maxWater = 0;
            while(i < j)
            {
                minHeight = Math.Min(A[i], A[j]);
                area = (j - i) * minHeight;
                maxWater = Math.Max(area, maxWater);
                if (A[i] > A[j])
                    j--;
                else
                    i++;
            }
            Console.WriteLine("Maxwater is : {0}", maxWater);
        }
    }
}
