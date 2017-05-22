using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Point with a row and col coordinates
    /// </summary>
    public class Point
    {
        /// <summary>
        /// row
        /// </summary>
        int Row;

        /// <summary>
        /// column
        /// </summary>
        int Col;

        public Point(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
