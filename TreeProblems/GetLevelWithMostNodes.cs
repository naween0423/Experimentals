using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    /// <summary>
    /// Get level with max nodes
    /// </summary>
    public static class GetLevelWithMostNodes
    {
        /// <summary>
        /// gets maximum node levels
        /// </summary>
        /// <param name="root"></param>
        public static int GetMaximuNodesLevel(Tree root)
        {
            if (root == null)
                return int.MinValue;

            Queue<Tree> queue = new Queue<Tree>();
            queue.Enqueue(root);
            int currentLevel = 0;
            int maxNodesInAnyLevel = 0;
            queue.Enqueue(null);//this represents enf of this Level

            while(queue.Count > 0)
            {
                Tree node = queue.Dequeue();
                //if this is null which means we finished a level
                if(node == null)
                {
                    if (currentLevel > maxNodesInAnyLevel)
                        maxNodesInAnyLevel = currentLevel;
                    
                    if (queue.Count > 0)
                        queue.Enqueue(null);
                    currentLevel = 0;
                    continue;
                }

                currentLevel++;

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (root.Right != null)
                    queue.Enqueue(node.Right);                
            }

            return maxNodesInAnyLevel;
        }
    }
}
