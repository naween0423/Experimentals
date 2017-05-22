using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    public static class MinHeightBstFromSortedArray
    {
        //1) Get the Middle of the array and make it root.
        //2) Recursively do same for left half and right half.
        //    a) Get the middle of left half and make it left child of the root
        //        created in step 1.
        //    b) Get the middle of right half and make it right child of the
        //        root created in step 1.

        /// <summary>
        /// CreateMinHeightBST
        /// Recusrsive method 
        /// mid is the root
        /// left subarray is left tree 0 - mid-1
        /// right subarray is right subtree mid+1 - end
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static Tree CreateMinHeightBst(int[] arr, int start, int end)
        {
            if (arr.Length <= 0)
                return null;

            var mid = (start + end)/2;
            var treeNode = new Tree
            {
                Data = arr[mid],
                Left = CreateMinHeightBst(arr, 0, mid - 1),
                Right = CreateMinHeightBst(arr, mid + 1, end)
            };
            return treeNode;
        }

        /// <summary>
        /// Create min Height BST iteratively using stack
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static Tree IterativelyCreateMinHeaghtBST(int [] arr)
        //{
        //    if (arr !=null || arr.Length == 0)
        //        return null;

        //    Tree root = new Tree();
        //    int start = 0;
        //    int end = arr.Length - 1;
        //    int mid = (start + end) / 2;
        //    root.Data = arr[mid];

        //    Stack<Tree> stack = new Stack<Tree>();
        //    stack.Push(root);
        //    while(start < )
        //    {
        //        start = 
        //        mid = (start + end) / 2;
        //        root.Data = arr[mid];
        //        root.Left = null;
        //        root.Right = null;
        //    }
        //}
    }
}
