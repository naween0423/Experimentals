using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Powerset
    /// </summary>
    public static class PowerSet
    {
        ///// <summary>
        ///// Powerset Iterative
        ///// </summary>
        //void PrintSubsets()
        //{
        //    int[] source = { 1, 2, 3 };
        //    int currentSubset = 7;
        //    int tmp;
        //    while (currentSubset > 0)
        //    {
        //        Console.Write("(");
        //        tmp = currentSubset;

        //        for (int i = 0; i < 3; i++)
        //        {
        //            if (tmp & 1)
        //                Console.Write("%d ", source[i]);
        //            tmp >>= 1;
        //        }
        //        Console.WriteLine(")");
        //        currentSubset--;
        //    }
        //}

        /// <summary>
        /// RecurssivePowerSetPrint
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="num"></param>
        public static void RecurssivePowerSetPrint(string prefix, int num)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < num.ToString().Length; i++)
                RecurssivePowerSetPrint(prefix + num.ToString()[i], int.Parse(num.ToString().Substring(i + 1)));

        }

        /// <summary>
        /// Print power set for a Given set
        /// </summary>
        /// <param name="set"></param>
        public static void PowerSetPrint(int[] set)
        {
            if (set.Length <= 0)
                return;
                        
            PrintPowerSet(set, set.Length);
        }

        /// <summary>
        /// Prints power set
        /// </summary>
        /// <param name="set"></param>
        /// <param name="setSize"></param>
        private static void PrintPowerSet(int[] set, int setSize)
        {
            var totalSets = Convert.ToInt32(Math.Pow(2, setSize));
            for (int i = 0; i < totalSets; i++)
            {
                for (int j = 0; j < setSize; j++)
                {
                    //var val = i & (1 << j);
                    //Console.WriteLine(val);
                    if ((i & (1 << j)) > 0)
                        Console.Write(set[j]);
                }
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Print powerset
        /// </summary>
        /// <param name="str"></param>
        /// <param name="set"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void printSubSet(string str, int[] set, int start, int end)
        {
            if (start == end)
                Console.Write(str + " }\n");

            else
            {
                printSubSet(str + set[start] + " ", set, start + 1, end);
                printSubSet(str, set, start + 1, end);
            }
        }
    }
}
