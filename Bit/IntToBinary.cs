using System;
using System.Collections.Generic;
using System.Text;

namespace Experimental.Bit
{
    /// <summary>
    /// IntToBinary
    /// </summary>
    public static class Bits
    {
        /// <summary>
        /// PrintAllBinaryNumbers
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<string> PrintAllBinaryNumbers(int num)
        {
            if (num < 0)
                return null;

            List<string> numbers = new List<string>();

            for(int k = 0; k < num; k++)
            {
                //numbers.Add(IntegerToBinary(k));
                numbers.Add(IntegerToBinaryClassic(k));
            }

            return numbers;
        }

        /// <summary>
        /// IntegerToBinaryClassic
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntegerToBinaryClassic(int num)
        {
            if (num < 0)
                return null;

            StringBuilder builder = new StringBuilder();
            var temp = num;
            while(temp > 0)
            {
                var mod = temp % 2;
                builder.Append(mod);
                temp = temp / 2;
            }

            var charArray = builder.ToString().ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }


        /// <summary>
        /// IntegerToBinary
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntegerToBinary(int num)
        {
            if (num < 0)
                return null;

            StringBuilder builder = new StringBuilder();

            int i = 31;

            while(i >= 0)
            {
                if((num & (1 << i)) > 0)
                {
                    builder.Append("1");
                }
                else
                {
                    builder.Append("0");
                }
                i--;
            }            
            return builder.ToString();
        }
    }
}
