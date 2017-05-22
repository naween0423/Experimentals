using System;

namespace Experimental
{
    public static class GeoMetricProgression
    {
        public static void FindGeometricTriplets(int []arr, int n)
        {
            // One by fix every element as middle element
            for (int j = 1; j < n - 1; j++)
            {
                // Initialize i and k for the current j
                int i = j - 1, k = j + 1;

                // Find all i and k such that (i, j, k)
                // forms a triplet of GP
                while (i >= 0 && k <= n - 1)
                {
                    // if arr[j]/arr[i] = r and arr[k]/arr[j] = r
                    // and r is an integer (i, j, k) forms Geometric
                    // Progression
                    while (arr[j] % arr[i] == 0 &&
                            arr[k] % arr[j] == 0 &&
                            arr[j] / arr[i] == arr[k] / arr[j])
                    {
                        // print the triplet
                        Console.Write("[{0}, {1}, {2}]\n", arr[i] ,arr[j] ,arr[k]);
                        // Since the array is sorted and elements
                        // are distinct.
                        k++;                                          
                    }

                    // if arr[j] is multiple of arr[i] and arr[k] is
                    // multiple of arr[j], then arr[j] / arr[i] !=
                    // arr[k] / arr[j]. We compare their values to
                    // move to next k or previous i.
                    if (arr[j] % arr[i] == 0 &&
                            arr[k] % arr[j] == 0)
                    {
                        if (arr[j] / arr[i] < arr[k] / arr[j])
                            i--;
                        else k++;
                    }
                    // else if arr[j] is multiple of arr[i], then
                    // try next k. Else, try previous i.
                    else if (arr[j] % arr[i] == 0)
                    {
                        k++; 
                    }
                    else
                    {
                        i--;                        
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        public static void PrintSumTripletForAGivenValue(int []arr, int sum)
        {
            if (arr.Length < 3)
            {
                return;
            }
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == sum)
                        {
                            Console.Write("[{0}, {1}, {2}]\n", arr[i], arr[j], arr[k]);                            
                        }
                    }
                }

            }
        }

        public static void PrintGeometricProgressionTriplets(int[] arr)
        {
            if(arr.Length < 3)
            {
                return;
            }            

            int count = 0;

            for (int i = 0; i < arr.Length-2; i++)
            {
               for(int j = i+1; j < arr.Length -1; j++)
                {
                    for(int k = j+1; k < arr.Length; k++)
                    {
                        if(arr[j] % arr[i] == 0 && arr[k] % arr[j] == 0 && arr[j]/arr[i] == arr[k]/arr[j])
                        {
                            Console.Write("[{0}, {1}, {2}]\n", arr[i], arr[j], arr[k]);
                            k++;
                        }
                    }
                }    

            }
            Console.WriteLine("Number of Iterations : {0}", count);
        }
    }
}
