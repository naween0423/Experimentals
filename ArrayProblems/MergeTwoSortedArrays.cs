using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Merge two sorted array and return the new array
    /// </summary>
    public static class MergeTwoSortedArrays
    {
        /// <summary>
        /// Compact version of the Merge
        /// Points of Interests
        ///Notice that it does same or less number of operations as any other O(n) algorithm but in 
        ///literally single statement in a single while loop!
        ///If two arrays are of approximately same size then constant for O(n) is same.
        ///However if arrays are really imbalanced then versions with System.arraycopy would win because 
        ///internally it can do this with single x86 assembly instruction.
        ///Notice a[i] >= b[j] instead of a[i] > b[j]. This guarantees "stability" that is defined as 
        ///when elements of a and b are equal, we want elements from a before b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns> 
        public static int[] merge(int[] a, int[] b)
        {
            int[] answer = new int[a.Length + b.Length];
            int i = a.Length - 1, j = b.Length - 1, k = answer.Length;

            while (k > 0)
                answer[--k] =
                    (j < 0 || (i >= 0 && a[i] >= b[j])) ? a[i--] : b[j--];

            return answer;
        }


        /// <summary>
        /// Merges 2 given Arrays into a new array
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] MergeGiven2sortedArrays(int[] A, int[] B)
        {
            if (A.Length == 0 && B.Length == 0)
                return null;
            else if (A.Length == 0)
                return B;
            else if (B.Length == 0)
                return A;
            else
            {
                int[] C = new int[A.Length + B.Length];
                int i = A.Length - 1;
                int j = B.Length - 1;
                int k = A.Length + B.Length - 1 ;
                while (i >= 0 && j >=0)
                {
                    if (A[i] >= B[j])
                    {
                        C[k--] = A[i--];
                    }
                    else if (A[i] < B[j])
                    {
                        C[k--] = B[j--];
                    }
                }
                while (i >= 0)
                    C[k--] = A[i--];
                while (j >= 0)
                    C[k--] = B[j--];
                
               return C;
            }
        }
    }
}
