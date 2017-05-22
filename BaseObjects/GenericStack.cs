using System;

namespace Experimental.BaseObjects
{
    /// <summary>
    /// GenericStack
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class GStack<T>
    {
        public static Gnode<T> gNode;
        public static int size = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        static GStack()
        {
            gNode = new Gnode<T>();
        }

        /// <summary>
        /// Generic Push Stack
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pushData"></param>
        /// <returns></returns>
        public static Gnode<T> Push(Gnode<T> node, T pushData)
        {
            Console.WriteLine($"\n ******************** Pushing {pushData} into Stack ******************** \n");
            if (node == null)
            {
                var nodeStack = new Gnode<T>
                {
                    Data = pushData,
                    Next = null
                };
                size++;
                return nodeStack;
            }
            var stack = new Gnode<T>
            {
                Data = pushData,
                Next = node
            };
            node = stack;
            size++;
            return stack;
        }

        /// <summary>
        /// Generic Pop
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Gnode<T> Pop(Gnode<T> node)
        {            
            if (node == null)
            {
                throw new InsufficientExecutionStackException();
            }            
            node = node.Next;
            size--;
            return node;
        }

        /// <summary>
        /// Generic Peek
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static T Peek(Gnode<T> node)
        {
            Console.WriteLine($"\n ******************** Popping from Stack ******************** \n");
            if (node == null)
            {
                throw new InsufficientExecutionStackException();
            }
            Console.WriteLine("Current Peek Value is : " + node.Data);
            return node.Data;
        }
    }
}
