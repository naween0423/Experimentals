using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    /// <summary>
    /// FindLevelWithMaximumNodesOfaTree
    /// </summary>
    public static class FindLevelWithMaximumNodesOfaTree
    {
        /// <summary>
        /// Makes a non Binary tree
        /// </summary>
        /// <returns></returns>
        public static BaseObjects.NonBinaryTree MakeNonBT()
        {
            BaseObjects.NonBinaryTree tree = new BaseObjects.NonBinaryTree(44);

            tree.Children = new List<BaseObjects.NonBinaryTree>
            {
                new BaseObjects.NonBinaryTree(3),
                new BaseObjects.NonBinaryTree(4)
            };
            tree.Children[0].Children = new List<BaseObjects.NonBinaryTree>
            {
                new BaseObjects.NonBinaryTree(321),
                new BaseObjects.NonBinaryTree(233),
                new BaseObjects.NonBinaryTree(334)
            };

            tree.Children[1].Children = new List<BaseObjects.NonBinaryTree>
            {
                new BaseObjects.NonBinaryTree(101),
                new BaseObjects.NonBinaryTree(225)
            };
            tree.Children[0].Children = new List<BaseObjects.NonBinaryTree>
            {
                new BaseObjects.NonBinaryTree(101),
                new BaseObjects.NonBinaryTree(225),
                new BaseObjects.NonBinaryTree(101),
                new BaseObjects.NonBinaryTree(225)
            };

            return tree;
        }

        /// <summary>
        /// findLevelWithMaxNodes
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int findLevelWithMaxNodes(BaseObjects.NonBinaryTree root)
        {
            if (root == null)
                return -1;

            Dictionary<int, List<BaseObjects.NonBinaryTree>> result = new Dictionary<int, List<BaseObjects.NonBinaryTree>>();
            List<BaseObjects.NonBinaryTree> list = new List<BaseObjects.NonBinaryTree>();
            int level = 0;
            int max = 0;
            list.Add(root);
            result.Add(level, list);
            while(true)
            {
                foreach(var node in result[level])
                {
                    list = new List<BaseObjects.NonBinaryTree>();
                    if(node.Children != null)
                        list.AddRange(node.Children);
                }

                if (list.Count > 0)
                {
                    result.Add(level + 1, list);

                    if (max < list.Count)
                        max = list.Count;
                }
                else
                    break;

                level++;
            }
            return max;
        }
    }
}
