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
        /// Cheks if s string s1 is interleaving with string s2 to form s3
        /// https://leetcode.com/articles/interleaving-strings/
        /// Time : O(m*n)
        /// Space: O(n) where n is the length of s1
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static bool IsInterleaving(string s1, string s2, string s3)
        {
            if (s3.Length != s1.Length + s2.Length)
                return false;

            bool[] dp = new Boolean[s2.Length + 1];

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
    }
}
