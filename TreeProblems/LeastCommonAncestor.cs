using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    public static class LeastCommonAncestor
    {
        /// <summary>
        /// finds the Least Common Ancestor of given 2 nodes in a Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Tree FindLCAOfNodes(Tree root, Tree n1, Tree n2)
        {
            if (root == null)
                return null;

            if (root.Data == n1.Data || root.Data == n2.Data)
                return root;

            Tree left_lca = FindLCAOfNodes(root.Left, n1, n2);
            Tree right_lca = FindLCAOfNodes(root.Right, n1, n2);

            if (left_lca != null && right_lca != null)
                return root;

            return (left_lca != null) ? left_lca : right_lca;
        }
    }
}
