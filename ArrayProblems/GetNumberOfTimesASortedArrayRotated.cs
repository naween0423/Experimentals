namespace Experimental.ArrayProblems
{
    public static class GetNumberOfTimesASortedArrayRotated
    {

        /// <summary>
        /// rotated_binary_search
        /// </summary>
        /// <param name="A"></param>
        /// <param name="N"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int rotated_binary_search(int []A, int N, int key)
        {
            int L = 0;
            int R = N - 1;

            while (L <= R)
            {
                // Avoid overflow, same as M=(L+R)/2
                int M = L + ((R - L) / 2);
                if (A[M] == key) return M;

                // the bottom half is sorted
                if (A[L] <= A[M])
                {
                    if (A[L] <= key && key < A[M])
                        R = M - 1;
                    else
                        L = M + 1;
                }
                // the upper half is sorted
                else
                {
                    if (A[M] < key && key <= A[R])
                        L = M + 1;
                    else
                        R = M - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Returns the index of the searched iTem
        /// </summary>
        /// <param name="A"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int FindAnElementInARotatedArray(int[] A, int item)
        {
            if (A.Length <= 1)
                return 0;

            int low = 0; 
            int high = A.Length - 1;
            int mid = (low + high) / 2;

            //We found the Item
            if (A[mid] == item)
                return mid;

            while(mid < high)
            {
                //Left half is in correct sorted order
                if(A[mid] > A[low])
                {
                    //Item is in between the low and the mid
                    if(item >= A[low] && item <= A[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        //Item not in between low and mid
                        low = mid + 1;
                    }
                }
                //Left half is not in correct Sorted order
                else if(A[mid] < A[low])
                {
                    //Item is in between mid and high
                    if(item >= A[mid] && item <= A[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        //Item not in between low and mid
                        high = mid - 1;
                    }
                }
                //duplicate items exisiting between low and mid
                else if(A[low] == A[mid])
                {                    
                    if(A[mid] != A[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                mid = (low + high) / 2;                
            }
            return mid;
        }



        public static int FindElementInRotatedArray(int[] A, int target)
        {
            if (A == null)
                return -1;

            if (A.Length <= 0)
                return -1;

            int start = 0;
            int end = A.Length - 1;

            while(start < end)
            {
                int mid = start + (end - start) / 2;

                if (A[mid] == target)
                    return mid;

                else if(A[start] <= A[mid])
                {
                    if(A[start] <= target && target < A[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if(A[mid] <= target && target < A[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
