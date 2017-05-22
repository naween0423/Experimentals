using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.MathProblems
{
    /// <summary>
    /// Print Prime numbers
    /// </summary>
    public static class PrintPrimeNumbers
    {
        /// <summary>
        /// Checks is a given number is prime
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static bool CheckPrime(int N)
        {
            if (N <= 2)
                return true;

            int c;

            for(c = 2; c < N -1; c++)
            {
                if (N % c == 0)
                    return false;
            }
            if (c == N)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Print Prime Numbers
        /// </summary>
        /// <param name="N"></param>
        public static void PrintNPrimeNumbers(int N)
        {
            int i = 3, count, c;

            if (N <= 2)
                Console.WriteLine(N);

            for (count = 2; count <= N;)
            {
                for (c = 2; c <= i - 1; c++)
                {
                    if (i % c == 0)
                        break;
                }
                if (c == i)
                {
                    Console.Write("Prime Number : {0}\n", i);
                    count++;
                }
                i++;
            }
        }
    }
}
