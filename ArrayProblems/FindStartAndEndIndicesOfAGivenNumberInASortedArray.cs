using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public static class FindStartAndEndIndicesOfAGivenNumberInASortedArray
    {

        /// <summary>
        /// Get Start and End Indices of a given Number 
        /// in an Array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="number"></param>
        public static void FindStartAndEndRangeOfARepeatedNumber(int[] arr, int number)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;
            while (high >= low)
            {
                mid = low + ((high - low) / 2);
                if (arr[mid] == number)
                {
                    break;
                }
                else if (arr[mid] > number)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            if (low > high)
            {
                Console.WriteLine("Number not found" + -1);
                return;
            }
            // Found number at mid. Look for range.
            int right = mid, left = mid;
            while (right < arr.Length - 1 && arr[right + 1] == number)
            {
                right++;
            }
            while (left > 1 && arr[left - 1] == number)
            {
                left--;
            }
            Console.WriteLine("(" + left + "," + right + ")");
        }

        /// <summary>
        /// Binary search
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] FindStartAndEndIndexOfaRepeatingNumber(int[] a, int n)
        {
            if (a.Length == 0)
                return null;

            int i = 0;
            int j = 0;

            int start = 0;
            int end = a.Length;

            while(start < end)
            {
                int mid = start + (end - start) / 2;
                if (a[mid] > n)
                {
                    end = mid - 1;
                }
                else if (a[mid] < n)
                {
                    start = mid + 1;
                }
                else if (a[mid] == n)
                {
                    i = mid; j = mid;
                    //Look for left side
                    for (int k = mid-1; k >= 0; k--)
                    {
                        if (a[k] == n)
                            i--;
                    }
                    //look for right side
                    for (int k = mid+1; k < end; k++)
                    {
                        if (a[k] == n)
                            j++;
                    }
                    break;
                }
            }
            return new int[] { i, j };
        }
    }
}

