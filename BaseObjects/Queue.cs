using System;
using System.Collections.Generic;

namespace Experimental.BaseObjects
{
    public class Queue
    {
       public Node Node;      

    }

    /// <summary>
    /// Myqueue
    /// </summary>
    public class Myqueue
    {
        Stack<int> S1 = new Stack<int>();
        Stack<int> S2 = new Stack<int>();

        /// <summary>
        /// Enqueue
        /// </summary>
        /// <param name="v"></param>
        public void Enqueue(int v)
        {
            S1.Push(v);
        }

        /// <summary>
        /// Dequeue
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (S1.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            while (S1.Count != 0)
            {
                S2.Push(S1.Pop());
            }

            int value = S2.Pop();

            while (S2.Count != 0)
            {
                S1.Push(S2.Pop());
            }

            return value;
        }
    }
}
