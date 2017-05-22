using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimental.BaseObjects;

namespace Experimental.TreeProblems
{
    /// <summary>
    /// Get Alls paths of the Tree as LinkedLists
    /// Pre-Order Tree Traversal with a Level 
    /// Recursive call
    /// </summary>
    public static class LinkedListsForAllTreePaths
    {
           //       5
           //      /  \        
           //     /    8
           //    3     / \
           //   / \    7  9
           //  2   4  /
           // /       6   
           // 1 

        /// <summary>
        /// Builds a Gtree 
        /// </summary>
        /// <returns></returns>
        public static Gtree<int> BuildGTree()
        {
            Gtree<int> gTree = new Gtree<int>(5);
            gTree.Left = new Gtree<int>(3);
            gTree.Left.Left = new Gtree<int>(2);
            gTree.Left.Right = new Gtree<int>(4);
            gTree.Left.Left.Left = new Gtree<int>(1);

            gTree.Right = new Gtree<int>(8);
            gTree.Right.Left = new Gtree<int>(7);
            gTree.Right.Right = new Gtree<int>(9);
            gTree.Right.Left.Left = new Gtree<int>(6);
            return gTree;            
        }



        /// <summary>
        /// Gets tree Levels as Lists Using BFS traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<List<Gtree<int>>> GetLinkedListsOfTreeDepthLevelsUsingBfs(Gtree<int> root)
        {
            List<List<Gtree<int>>> result = new List<List<Gtree<int>>>();
            List<Gtree<int>> current = new List<Gtree<int>>();
            if (root != null)
            {
                current.Add(root);
            }
            while(current.Count > 0)
            {
                result.Add(current);
                List<Gtree<int>> parent = current;
                current = new List<Gtree<int>>();
                foreach(Gtree<int> tree in parent)
                {
                    if(tree.Left != null)
                    {
                        current.Add(tree.Left);
                    }
                    if(tree.Right != null)
                    {
                        current.Add(tree.Right);
                    }
                }
            }
            return result;
        }



        /// <summary>
        /// GetLinkedListsOfTreepaths
        /// Uses a Pre-Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <param name="level"></param>
        /// <param name="Lists"></param>
        /// <returns></returns>
        public static IList<List<Gtree<int>>> GetLinkedListsOfTreeDepthLevels(Gtree<int> root, int level, IList<List<Gtree<int>>> Lists)
        {
            if (root == null)
                return null;

            List<Gtree<int>> list = null;

            if(Lists.Count== level)
            {
                list = new List<Gtree<int>>();
                Lists.Add(list);
            }
            else
            {
                list = Lists[level];
            }
            list.Add(root);
            GetLinkedListsOfTreeDepthLevels(root.Left, level+1, Lists);
            GetLinkedListsOfTreeDepthLevels(root.Right, level+1, Lists);
            return Lists;
        }
    }
}
