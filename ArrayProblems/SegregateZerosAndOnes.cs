using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental
{
    /// <summary>
    /// Arrange Zeros and Ones in a given array 
    /// Zeros to the Right and ones to the Left
    /// </summary>
    public static class SegregateZerosAndOnes
    {
        /// <summary>
        /// Segregate0SAnd1S
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] Segregate0SAnd1S(int[] a)
        {
            if (a.Length <= 0)
                return null;
            var trackOnes = a.Length - 1;

            for (var i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == 1)
                    a[trackOnes--] = 1;
            }
            while (trackOnes >= 0)
            {
                a[trackOnes--] = 0;
            }
            return a;
        }
    }
}
