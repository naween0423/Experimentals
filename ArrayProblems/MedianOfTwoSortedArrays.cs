using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// MedianofTwoSortedArrays class
    /// </summary>
    public static class MedianOfTwoSortedArrays
    {
        /// <summary>
        /// FindMedianSortedArray
        /// From : https://discuss.leetcode.com/topic/16797/very-concise-o-log-min-m-n-iterative-solution-with-detailed-explanation
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double FindMedianSortedArray(int[] nums1, int[] nums2)
        {
            int N1 = nums1.Length;
            int N2 = nums2.Length;

            if (N1 < N2)
                return FindMedianSortedArray(nums2, nums1);

            if (N2 == 0)
                return (nums1[(N1 - 1) / 2] + nums1[N1 / 2]) / 2;

            int lo = 0;
            int hi = N2 * 2;

            while(lo <= hi)
            {
                int mid2 = (lo + hi) / 2; //Find cut 2
                int mid1 = N1 + N2 - mid2; //Calculate cut 1 accordingly

                double L1 = (mid1 == 0) ? int.MinValue : nums1[(mid1 - 1) / 2];//int.Minvalue to avoid -ve mid 
                double L2 = (mid2 == 0) ? int.MinValue : nums2[(mid2 - 1) / 2];//

                double R1 = (mid1 == N1 * 2) ? int.MaxValue : nums1[(mid1) / 2];//int.Maxvalue to avoid indexoutofboudfor mid 
                double R2 = (mid2 == N2 * 2) ? int.MaxValue : nums2[(mid2) / 2];//

                if (L1 > R2)
                    lo = mid2 + 1;
                else if (L2 > R1)
                    hi = mid2 - 1;
                else
                    return (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2;

            }
            return -1;
        }

    }
}
