using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.MathProblems
{
    public static class IntegerProblems
    {
        /// <summary>
        /// IsPalindromeNumber
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPalindromeNumber(int number)
        {
            if (number == 0)
                return true;

            var div = 1;
            while(number/div >= 10)
            {
                div *= 10;
            }

            while(number !=0)
            {
                int l = number / div;
                int r = number % 10;

                if (l != r)
                    return false;

                number = (number % div) / 10;
                div = div / 100;
                
            }
            return true;


        }


        /// <summary>
        /// Reverse an Integer
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Reverse(int number)
        {
            if (number == 0)
                return number;

            var rev = 0;
            while(number != 0)
            {
                rev = rev * 10 + number % 10;
                number = number / 10;
            }            
            return rev;
        }
    }
}
