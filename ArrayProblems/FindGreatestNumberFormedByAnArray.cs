using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// FindGreatestNumberFormedByAnArray
    /// </summary>
    public static class FindGreatestNumberFormedByAnArray
    {
        /// <summary>
        /// GetLargestNumber
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string GetLargestNumber(int[] nums)
        {
            string[] arr = new string[nums.Length];
            
            //Array.Sort(arr,0, arr.Length, new MyComparer());
            //Alternate way is below
            ArrangeArrayToGenerateLargest(nums);
            return string.Join("", arr);
        }

        /// <summary>
        /// ArrangeArrayToGenerateLargest
        /// </summary>
        /// <param name="arr"></param>
        public static void ArrangeArrayToGenerateLargest(int[] arr)
        {
            var length = arr.Length;
            Console.Write("Before : " + string.Join(" ", arr) + "\n");
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var concactij = Convert.ToInt64(string.Format("{0}{1}", arr[i], arr[j]));
                    var concactji = Convert.ToInt64(string.Format("{1}{0}", arr[i], arr[j]));
                    
                    if (concactij > concactji)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("After : "+string.Join(" ", arr));
        }

        /// <summary>
        /// Comparer
        /// </summary>
        public class MyComparer : IComparer<string>
        {
            /// <summary>
            /// Compare
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public int Compare(string a, string b)
            {
                var stringAB = Convert.ToInt64(string.Concat(a, b));
                var stringBA = Convert.ToInt64(string.Concat(b, a));

                return (stringAB > stringBA) ? -1 : 1;
            }
        }
    }
}