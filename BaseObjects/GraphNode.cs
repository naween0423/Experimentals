using System;
using System.Collections.Generic;

namespace Experimental.BaseObjects
{

    /// <summary>
    /// GraphNode class
    /// </summary>
    public class GraphNode
    {
        /// <summary>
        /// Name of the graph node
        /// </summary>
        public string Name;

        /// <summary>
        /// flag to check if it was visited
        /// </summary>
        public bool IsVisited;

        /// <summary>
        /// Graph constructor
        /// </summary>
        /// <param name="name"></param>
        public GraphNode(string name)
        {
            Name = name;
            IsVisited = false;
        }
    }

    /// <summary>
    /// GraphNode class
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Number of Vertices
        /// </summary>
        private const int MAXVertices = 20;
        
        /// <summary>
        /// Children of the Node
        /// </summary>
        private GraphNode[] Children;

        /// <summary>
        /// adjacent matrix
        /// </summary>
        private int[,] AdjacentM;
        
        /// <summary>
        /// Flag to check is visited
        /// </summary>
        private bool IsVisited;

        /// <summary>
        /// number of vertices
        /// </summary>
        private int numberOfVertices;

        /// <summary>
        /// constructor
        /// </summary>
        public Graph()
        {
            Children = new GraphNode[MAXVertices];
            AdjacentM = new int[MAXVertices, MAXVertices];
            numberOfVertices = 0;
            //initialize the adjacent matrix with 0s
            for (int j = 0; j < MAXVertices; j++)
                for (int k = 0; k < MAXVertices - 1; k++)
                    AdjacentM[j, k] = 0;
        }

        /// <summary>
        /// Adding new GraphNode
        /// </summary>
        /// <param name="name"></param>
        public void AddVertex(string name)
        {
            Console.WriteLine("Adding Vertex {0} to the graph", name);
            Children[numberOfVertices] = new GraphNode(name);
            numberOfVertices++;
        }

        /// <summary>
        /// Adds an edge between 2 given nodes
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void AddEdge(int start, int end)
        {
            Console.WriteLine("Adding an Edge between {0} and {1}", start, end);
            AdjacentM[start, end] = 1;
            AdjacentM[end, start] = 1;
        }

        /// <summary>
        /// Get all the unvisited adjacent nodes 
        /// </summary>
        /// <param name="vIndex"></param>
        /// <returns></returns>
        public List<GraphNode> GetAdjUnvisitedVertices(int vIndex)
        {
            if (vIndex > MAXVertices || vIndex < 0)
                return null;

            List<GraphNode> adjacentNodes = new List<GraphNode>();

            for(int i = 0; i < numberOfVertices; i++)
            {
                if(AdjacentM[vIndex, i] == 1 && !Children[i].IsVisited )
                {
                    adjacentNodes.Add(Children[i]);
                    Children[i].IsVisited = true;
                    Console.WriteLine("The Node {0} is connected with {1} node.", Children[vIndex].Name, Children[i].Name);
                }
            }            
            return adjacentNodes;
        } 

        /// <summary>
        /// Checks if a path exists between given 2 nodes using DFS
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        /// <returns></returns>
        public bool DFSCheckIfPathExixtsBtwNodes(int vertex1, int vertex2)
        {
            if ((vertex1 > numberOfVertices || vertex1 < 0) && (vertex2 > numberOfVertices || vertex2 < 0))
                return false;

            Stack<GraphNode> stack = new Stack<GraphNode>();
            stack.Push(Children[vertex1]);
            while(stack.Count > 0)
            {
                var item = stack.Pop();
                if(item == Children[vertex2])
                {                    
                    return true;
                }
                else
                {
                    var adjacents = GetAdjUnvisitedVertices(Array.IndexOf(Children, item));
                    foreach(var adjacent in adjacents)
                    {
                        stack.Push(adjacent);
                        adjacent.IsVisited = true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Checks of there is a path bwt 2 given nodes using BFS
        /// </summary>
        /// <param name="vertex1"></param>
        /// <param name="vertex2"></param>
        /// <returns></returns>
        public bool BFSCheckIfPathExistsBtwNodes(int vertex1, int vertex2)
        {
            if ((vertex1 > numberOfVertices || vertex1 < 0) && (vertex2 > numberOfVertices || vertex2 < 0))
                return false;

            Queue<GraphNode> queue = new Queue<GraphNode>();
            queue.Enqueue(Children[vertex1]);
            Children[vertex1].IsVisited = true;

            while(queue.Count > 0)
            {
                var item = queue.Dequeue();
                if(item == Children[vertex2])
                {
                    return true;
                }
                var adjacents = GetAdjUnvisitedVertices(Array.IndexOf(Children, item));
                foreach (var adjacent in adjacents)
                {
                    queue.Enqueue(adjacent);
                    adjacent.IsVisited = true;
                }                        
            }
            return false;
        }


        /// <summary>
        /// Prints the name of the Vertex
        /// </summary>
        /// <param name="vIndex"></param>
        public void ShowVertex(int vIndex)
        {
            Console.WriteLine("The Vertex at the index {0} is : {1}", vIndex, Children[vIndex].Name);
            Console.WriteLine(Children[vIndex].Name);
        }
    }
}
