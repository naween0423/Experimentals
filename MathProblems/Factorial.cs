using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.MathProblems
{
    /// <summary>
    /// Factorial
    /// </summary>
    public static class Factorial
    {
        /// <summary>
        /// Iterative Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FactoIterative(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            int facto = 1;
            for(int i = 1; i <= n; i++)
            {
                facto *= i;
            }
            return facto;
        }

        /// <summary>
        /// Recurssive factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FactoRecurssive(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return FactoRecurssive(n - 1) * n;
        }
    }
}
