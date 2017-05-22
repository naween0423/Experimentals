using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.StringProblems
{
    /// <summary>
    /// Perms
    /// </summary>
    public static class PermsAndCombs
    {
        /// <summary>s
        /// Given a string gives all permutations of that string
        /// </summary>
        /// <returns></returns>
        public static void Permutations(string S)
        {
            int length = S.Length;

            bool[] used = new bool[length];

            StringBuilder output = new StringBuilder();

            PermutateString(S, length, output, used, 0);
        }

        /// <summary>
        /// prints all permutations of a given string
        /// </summary>
        /// <param name="S"></param>
        /// <param name="length"></param>
        /// <param name="output"></param>
        /// <param name="used"></param>
        /// <param name="position"></param>
        public static void PermutateString(string S, int length, StringBuilder output, bool[] used, int position)
        {
            if(position == length)
            {
                Console.WriteLine(output.ToString());
                return;
            }
            else
            {
                for(int i =0; i < length; i++)
                {
                    if (used[i])
                        continue;

                    output.Append(S[i]);
                    used[i] = true;

                    PermutateString(S, length, output, used, position + 1);
                    output.Remove(output.Length - 1, 1);
                    used[i] = false;
                }
            }
        }


        /// <summary>
        /// permutateDupes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<string> PermutateDupes(char[] input)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();

            foreach (char a in input)
            {
                if (countMap.ContainsKey(a))
                {
                    countMap[a]++;
                }
                else
                {
                    countMap.Add(a, 1);
                }
            }
            char[] str = new char[countMap.Count];
            int[] count = new int[countMap.Count];

            int index = 0;

            foreach (var key in countMap.Keys)
            {
                str[index] = key;
                count[index] = countMap[key];
                index++;
            }

            List<string> resultList = new List<string>();
            char[] result = new char[input.Length];
            PermutationWithDupes(str, count, result, 0, resultList);
            return resultList;
        }

        /// <summary>
        /// permutationWithDupes
        /// </summary>
        /// <param name="S"></param>
        /// <param name="count"></param>
        /// <param name="result"></param>
        /// <param name="level"></param>
        /// <param name="resultList"></param>
        public static void PermutationWithDupes(char[] S, int[] count, char[] result, int level, List<string> resultList)
        {
            if (level == result.Length)
            {
                resultList.Add(new string(result));
                Console.WriteLine(result);
                return;
            }

            for (int i = 0; i < S.Length; i++)
            {
                if (count[i] == 0)
                    continue;

                result[level] = S[i];
                count[i]--;
                PermutationWithDupes(S, count, result, level + 1, resultList);
                count[i]++;
            }
        }

        /// <summary>
        /// Combinations
        /// </summary>
        /// <param name="S"></param>
        public static void Combinations(string S)
        {
            int length = S.Length;

            int allowedChar = 0;
            StringBuilder output = new StringBuilder(length);
            Combinator(S, length, output, allowedChar);
        }


        /// <summary>
        /// Combinations of a String
        /// </summary>
        /// <param name="S"></param>
        /// <param name="length"></param>
        /// <param name="output"></param>
        /// <param name="allowedChar"></param>
        public static void Combinator(string S, int length, StringBuilder output, int allowedChar)
        {
            if (allowedChar == length)
            {
                return;
            }
            else
            {
                for (int curr = allowedChar; curr < length; curr++)
                {
                    output.Append(S[curr]);
                    Console.WriteLine(output.ToString());
                    Combinator(S, length, output, allowedChar + 1);
                    output.Remove(output.Length - 1, 1);
                }
            }
        }

        /// <summary>
        /// Combinations of a String
        /// </summary>
        /// <param name="maxLength"></param>
        /// <param name="alphabets"></param>
        /// <param name="current"></param>
        public static void CombinationsString(int maxLength, char[] alphabets, string current)
        {
            if (current.Length == maxLength)
                Console.WriteLine(current);
            else
            {
                for(int i = 0; i < alphabets.Length; i++)
                {
                    String oldcur = current;
                    current += alphabets[i];
                    CombinationsString(maxLength, alphabets, current);
                    current = oldcur;
                }
            }
        }
    }


    /// <summary>
    /// Simple Combination
    /// </summary>
    public static class Combinations2
    {
        // print all subsets of the characters in s
        public static void comb1(String s) { Comb1("", s); }

        /// <summary>
        /// print all subsets of the remaining elements, with given prefix 
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="s"></param>
        public static void Comb1(String prefix, String s)
        {
            if (s.Length > 0)
            {
                Console.WriteLine(prefix + s[0]);
                Comb1(prefix + s[0], s.Substring(1));
                Comb1(prefix, s.Substring(1));
            }
        }

        /// <summary>
        /// alternate implementation
        /// </summary>
        /// <param name="s"></param>
        public static void comb2(String s) { Comb2("", s); }
        public static void Comb2(String prefix, String s)
        {
            Console.WriteLine(prefix);
            for (int i = 0; i < s.Length; i++)
                Comb2(prefix + s[i], s.Substring(i + 1));
        }

        /// <summary>
        /// /**
        /// * Generate all combination of size k and less of adjacent numbers
        ///  * e.g 1,2,3,4 k = 2
        ///  * 1 2 3 4
        ///  * 12 3 4
        ///  * 1 23 4
        ///  * 1 2 34
        ///  * 12 34
        ///  * @author tusroy
        ///  *
        /// */
        /// </summary>
        /// <param name="S"></param>
        public static void AllAdjacentCombination(int[] input, int k)
        {
            int[] result = new int[input.Length];
            AllAdjacentCombs(input, result, k, 0, 0);

        }

        /// <summary>
        /// AllAdjacentCombs
        /// </summary>
        /// <param name="input"></param>
        /// <param name="result"></param>
        /// <param name="pos"></param>
        /// <param name="r"></param>
        public static void AllAdjacentCombs(int[] input, int[] result, int k, int pos, int r)
        {
            if (pos == input.Length)
            {
                for (int i = 0; i < r; i++)
                    Console.Write(result[i] + " ");
                Console.WriteLine("");
                return;
            }
            for (int i = pos; i < pos + k && i < input.Length; i++)
            {
                result[r] = FormNumber(input, pos, i);
                AllAdjacentCombs(input, result, k, i + 1, r + 1);
            }
        }

        /// <summary>
        /// Forms the number
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int FormNumber(int[] input, int start, int end)
        {
            int num = 0;
            for (int i = start; i <= end; i++)
            {
                num = num * 10 + input[i];
            }
            return num;
        }
    }
}
