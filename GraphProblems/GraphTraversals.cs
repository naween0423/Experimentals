//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Experimental.BaseObjects;

//namespace Experimental.GraphProblems
//{
//    /// <summary>
//    /// Grapg Traversals
//    /// </summary>
//    public class GraphTraversals
//    {
//        /// <summary>
//        /// Visiting Graph Nodes using BreathFirstTraversal
//        /// This is Non recursive always
//        /// This is done Iteratively not recursively
//        /// Uses a Queue to process and visit the nodes
//        /// </summary>
//        /// <param name="root"></param>
//        public void VisitAllNodesUsingBfs(GraphNode root)
//        {
//            if(root == null)
//                return;
//            var queue = new Queue<GraphNode>();
//            root.IsVisited = true;
//            queue.Enqueue(root);

//            while (queue.Count > 0)
//            {
//                var r = queue.Dequeue();
//                Console.WriteLine(r.Name);
//                foreach (var node in r.Children.Where(node => !node.IsVisited))
//                {
//                    node.IsVisited = true;
//                    queue.Enqueue(node);
//                }
//            }
//        }


//        /// <summary>
//        /// Visits Graph's all Nodes 
//        /// Basic DFS algorithm to traverse graph
//        /// Always Recursive is best for DepthFirstTraversal
//        /// DFS is best using Recursive
//        /// </summary>
//        /// <param name="root"></param>
//        public void VisitAllNodesUsingDfs(GraphNode root)
//        {
//            if(root == null)
//                return;
//            Console.Write("Visiting Node : " + root.Name);
//            root.IsVisited = true;

//            foreach (var child in root.Children.Where(child => !child.IsVisited))
//            {
//                VisitAllNodesUsingDfs(child);
//            }
//        }

//        /// <summary>
//        /// Check if there is a path between start and end
//        /// using a Queue do a BFS traversal untill start==end
//        /// else return false.
//        /// </summary>
//        /// <param name="root"></param>
//        /// <param name="start"></param>
//        /// <param name="end"></param>
//        /// <returns></returns>
//        public bool FindIfPathExisitsBetweenTwoNodes(Graph root, GraphNode start, GraphNode end)
//        {
//            if (root == null)
//                return false;
//            if (start == end)
//                return true;

//            var queue = new Queue<GraphNode>();
//            foreach (var node in root.Nodes)
//            {
//                node.IsVisited = false;
//            }
//            queue.Enqueue(start);
//            while (queue.Count > 0)
//            {
//                var node = queue.Dequeue();
//                if (node == null) continue;
//                foreach (var n in node.Children.Where(current => current.IsVisited == false))
//                {
//                    if (n == end)
//                        return true;
//                    n.IsVisited = true;
//                    queue.Enqueue(n);
//                }
//            }
//            return false;
//        }
//    }
//}
