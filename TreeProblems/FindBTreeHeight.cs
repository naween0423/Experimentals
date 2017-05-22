using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    /// <summary>
    /// FindBTreeHeight
    /// </summary>
    public static class FindBTreeHeight
    {
        /// <summary>
        /// GetBTreeHeight
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int GetBTreeHeight(Tree root)
        {
            Tree current = root;
           
            if (root == null)
                return 0;                        
            else
            {
                int leftHeight = GetBTreeHeight(current.Left);
                int rightHeight = GetBTreeHeight(current.Right);

                if (leftHeight > rightHeight)
                    return leftHeight + 1;
                else
                    return rightHeight + 1;

                //or 1 + return Math.Max(leftHeight. rightHeight);
            }                     
        }



        /// <summary>
        /// Print all Nodes at Kth Level or
        /// Print all nodes which are k nodes from the root
        /// </summary>
        /// <param name="root"></param>
        /// <param name="level"></param>
        public static void PrintAllNodesAtKthLevel(Tree root, int level)
        {
            if (root == null)
                return;
            if (level == 0)
                Console.WriteLine(root.Data);

            PrintAllNodesAtKthLevel(root.Left, level - 1);
            PrintAllNodesAtKthLevel(root.Right, level - 1);
        }
    }
}
