using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.MathProblems
{
    /// <summary>
    /// IntToRomanNumber
    /// </summary>
    public static class IntToRomanNumber
    {
        /// <summary>
        /// Integer to Roman Number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntToRoman(int num)
        {
            var sb = new StringBuilder();
            var romans = new[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            var ints = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            for (var i = ints.Length - 1; i >= 0; i--)
            {
                var times = num / ints[i];
                num %= ints[i];
                while (times > 0)
                {
                    sb.Append(romans[i]);
                    times--;
                }
            }
            return sb.ToString();
        }
    }
}
