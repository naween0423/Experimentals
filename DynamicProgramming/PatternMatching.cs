using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.DynamicProgramming
{
    /// <summary>
    /// PatternMatching
    /// * one or more character
    /// ? any one character
    /// From : https://github.com/mission-peace/interview/blob/master/src/com/interview/dynamic/WildCardMatching.java
    /// Video : https://www.youtube.com/watch?v=3ZDZ-N0EPV0&feature=iv&src_vid=l3hda49XcDE&annotation_id=video%3A636565cb-4e56-45b2-92ab-ff91d6e14d4b
    /// </summary>
    public static class PatternMatching
    {
        /// <summary>
        /// PatterMatch
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        public static bool IsPatterMatch(string s, string p)
        {
            char[] str = s.ToCharArray();
            char[] pattern = p.ToCharArray();

            int rightIndex = 0;

            bool isFirst = true;
            for(int i = 0; i < pattern.Length; i++)
            {
                if(pattern[i] == '*')
                {
                    if(isFirst)
                    {
                        pattern[rightIndex++] = pattern[i];
                        isFirst = false;
                    }
                    else
                    {
                        pattern[rightIndex++] = pattern[i];
                        isFirst = true;
                    }
                }
            }

            bool[,] T = new bool[str.Length + 1, rightIndex + 1];

            if (rightIndex > 0 && pattern[0] == '*')
            {
                T[0,1] = true;
            }
            T[0, 0] = true;
            for (int i = 1; i < T.GetLength(0); i++)
            {
                for(int j = 1; j < T.GetLength(1); j++)
                {
                    if (pattern[j - 1] == '?' || str[i - 1] == pattern[j - 1])
                        T[i, j] = T[i - 1, j - 1];

                    else if (pattern[j - 1] == '*')
                        T[i, j] = T[i - 1, j] || T[i, j - 1];

                }
            }
            Console.WriteLine("Result is : {0}", T[str.Length, rightIndex]);
            return T[str.Length, rightIndex];
        }
    }
}
