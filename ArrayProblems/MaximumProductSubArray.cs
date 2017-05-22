using System;

namespace Experimental
{
    public static class MaximumProductSubArray
    {
        /// <summary>
        /// MaxProduct
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxProduct(int[] nums)
        {
            var result = 0;
            if (nums == null || nums.Length <= 0) return result;
            result = nums[0];
            var maxn1 = result;
            var minn1 = result;
            for (var i = 1; i < nums.Length; i++)
            {
                var max = maxn1 * nums[i];
                var min = minn1 * nums[i];
                maxn1 = Math.Max(nums[i], Math.Max(max, min));
                minn1 = Math.Min(nums[i], Math.Min(max, min));
                result = Math.Max(result, maxn1);
            }
            return result;
        }
    }
}
