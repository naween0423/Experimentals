using System;

namespace Experimental
{
    /// <summary>
    /// Question from : http://www.geeksforgeeks.org/count-all-distinct-pairs-formed-by-contiguous-sub-array/
    /// Solution From : http://code.geeksforgeeks.org/zKqdpK
    /// </summary>
    public static class PairsFormedByDistinctContiguousSubArray
    {
        public static int ParisFormed(int[] A, int n)
        {
            if (A.Length == 0)
                return -1;

            int count = 0, right = 1, left = 0;
            var visited = new bool[n];

            while(right < n)
            {
                while(right < n && (!visited[A[right]]))
                {
                    count += right - left;
                    visited[A[right]] = true;
                    Console.WriteLine("{0}, {1}", A[left], A[right]);
                    right++;
                }
                while(left < right && (right != n && visited[A[right]]))
                {
                    visited[A[left]] = false;
                    Console.WriteLine("{0}, {1}", A[left], A[right]);
                    left++;
                }
                
            }
            Console.WriteLine("Number of Pairs : {0}", count);
            return count;
        }

    }

}
