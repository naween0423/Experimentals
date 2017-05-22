using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Vertex class
    /// </summary>
    public class Vertex
    {
        public bool wasVisited;
        public string label;

        public Vertex(string label)
        {
            this.label = label;
            wasVisited = false;
        }
    }

    /// <summary>
    /// Graph with Vertex represented as Adjacent Matrix
    /// </summary>
    public class GraphVertex
    {
        private const int NUM_VERTICES = 20;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        static int numVerts;

        /// <summary>
        /// constructor
        /// </summary>
        public GraphVertex()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for (int j = 0; j < NUM_VERTICES; j++)
                for (int k = 0; k < NUM_VERTICES - 1; k++)
                    adjMatrix[j, k] = 0;
        }
        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }
        public void AddEdge(int start, int eend)
        {
            adjMatrix[start, eend] = 1;
            adjMatrix[eend, start] = 1;
        }
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + " ");
        }
        private int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j <= numVerts - 1; j++)
                if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited
                == false))
                    return j;
            return -1;
        }
        public void DepthFirstSearch()
        {
            var gStack = new Stack<int>();
            vertices[0].wasVisited = true;
            ShowVertex(0);
            gStack.Push(0);
            int v;
            while (gStack.Count > 0)
            {
                v = GetAdjUnvisitedVertex(gStack.Peek());
                if (v == -1)
                    gStack.Pop();
                else
                {
                    vertices[v].wasVisited = true;
                    ShowVertex(v);
                    gStack.Push(v);
                }
            }
            for (int j = 0; j <= numVerts - 1; j++)
                vertices[j].wasVisited = false;
        }


        public void BreadthFirstSearch()
        {
            Queue<int> gQueue = new Queue<int>();
            vertices[0].wasVisited = true;
            ShowVertex(0);
            gQueue.Enqueue(0);
            int vert1, vert2;
            while (gQueue.Count > 0)
            {
                vert1 = gQueue.Dequeue();
                vert2 = GetAdjUnvisitedVertex(vert1);
                while (vert2 != -1)
                {
                    vertices[vert2].wasVisited = true;
                    ShowVertex(vert2);
                    gQueue.Enqueue(vert2);
                    vert2 = GetAdjUnvisitedVertex(vert1);
                }
            }
            for (int i = 0; i <= numVerts - 1; i++)
                vertices[i].wasVisited = false;
        }

    }


   

}
