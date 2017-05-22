using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Interval class
    /// </summary>
    public class Interval
    {
        public int start;
        public int end;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
    }
}
