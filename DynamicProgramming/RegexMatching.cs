using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.DynamicProgramming
{
    /// <summary>
    /// Regex Matching class
    /// From : https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/RegexMatching.java
    /// Video : https://www.youtube.com/watch?v=l3hda49XcDE
    /// </summary>
    public static class RegexMatching
    {
        /// <summary>
        /// Matches the regest pattern
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool IsRegexMatching(char[] s, char[] p)
        {
            bool[,] T = new bool[s.Length + 1, p.Length + 1];

            T[0, 0] = true;
            //Deals with patterns like a* or a*b* or a*b*c*
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i - 1] == '*')
                {
                    T[0, i] = T[0, i - 2];
                }
            }

            for (int i = 1; i < T.GetLength(0); i++)
            {
                for (int j = 1; j < T.GetLength(1); j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                        T[i, j] = T[i - 1, j - 1];
                    else if (p[j - 1] == '*')
                    {
                        T[i, j] = T[i, j - 2];
                        if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                            T[i, j] = T[i, j] | T[i - 1, j];
                    }
                    else
                        T[i, j] = false;
                }
            }
            Console.WriteLine("Result is : {0}", T[s.Length, p.Length]);
            return T[s.Length, p.Length];
        }
    }
}
