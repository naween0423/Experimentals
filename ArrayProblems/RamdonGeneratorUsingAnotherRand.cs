using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// RamdonGeneratorUsingAnotherRand
    /// </summary>
    public static class RamdonGeneratorUsingAnotherRand
    {
        /// <summary>
        /// rand7 using rand5
        /// </summary>
        /// <returns></returns>
        public static int rand7()
        {
            Random rand5 = new Random();
            int[,] vals = { { 1, 2, 3, 4, 5 }, 
                            { 6, 7, 1, 2, 3 }, 
                            { 4, 5, 6, 7, 1 }, 
                            { 2, 3, 4, 5, 6 }, 
                            { 7, 0, 0, 0, 0 } };
            int result = 0;
            while (result == 0)
            {
                int i = rand5.Next(5);
                int j = rand5.Next(5);
                result = vals[i - 1, j - 1];
            }
            return result;
        }
    }
}
