using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.TreeProblems
{
    /// <summary>
    /// MinMax Class returned from every node to the previous\root Node
    /// </summary>
    public class MinMaX
    {
        public int Min;
        public int Max;
        public bool IsBST;
        public int Size;
    }


    /// <summary>
    /// Lartest BST in a given BT
    ///  * Video link - https://youtu.be/4fiDs7CCxkc
    //*
    //* Given a binary tree, find size of largest binary search subtree in this
    //* binary tree.
    //* 
    //* Traverse tree in post order fashion.Left and right nodes return 4 piece
    //* of information to root which isBST, size of max BST, min and max in those
    //* subtree. 
    //* If both left and right subtree are BST and this node data is greater than max
    //* of left and less than min of right then it returns to above level left size +
    //* right size + 1 and new min will be min of left side and new max will be max of
    //* right side.
    /// </summary>
    public static class LargestBSTinABT
    {
        public static int LargestBST(Tree root)
        {
            MinMaX m = LargestBSTree(root);
            return m.Size;
        }

        /// <summary>
        /// returns the largest BST in a BT
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private static MinMaX LargestBSTree(Tree root)
        {
            if (root == null)
                return new MinMaX();

            MinMaX leftMinMax = LargestBSTree(root.Left);
            MinMaX rightMinMax = LargestBSTree(root.Right);

            MinMaX current = new MinMaX();

            if(leftMinMax.IsBST == false || rightMinMax.IsBST == false || (leftMinMax.Max > root.Data) || (rightMinMax.Min < root.Data))
            {
                current.IsBST = false;
                current.Size = Math.Max(leftMinMax.Size, rightMinMax.Size);
                return current;
            }

            current.IsBST = true;
            current.Size = leftMinMax.Size + rightMinMax.Size + 1;

            current.Min = root.Left != null ? leftMinMax.Min : root.Data;
            current.Max = root.Right != null ? rightMinMax.Max : root.Data;

            return current;
        }
    }    
}
