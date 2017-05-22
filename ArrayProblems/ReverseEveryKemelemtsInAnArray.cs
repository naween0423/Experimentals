using System;

namespace Experimental
{
    /// <summary>
    /// ReverseEveryKemelemtsInAnArray
    /// </summary>
    public static class ReverseEveryKemelemtsInAnArray
    {

        /// <summary>
        /// ReverseEveryKElements
        /// </summary>
        /// <param name="a"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] ReverseEveryKElements(int[] a, int k)
        {
            if (a.Length <= 0)
                return null;

            if (k == 0)
                return a;

            for (var i = 0; i < a.Length - 1; i += k)
            {
                var left = i;

                var right = Math.Min(i + k - 1, a.Length - 1);

                while (left<right)
                {
                    var temp = a[left];
                    a[left++] = a[right];
                    a[right--] = temp;
                }
            }
            return a;
        } 
    }
}
