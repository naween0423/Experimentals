using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    public class SortTwoSeperateSortedArraysIntoOne
    {
        /// <summary>
        /// Merges 2 sorted array into 1
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[] MergeSortedArrays(int[] A, int[] B)
        {
            int Alength = A.Length;
            int Blength = B.Length;

            if (Alength <= 0)
                return B;
            else if (Blength <= 0)
                return A;
            else
            {
                int i = 0, j = 0, k = 0;
                int[] C = new int[Alength + Blength - 1];
                for(k = 0; k < Alength+Blength -1 && j < Blength && i < Alength; k++)
                {                    
                    if(A[i] < B[j])
                    {
                        C[k] = A[i];
                        i++;
                    }
                    else if(A[i] > B[j])
                    {
                        C[k] = B[j];
                        j++;
                    }               
                    else
                    {
                        if(A[i] == B[j])
                        {
                            C[k] = A[i];
                            C[k + 1] = B[j];
                            i++; j++;
                        }
                    }                      
                }
                if (i != Alength)
                {
                    for(int x = i; x <= Alength-1 ; x++ )
                    {
                        C[k] = A[x];
                        k++;
                    }
                }
                if(j != Blength)
                {
                    for(int y = j; y <= Blength-1; y++)
                    {
                        C[k] = B[y];
                        k++;
                    }
                }
                return C;
            }            
        }
    }
}
