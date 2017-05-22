using System;
using System.Collections.Generic;

namespace Experimental.ArrayProblems
{
    public static class FindPairWithSum
    {
        /// <summary>
        /// Check if a pair with given sum exists
        /// in a Sotred Array with duplicates
        /// </summary>
        /// <param name="A"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static bool HasSumWithPair(int[] A, int sum)
        {
            int low = 0;
            int hi = A.Length - 1;

            while(low < hi)
            {
                int s = A[low] + A[hi];

                if (s == sum)
                    return true;
                else if (s > sum)
                    hi--;
                else
                    low++;
            }
            return false;
        }

        /// <summary>
        /// GetIndicesOfPairWithSum
        /// </summary>
        /// <param name="A"></param>
        /// <param name="N"></param>
        /// <param name="Sum"></param>
        /// <returns></returns>
        public static int[] GetIndicesOfPairWithSum(int[] A, int N, int Sum)
        {
            if (A == null || A.Length <= 0) 
                return null;
            int[] result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i= 0; i< N; i++)
            {
                if (map.ContainsKey(Math.Abs(Sum - A[i])))
                {
                    result[0] = A[i];
                    result[1] = Sum - A[i];
                    return result;
                }
                else
                    map.Add(A[i], i);
            }
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// This is as as Above but also works with Unsorted duplicate elements
        /// </summary>
        /// <param name="A"></param>
        /// <param name="N"></param>
        /// <param name="Sum"></param>
        public static void PrintPairsWithSum(int []A, int N, int Sum)
        {
            if (N <= 0)
                return;

            Dictionary<int, bool> Set = new Dictionary<int, bool>();            
            for (int i = 0; i <= N - 1; i++)
            {
                if(Set.ContainsKey(Sum - A[i]))
                {
                    Console.WriteLine("Pairs with Sum : {0} is => [{1}\t{2}]", Sum, A[i], Sum - A[i]);
                    continue;
                }
                Set.Add(A[i], true);
            }
        }
    }
}
