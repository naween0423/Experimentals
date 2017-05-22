using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// FactorialOfALargeNumber
    /// http://www.geeksforgeeks.org/factorial-large-number/
    /// </summary>
    public static class FactorialOfALargeNumber
    {
        /// <summary>
        /// GetfactorialOfaLargeNumber
        /// </summary>
        /// <param name="number"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string GetfactorialOfaLargeNumber(int number, int maxLength)
        {
            if (number == 0)
                return "0";

            if (number == 1)
                return "1";
            
            int[] res = new int[maxLength];
            int resultSize = 1;
            // Initialize result
            res[0] = 1;
            // Apply simple factorial formula n! = 1 * 2 * 3 * 4...*n
            for (int i = 2; i <= number; i ++)
            {
                resultSize = multiply(i, res, resultSize);
            }

            StringBuilder builder = new StringBuilder();

            for (int i = resultSize - 1; i >= 0; i--)
                builder.Append(res[i]);

            return builder.ToString();
        }

        /// <summary>
        /// // This function multiplies x with the number represented by res[].
        // res_size is size of res[] or number of digits in the number represented
        // by res[]. This function uses simple school mathematics for multiplication.
        // This function may value of res_size and returns the new value of res_size
        /// </summary>
        /// <param name="x"></param>
        /// <param name="res"></param>
        /// <param name="resultSize"></param>
        /// <returns></returns>
        public static int multiply(int x, int[] res, int resultSize)
        {
            int carry = 0;
            // One by one multiply n with individual digits of res[]
            for (int i = 0; i < resultSize; i++)
            {
                int prod = res[i] * x + carry;
                res[i] = prod % 10; // Store last digit of 'prod' in res[]
                carry = prod / 10; // Put rest in carry
            }

            // Put carry in res and increase result size
            while (carry > 0)
            {
                res[resultSize] = carry % 10;
                carry = carry / 10;
                resultSize++;
            }

            return resultSize;
        }

        /// <summary>
        /// Finding Factorial of a given large number 
        /// using Linked List
        /// </summary>
        /// <param name="n"></param>
        public static void factorialOfLargeNumberWithLinkedList(int n)
        {
            int i, k = 0, index = 1, mult, carry = 0;
            BaseObjects.Node a = null, head = null;
            LinkedLists.LinkedLists.AddBack(a, 1);
            head = a;
            for (i = 2; i <= n; i++)
            {
                k = 0;
                a = head;
                while (k < index)
                {
                    mult = (a.Data) * i + carry;
                    a.Data = mult % 10;
                    carry = mult / 10;
                    if (carry > 0 && a.Next == null)
                    {
                        index++;
                        a.Data = 0;
                    }
                    k++;
                    a = a.Next;
                }
            }
            head = LinkedLists.LinkedLists.ReverseALinkedList(ref head);
            LinkedLists.LinkedLists.ReverseALinkedList(ref head);
            LinkedLists.LinkedLists.PrintNodes(head);
        }
    }
}
