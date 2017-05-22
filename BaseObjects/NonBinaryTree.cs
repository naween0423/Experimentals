using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Non BT Structure
    /// </summary>
    public class NonBinaryTree
    {
        public int Data;
        public List<NonBinaryTree> Children;

        /// <summary>
        /// Cntro
        /// </summary>
        /// <param name="data"></param>
        public NonBinaryTree(int data)
        {
            this.Data = data;
            //this.Children = new List<NonBinaryTree>();
        }
    }
}

