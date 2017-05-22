using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.StackProblems
{
    /// <summary>
    /// sort using stack
    /// </summary>
    public static class SortUsingStack
    {
        /// <summary>
        /// Sort usingg stack
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public static Stack<int> SortInAscOrder(Stack<int> stack)
        {
            Stack<int> result = new Stack<int>();

            while (stack.Count > 0)
            {
                int temp = stack.Pop();
                while (result.Count > 0 && result.Peek() > temp)
                {
                    stack.Push(result.Pop());
                }
                result.Push(temp);
            }

            return result;
        }

        /// <summary>
        /// Sorting using a Stack
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public static Stack<int> Sortstack(Stack<int> stack)
        {
            Stack<int> NewStack = new Stack<int>();

            int temp = stack.Pop();

            while (stack.Count != 0)
            {
                while ((NewStack.Count != 0) && (NewStack.Peek() > temp))
                {
                    stack.Push(NewStack.Pop());
                }
                NewStack.Push(temp);
            }

            return NewStack;
        }

    }
}
