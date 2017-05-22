using System.Linq;

namespace Experimental.Bit
{
    public static class FindTheMissingNumber
    {
        /// <summary>
        /// FindMissingNUmberUsingSum
        /// We must include the missing element index as well. 
        /// thats why we have n+1 * n+2
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindMissingNUmberUsingSum(int[] arr)
        {
            if (arr.Length <= 0)
                return -1;
            var n = arr.Length;
            var sum = (n + 1)*(n + 2)/2;

            return arr.Aggregate(sum, (current, t) => current - t);
        }

        /// <summary>
        /// FindMissingNumberUsingXor
        /// We must include the Missing element index as well t
        /// Thats why we do arr.Lenght + 1 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindMissingNumberUsingXor(int[] arr)
        {
            if (arr.Length <= 0)
                return -1;

            var x1 = arr[0];
            var x2 = 1;

            for (var i = 1; i < arr.Length; i++)
            {
                x1 = x1 ^ arr[i];
            }
            for (var i = 2; i <= arr.Length + 1; i++)
            {
                x2 = x2 ^ i;
            }

            return x1 ^ x2;
        }
    }
}
