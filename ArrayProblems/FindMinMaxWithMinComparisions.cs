using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Find min and max with min comparisions
    /// </summary>
    public static class FindMinMaxWithMinComparisions
    {
        /// <summary>
        /// Find the min and Max
        /// Performance : 2n+2
        ///     forloop n\2
        ///     3 comparisions : 3n\2
        ///     2 extra comarisions : 2
        /// </summary>
        /// <param name="A"></param>
        public static void FindMinMax(int[] A)
        {
            if (A == null)
                return;

            if (A.Length <= 0)
                return;
            int n = 0;
            //Find if there are odd number of elements
            bool isOdd = A.Length % 2 == 1 ? true : false;

            // if Odd the compare the last element later
            if (isOdd)
                n = A.Length - 1;
            else
                n = A.Length;

            int min = int.MaxValue;
            int max = int.MinValue;

            // comparing paris hence i = i+2;
            for(int i = 0; i < n; i = i + 2)
            {
                int minimum;
                int maximum;

                if (A[i] >= A[i + 1])
                {
                    maximum = A[i];
                    minimum = A[i + 1];
                }
                else
                {
                    maximum = A[i + 1];
                    minimum = A[i];
                }

                if(maximum > max)
                {
                    max = maximum;
                }
                if (minimum < min)
                {
                    min = minimum;
                }
            }
            //Compare the last element with min and max.
            if(isOdd)
            {
                if (A[n] > max)
                    max = A[n];
                if (A[n] < min)
                    min = A[n];
            }
            Console.WriteLine("Minimum is : " + min);
            Console.WriteLine("Maximum is : " + max);
        }

    }
}
