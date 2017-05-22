using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public static class FindLargestAndSmallestInAnArray
    {
        /// <summary>
        ///  prints the Smallest and the Largest value
        /// </summary>
        /// <param name="arr"></param>
        public static void GetSmallestAndLargest(int[] arr)
        {
            if (arr.Length <= 0)
                return;

            int max = int.MinValue;
            int min = int.MaxValue;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Smallest is : {0}", min);
            Console.WriteLine("Largest is : {0}", max);
        }
    }
}
