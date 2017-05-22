using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{

    public static class FindNonRepeatingNumberInSortedArray
    {
        /// <summary>
        /// GetANumberWhenEachNumberOccursTwiceExceptOne
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int GetANumberWhenEachNumberOccursTwiceExceptOne(int[] a)
        {
            if (a.Length == 0)
                return -1;

            int length = a.Length;

            int lo = 0; int hi = length / 2;

            while(lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (a[2 * mid] != a[2 * mid + 1])
                    hi = mid;
                else
                    lo = mid;
            }
            return a[2*lo];
        }
    }
}
