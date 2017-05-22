using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// IntersectionOfTwoSortedArrays
    /// </summary>
    public static class IntersectionOfTwoSortedArrays
    {
        /// <summary>
        /// GetIntersection
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] GetIntersection(int[] A, int[] B)
        {
            if (A.Length <= 0 || B.Length <= 0)
                return null;

            int aLength = A.Length;
            int bLength = B.Length;
            List<int> result = new List<int>();
            int i = 0; int j = 0;

            while(i < aLength && j < bLength)
            {
                if (A[i] == B[j])
                {
                    result.Add(A[i]);
                    i++; j++;
                }
                else if (A[i] < B[j])
                    i++;
                else
                    j++;               

            }
            return result.ToArray();

        }
    }
}
