using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// finds next greater element in the circular array.
    /// https://leetcode.com/articles/next-greater-element-ii/
    /// 
    /// </summary>
    public static class FindNextGreatestelementInACircularArray
    {
        /// <summary>
        /// finds the next greater element in the Circular Array
        /// </summary>
        /// <param name="A"></param>
        /// Time: O(n2)
        /// Space : O(n) for res
        /// <returns></returns>
        public static int[] findNextGreaterElementInCircularArray(int[] A)
        {
            if (A.Length == 0)
                return null;

            int[] res = new int[A.Length];

            for(int i = 0; i < A.Length; i++)
            {
                res[i] = -1;

                for (int j = 1; j < A.Length; j++)
                {
                    int index = (i + j) % A.Length;
                    if (A[index] > A[i])
                    {
                        res[i] = A[index];
                        break;
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// Uses a stack to find the next gretest element 
        /// </summary>
        /// <param name="nums"></param>
        /// Time : O(n)
        /// Space : O(2n) => stacksize is double of inout array 
        /// <returns></returns>
        public static int[] findNextGreaterElementInCircularArrayUsingStack(int[] nums)
        {
            int[] res = new int[nums.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 2 * nums.Length - 1; i >= 0; --i)
            {
                while (!(stack.Count == 0) && nums[stack.Peek()] <= nums[i % nums.Length])
                {
                    stack.Pop();
                }
                res[i % nums.Length] = stack.Count == 0 ? -1 : nums[stack.Peek()];
                stack.Push(i % nums.Length);
            }
            return res;
        }

        /// <summary>
        /// given a and b arrays where a is subset of b 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        //public static int[] findNextGreaterIn2GivenArrays(int [] a, int [] b)
        //{
        //    int aLenght = a.Length;
        //    int bLength = b.Length;

        //    Stack<int> stack = new Stack<int>();
        //    for(int i = 0; i < )

        //}
    }
}
