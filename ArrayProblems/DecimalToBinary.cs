using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public static class DecimalToBinary
    {
        //public string DecimalToBinary(string data)
        //{
        //    string result = string.Empty;
        //    int rem = 0;
        //    try
        //    {
        //        if (!IsNumeric(data))
        //            error = "Invalid Value - This is not a numeric value";
        //        else
        //        {
        //            int num = int.Parse(data);
        //            while (num > 0)
        //            {
        //                rem = num % 2;
        //                num = num / 2;
        //                result = rem.ToString() + result;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        error = ex.Message;
        //    }
        //    return result;
        //}

        /// <summary>
        /// ToBinary
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ToBinary(int n)
        {
            if (n < 2) return n.ToString();

            var divisor = n / 2;
            var remainder = n % 2;

            return ToBinary(divisor) + remainder;
        }

        /// <summary>
        /// Gets Binary string
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
