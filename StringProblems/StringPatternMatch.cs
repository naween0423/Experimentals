using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.StringProblems
{
    /// <summary>
    /// Pattern match class
    /// </summary>
    public static class StringPatternMatch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool IsMatch(String s, String p)
        {
            /*
                'match' below including .
            f(i,j) means s where s.len=i matches p where p.len=j
            f(i,j) =
                if (p_j-1 != * ) f(i-1, j-1) and s_i-1 matches p_j-1
                if (p_j-1 == * )
                    * matches zero times: f(i,j-2)
                    or * matches at least one time: f(i-1,j) and s_i-1 matches p_j-2
             */

            if (!string.IsNullOrEmpty(p) && p[0] == '*')
            {
                return false;   // invalid p
            }

            bool[,] f = new bool[s.Length + 1, p.Length + 1];

            // initialize f(0,0)
            f[0, 0] = true;

            // f(k,0) and f(0,2k-1) where k>=1 are false by default
            // initialize f(0,2k) where p_2k-1 = * for any k>=1
            for (int j = 1; j < p.Length; j += 2)
            {
                if (p[j] == '*')
                {
                    f[0, j + 1] = f[0,j - 1];
                }
            }

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (p[j - 1] != '*')
                    {
                        f[i,j] = f[i - 1,j - 1] && IsCharMatch(s[i - 1], p[j - 1]);
                    }
                    else
                    {
                        f[i,j] = f[i,j - 2] || f[i - 1, j] && IsCharMatch(s[i - 1], p[j - 2]);
                    }
                }
            }

            return f[s.Length, p.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        // no * in p
        private static bool IsCharMatch(char s, char p)
        {
            return p == '.' || s == p;
        }
    }
}
