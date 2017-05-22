using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Heap
{
    public static class HeapImplementation
    {

        /* Sifting down or deleting an item from the heap
         * 1. Deletes the root item or the most priority item in the heap\tree 
         * 2. Move the last item in the heap which makes it a almost complete binary tree to the root
         * 3. Compare the root with the max of its children and sift down and swap if the root is less than the max of its children.
         * 4. in the process the indices of the children are found using the formula 2k+1 and 2k+2
         */
        public static void SiftDownOrDeleteFromHeap(int[] A)
        {
            int k = 0;
            int l = 2 * k + 1;//Left child

            while(l < A.Length)
            {
                int max = l;
                int r = l + 1;// Right child
                if(r < A.Length) // That means there is a right child
                {
                    if(A[r].CompareTo(A[l]) > 0)
                    {
                        max++; // point max to the right child
                    }
                }
                if (A[k].CompareTo(A[max]) > 0)
                {
                    //Swapp
                    int temp = A[k];
                    A[k] = A[max];
                    A[max] = temp;

                    k = max;//point k to max 
                    l = 2 * k + 1;//calculate left
                }
                else
                    break;
            }
        }




        /*Sifting up or inserting in a heap 
    	1. Insert at the last index of the array and fins the index of the parent using (K-1)/2 formula.
	    2. If the value at parent index is less than the inserting item and swap the values in the parent index and the newly added index and at every stage calculate the Parent index and swap if the parent values is less than the item getting inserted.
        */
        public static void SiftUpOrInsertIntoHeap(int[] A, int newItem)
        {
            int K = A.Length - 1;
            // Check if the input array is empty
            if (K <= 0)
            {
                //If empty insert at the first element
                A[0] = newItem;
                return;
            }
            else
            {
                A[K] = newItem;
            }

            //Compute p and swap if newItem is greater than item at parent
            while (K > 0)
            {
                int p = (K - 1) / 2;
                int item = A[K];

                int parent = A[p];

                if (item.CompareTo(parent) > 0)
                {
                    int temp = A[p];
                    A[p] = A[K];
                    A[K] = temp;
                    K = p;
                }
                else
                    break;
            }
        }
    }
}
