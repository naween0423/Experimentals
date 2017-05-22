using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// TripletsSumToAGivenTargetNumber
    /// </summary>
    public static class TripletsSumToAGivenTargetNumber
    {
        /// <summary>
        /// Find all the triplets whose sum matched to a Target number
        /// </summary>
        /// <param name="A"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<List<int>> GetTheTripletsForTheGivenSum(int[] A, int target)
        {
            if (A.Length == 0)
                return null;

            IList<List<int>> results = new List<List<int>>();

            for(int i = 0; i < A.Length -1; i++)
            {
                int l = i + 1;
                int r = A.Length - 1;

                while(l < r)
                {
                    int sum = A[i] + A[l] + A[r];

                    if (sum == target)
                    {
                        results.Add(new List<int>() { A[i], A[l], A[r] });
                    }
                    else if (sum < target)
                        l++;
                    else
                        r--;
                }
            }

            return results;
        }

    }
}
