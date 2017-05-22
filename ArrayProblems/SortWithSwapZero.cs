using System;
using System.Linq;

namespace Experimental
{
    public static class SortWithSwapZero
    {

        public static void MoveToFront(int[] arr, int i)
        {
            if (i > arr.Length-1 || i < 1)
            {
                return;
            }

            var t = arr[i];
            while (i > 0)
            {
                arr[i] = arr[i - 1];
                --i;
            }
            arr[i] = t;
        }

        public static int SortUsingMoveToFront(int[] arr)
        {
            int calls = 0;

            while (true)
            {
                var max = Int32.MinValue;
                var maxI = 0;
                for (var i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] < arr[0] && arr[i] > max)
                    {
                        maxI = i;
                        max = arr[i];
                    }
                }
                if (maxI == 0)
                {
                    break;
                }
                MoveToFront(arr, maxI);
                calls++;
            }

            PrintArray(arr);
            return calls;
        }




        public static void SortBySwapWithZero()
        {
            int[] array = { 12, -10, 9, 11};
            var max = 0;

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i; j < array.Length; j++)
                {
                    if (j == i)
                    {
                        max = i;
                    }
                    else
                    {
                        if (array[max] < array[j])
                        {
                            max = j;
                        }
                    }
                }

                array = SwapToZeroth(max, array);
            }

            //for (var start = 0; start < array.Length; start++)
            //{
            //    for (var i = start + 1 ; i < array.Length; i++)
            //    {
            //        if (array[i] > array[start])
            //        {
            //            if(array[i] > max)
            //                max = array[i];
            //        }
            //        else
            //        {
            //            if (array[i] > max)
            //            {
            //                max = array[start];
            //                array = SwapToZeroth(start, array);
            //                array = SwapToZeroth(array.Length - 1, array);
            //            }
            //            else
            //            {

            //            }
            //        }
            //    }
            //}

            PrintArray(array);
        }

        public static int[] SwapToZeroth(int n, int[]arr)
        {
            if (arr.Length < n)
                return arr;
            var temp = arr[n];
            arr[n] = arr[0];
            arr[0] = temp;

            return arr; 
        }

        public static void PrintArray(int[] arr)
        {
            for(var i=0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }



    }
}
