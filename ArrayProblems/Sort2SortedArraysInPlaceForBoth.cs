using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public static class Sort2SortedArraysInPlaceForBoth
    {
        /// <summary>
        /// Sorts 2 given arrays without merging
        /// After Merging 
        /// First Array: 1 2 3 5 8 9 
        /// Second Array: 10 13 15 20 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SortGivenArraysInPlaceWithOutMerge(int[] ar1, int[] ar2, int m, int n)
        {
            // Iterate through all elements of ar2[] starting from
            // the last element
            for (int j = n - 1; j >= 0; j--)
            {
                /* Find the smallest element greater than ar2[i]. Move all
                   elements one position ahead till the smallest greater
                   element is not found */ 
                int i, last = ar1[m - 1];
                for (i = m - 2; i >= 0 && ar1[i] > ar2[j]; i--)
                    ar1[j + 1] = ar1[j];

                // If there was a greater element
                if (i != m - 2 || last > ar2[j])
                {
                    ar1[i + 1] = ar2[j];
                    ar2[j] = last;
                }
            }
        }
    }
}
