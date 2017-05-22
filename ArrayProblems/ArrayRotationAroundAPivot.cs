using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public static class ArrayRotationAroundAPivot
    {
        /// <summary>
        /// Rotate array to the right of a given pivot
        /// </summary>
        /// <param name="x"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static int[] Rotate(int[] x, int pivot)
        {
            if (pivot < 0 || x == null)
                throw new Exception("Invalid argument");

            pivot = pivot % x.Length;

            //Rotate first half
            x = RotateSub(x, 0, pivot - 1);

            //Rotate second half
            x = RotateSub(x, pivot, x.Length - 1);

            //Rotate all
            x = RotateSub(x, 0, x.Length - 1);

            return x;
        }

        /// <summary>
        /// Rotate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int[] RotateSub(int[] x, int start, int end)
        {
            while (start < end)
            {
                int temp = x[start];
                x[start] = x[end];
                x[end] = temp;
                start++;
                end--;
            }
            return x;
        }

        /// <summary>
        /// Rotate a given array n elements from right to left
        /// 1. Rotate start to pivot 
        /// 2. Rotate pivot +1 to end
        /// 3. Rotate 0 to end
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        public static void RotateAGivenArrayNElementsFromRight(int[] a, int n)
        {
            if (a.Length == 0 || n < 0)
                return;
            //If n is greater than array length
            if (n > a.Length)
                n = n % a.Length;

            int pivot = a.Length - 1 - n;
            a = ReverseArray(a, 0, pivot);
            a = ReverseArray(a, pivot + 1, a.Length -1);
            a = ReverseArray(a, 0, a.Length - 1);
            foreach (int e in a)
                Console.Write("{0}, ", e);
        }

        /// <summary>
        /// reverses a given array from start to end
        /// </summary>
        /// <param name="a"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int[] ReverseArray(int[] a, int start, int end)
        {
            if (start < 0 || end > a.Length)
                return null;

            while(start < end)
            {
                int temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;
            }

            return a;
        }
    }
}
