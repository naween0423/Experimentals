using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.MathProblems
{
    /// <summary>
    /// Fibonacci
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// fibonacci using Memoization
        /// </summary>
        /// <param name="n"></param>
        /// <param name="Memo"></param>
        /// <returns></returns>
        public static int FiboMemoization(int n, int[] Memo)
        {
            if (n < 0)
                return 0;
            else if (n <= 1)
                return 1;
            else if (Memo[n] == 0)
                Memo[n] = FiboMemoization(n - 1, Memo) + FiboMemoization(n - 2, Memo);

            return Memo[n];
        }


        /// <summary>
        /// Iterative Fibonacci.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FiboIterative(int n)
        {
            int a = 0; int b = 1;int c;
            if (n == 0)
                return a;
            for(int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        /// <summary>
        /// Recurssive approach to fibonacci
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FiboRecurssive(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (n > 1)
                return FiboRecurssive(n - 1) + FiboRecurssive(n - 2);
            else
                return -1;
                
        }
    }
}
