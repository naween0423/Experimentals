using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// string interleaving anothet string
    /// </summary>
    public static class StringInterleaving
    {
        /// <summary>
        /// PrintInterLeaving of al combinations 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="soFar"></param>
        public static void PrintInterLeaving(string s1, string s2, string soFar)
        {
            if ((s1 == null || s1.Length == 0) && (s2 == null || s2.Length == 0))
                return;

            if(s1 == null || s1.Length == 0)
            {
                Console.WriteLine(soFar + s2);
                return;
            }
            if(s2 == null || s2.Length == 0)
            {
                Console.WriteLine(soFar + s1);
                return;
            }
            PrintInterLeaving(s1.Substring(1), s2, soFar + s1[0]);
            PrintInterLeaving(s1, s2.Substring(1), soFar + s2[0]);
        }

        /// <summary>
        /// Cheks if s string s1 is interleaving with string s2 to form s3
        /// https://leetcode.com/articles/interleaving-strings/
        /// Time : O(m*n)
        /// Space: O(n) where n is the length of s1
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static bool IsInterleavingIterative(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length)
                return false;

            bool[] dp = new bool[s2.Length + 1];

            for(int i =0; i <= s1.Length; i++)
            {
                for(int j = 0; j <= s2.Length; j++)
                {
                    if (i == 0 && j == 0)
                        dp[j] = true;

                    else if (i == 0)
                        dp[j] = dp[j - 1] && s2[j - 1] == s3[i + j - 1];

                    else if (j == 0)
                        dp[j] = dp[j] && s1[i - 1] == s3[i + j - 1];

                    else
                        dp[j] = (dp[j] && s1[i - 1] == s3[i + j - 1]) || 
                                (dp[j - 1]) && s2[j - 1] == s3[i + j - 1];
                }
            }

            return dp[s2.Length];
        }

        /// <summary>
        /// IsInterleavingRecurssive
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static bool IsInterleavingRecurssive(string A, string B, string C)
        {
            int a = 0; int b = 0; int c = 0;

            while (c < C.Length)
            {
                if (a < A.Length && C[c] == A[a])
                    a++;

                else if (b < B.Length && C[c] == B[b])
                    b++;
                else
                    return false;
                c++;
            }

            if((a != A.Length) || (b != B.Length))
            {
                return false;
            }

            return true;
        }
    }
}
