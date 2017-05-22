using System;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// Stack
    /// </summary>
    public static class Stack
    {
        public static Node Node;
        public static int size = 0;

        /// <summary>
        /// .Constructur
        /// </summary>
        static Stack()
        {
            Node = new Node();
        }

        /// <summary>
        /// Peek
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Peek(Node node)
        {
            Console.WriteLine($"\n ******************** Popping from Stack ******************** \n");
            if (node == null)
            {
                throw new InsufficientExecutionStackException();
            }
            Console.WriteLine("Current Peek Value is : " + node.Data);
            return node.Data;
        }

        /// <summary>
        /// Pop
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Node Pop(Node node)
        {
            Console.WriteLine($"\n ******************** Popping from Stack ******************** \n");
            if (node == null)
            {
                throw new InsufficientExecutionStackException();
            }
            Console.WriteLine("Popping the value " + node.Data);
            node = node.Next;
            size--;
            return node;
        }

        /// <summary>
        /// Push
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pushData"></param>
        /// <returns></returns>
        public static Node Push(Node node, int pushData)
        {
            Console.WriteLine($"\n ******************** Pushing {pushData} into Stack ******************** \n");
            if (node == null)
            {
                var nodestack = new Node
                {
                    Data = pushData,
                    Next = null
                };
                size++;
                return nodestack;
            }
            var stack = new Node
            {
                Data = pushData,
                Next = node
            };
            node = stack;
            size++;
            return stack;
        }
        
               
        ///// <summary>
        ///// GetStackSize
        ///// </summary>
        ///// <param name="node"></param>
        ///// <returns></returns>
        //public static int GetStackSize(Node node)
        //{
        //    if (node == null)
        //        return -1;
        //    Node runner = node;
        //    int count = 1;
        //    while (runner.Next != null)
        //    {
        //        count++;
        //        runner.Next = runner.Next.Next;
        //    }
        //    Console.WriteLine($"\n ******************** Number of elments in the Stack currently are : {count}******************** \n");
        //    return count;
        //}
    }
}
