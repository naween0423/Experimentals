using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Experimental.TreeProblems
{
    /// <summary>
    /// CheckIsGivenBTisaBST
    /// </summary>
    public static class CheckIsGivenBTisaBST
    {
        
        /// <summary>
        /// Checks if a given binary tree is a Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static bool CheckIsBTIsABST(Tree root, int minValue, int maxValue)
        {
            if (root == null)
                return true;
            
            return root.Data >= minValue && 
                root.Data <= maxValue && 
                CheckIsBTIsABST(root.Left, minValue, root.Data) && 
                CheckIsBTIsABST(root.Right, root.Data, maxValue); 
        }
    }
}
