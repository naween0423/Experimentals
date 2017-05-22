using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.StringProblems
{
    /// <summary>
    /// String problems
    /// </summary>
    public static class StringProblems
    {


        /// <summary>
        /// Compress the string
        /// 1. aaabbccdd becoms a3b2c2d2
        /// 2. Always use string build.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string CompressString(string S)
        {
            if (S.Length <= 2)
                return S;

            StringBuilder builder = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 1; i < S.Length; i++)
            {
                countConsecutive++;
                if ((i - 1) > S.Length || S[i - 1] != S[i])
                {
                    builder.Append(S[i - 1]);
                    builder.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }
            //Return only the smaller string
            return S.Length > builder.ToString().Length ? builder.ToString() : S;
        }


        /// <summary>
        /// Checks if the give 2 string are one edit apart.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool CheckIfStringAreOneEditPart(string first, string second)
        {
            //Check if the lengths are not difffer by more than 1
            if (Math.Abs(first.Length - second.Length) > 1)
                return false;

            //Get the shorter string 
            string s1 = first.Length < second.Length ? first : second;
            string s2 = first.Length < second.Length ? second : first;

            int index1 = 0;
            int index2 = 0;

            bool foundDifference = false;

            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != second[index2])
                {
                    //Ensure that this is the first difference
                    if (foundDifference)
                        return false;

                    foundDifference = true;

                    //move the pointer on the next Longer string to next character
                    if (s1.Length < s2.Length)
                        index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }


        ///// <summary>
        ///// checks if one of the permutation of a given string 
        ///// is a palindrome
        ///// Basic idea is 
        ///// 1. Strings with even length should have even counts of character
        ///// 2. Strings with Odd length must have one character with odd count
        ///// 3. Coversely a string should have no more than one character with odd occurances
        ///// </summary>
        ///// <param name="S"></param>
        ///// <returns></returns>
        //public static bool CheckIfPermutationIsPalindrome(string S)
        //{


        //}
        /// <summary>
        /// MyRemoveAGivemChar
        /// </summary>
        /// <param name="S"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string MyRemoveAGivemChar(string S, char c)
        {
            if (S == null)
                return null;
            if (S.Length <= 0)
                return S;

            if (S.Length == 1 && S[0] == c)
                return null;

            int current = 0;
            int runner = 1;

            char[] Sc = S.ToCharArray();

            while (runner < Sc.Length)
            {
                if (Sc[current] == c)
                {
                    Sc[current] = Sc[runner];
                    runner++;
                }
                else
                {
                    runner++;
                    current++;
                }
            }
            return new string(Sc).Substring(0, current);
        }

        /// <summary>
        /// RemoveGivenCharacter
        /// </summary>
        /// <param name="str"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string RemoveGivenCharacter(string str, char c)
        {
            int length = str.Length;

            char[] S = str.ToCharArray();

            int current = 0;
            int runner = 1;

            while (runner < length)
            {
                if (S[current] == c)
                {
                    S[current] = S[runner];
                    runner++;
                }
                else
                {
                    current++;
                    runner++;
                }
            }
            return new string(S).Substring(0, current + 1);
        }

        /// <summary>
        /// remove duplicates
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveDuplicatesInAString(string str)
        {
            int length = str.Length;
            if (length < 2)
                return null;
            char[] S = str.ToCharArray();

            int current = 1;

            for (int i = 1; i < length; ++i)
            {
                int j;
                for (j = 0; j < current; ++j)
                {
                    if (S[j] == S[i])
                        break;
                }
                if (j == current)
                {
                    S[current] = S[i];
                    ++current;
                }
            }
            return new string(S).Substring(0, current);
        }

        /// <summary>
        /// Testing Own code for LongestPalindrome
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string GetLongestPalindromeString(string S)
        {
            if (S.Length == 0)
                return null;

            int longestLength = 0;
            string longestPalindrome = "";
            for (int i = 1; i < S.Length - 1; i++)
            {
                int L = i - 1;
                int R = i + 1;

                while (L >= 0 && R < S.Length - 1)
                {
                    if (IsPalindromeString(S.Substring(L, R - L)) && R - L > longestLength)
                    {
                        longestLength = R - L;
                        longestPalindrome = S.Substring(L, R);
                    }
                    else
                    {
                        L--;
                        R++;
                    }
                }
            }
            return longestPalindrome;
        }


        //public static bool IsPalindromeBits(uint aNumber)
        //{
        //    uint numberOfBits = sizeof(uint) * 8;
        //    for (uint i = 1; i <= numberOfBits / 2; ++i)
        //    {
        //        if (((aNumber & (1 << (numberOfBits - i))) ? 1 : 0) == ((aNumber & (1 << (i - 1))) ? 1 : 0))
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        /// <summary>
        /// checks if a given string is Palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindromeString(string str)
        {
            int min = 0;
            int max = str.Length - 1;

            if (min > max)
                return true; // Since Length 0 string is a Palindrome

            while (min < max)
            {
                char a = str[min];
                char b = str[max];

                if (a.ToString().ToLower().Equals(b.ToString().ToLower()))
                {
                    min++;
                    max--;
                }
                else
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Gets Longest palindrome in a given string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetLongestPalindrome(string str)
        {
            if (str.Length == 0)
                return null;

            int pStart = 0;
            int pEnd = 0;
            int pLongest = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int l = i;
                int r = i + 1;

                while (l >= 0 && r < str.Length)
                {
                    if ((IsPalindromeString(str.Substring(l, r - l))) && r - l > pLongest)
                    {
                        pStart = l;
                        pEnd = r;
                        pLongest = r - l;
                    }
                    l--;
                    r++;
                }
            }
            Console.WriteLine("The Longest possible Palindrom for {0} is : {1}", str, str.Substring(pStart, pEnd));
            return str.Substring(pStart, pEnd);
        }


        /// <summary>
        /// Returns first non repeating charcter
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char ReturnFirstNonRepeatingChar(string s)
        {
            if (s.Length <= 0)
                throw new Exception();

            Dictionary<char, int> set = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (set.ContainsKey(s[i]))
                {
                    set[s[i]] += 1;
                }
                else
                {
                    set.Add(s[i], 1);
                }
            }

            foreach (var t in set.Keys)
            {
                if (set[t] == 1)
                {
                    return t;
                }
            }
            throw new Exception();
        }


        /// <summary>
        /// Returns the first repeating character
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string ReturnFirstRepeatedChar(string S)
        {
            if (S.Length <= 0)
                return string.Empty;

            var hash = new Dictionary<int, bool>();
            for (int i = 0; i < 256; i++)
                hash[i] = false;
            for (int i = 0; i < S.Length; i++)
            {
                if (hash[S[i]])
                {
                    return S[i].ToString();
                }
                else
                {
                    hash[S[i]] = true;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// FindTheLongestSubstringWithMDistinctCharacters
        /// </summary>
        /// <param name="str"></param>
        /// <param name="distinctNum"></param>
        public static void FindTheLongestSubstringWithMDistinctCharacters(string str, int distinctNum)
        {
            if (str.Length <= 0)
                return;

            int maxLength = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (map.ContainsKey(str[i]))
                {
                    map[str[i]]++;
                    if (map.Count() > distinctNum)
                    {
                        map.Remove(str[i]);
                        Console.WriteLine(str.Substring(i, map.Sum(k => k.Value)));
                        maxLength = map.Sum(k => k.Value);
                        map.Clear();
                    }
                }
                else
                {
                    if (map.Count() <= distinctNum)
                    {
                        map.Add(str[i], 1);
                        maxLength++;
                    }
                }
            }
            foreach (var t in map.Keys)
                Console.Write(t);
        }




        //if (map.ContainsKey(str[i]))
        //         {
        //             map[str[i]]++;
        //         }
        //         else
        //         {
        //             map.Add(str[i], 1);
        //         }
        //         for (j = i + 1; j<str.Length; j++)
        //         {
        //             if (map.ContainsKey(str[j]))
        //             {
        //                 if (map.Count() <= distinctNum)
        //                 {
        //                     map[str[j]]++;
        //                 }
        //                 else
        //                 {
        //                     map.Add(str[j], 1);
        //                 }
        //                 maxLength++;
        //             }
        //             else
        //             {
        //                 maxLength = map.Sum(k => k.Value);
        //                 Console.WriteLine(str.Substring(i, j));
        //                 map.Clear();
        //                 break;
        //             }
        //         }



        /// <summary>
        /// Revers words in a Sentence
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char[] ReverseWordsInSentence(char[] str)
        {
            if (str.Length <= 0)
                return null;

            var rev = ReverseString(str);
            var position = 0;
            for (var i = 0; i < rev.Length - 1; i++)
            {
                if (rev[i] == ' ')
                {
                    rev = ReverseSubstring(str, position, i - 1);
                    position += i + 1;
                }
            }
            return rev;
        }

        /// <summary>
        /// reverses a Substring with in a string\Sentence 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static char[] ReverseSubstring(char[] str, int start, int end)
        {
            if (str.Length <= 0)
                return null;
            var length = str.Length;
            if (start == end)
                return str;
            if (length - 1 <= start || length - 1 <= end)
                return null;

            for (int i = start; i < end; i++)
            {
                char temp = str[i];
                str[i] = str[end];
                end--;
            }
            return str;
        }

        /// <summary>
        /// Reverse a String
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char[] ReverseString(char[] str)
        {
            if (str.Length <= 0)
                return null;
            int length = str.Length;
            for (var i = 0; i < length / 2; i++)
            {
                char temp = str[i];
                str[i] = str[length - 1 - i];
                str[length - 1 - i] = temp;
            }
            return str;
        }

        //public static string ShufflePackOfCards(int [] pack)
        //{

        //}

        /// <summary>
        /// Check if 2 given strings are Anagrams 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            int[] tracker = new int[256];

            for (int i = 0; i < str1.Length; i++)
            {
                tracker[str1[i]]++;
                tracker[str2[i]]--;
            }
            for (int k = 0; k < tracker.Length - 1; k++)
            {
                if (tracker[k] != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// IsPangram check the input has all alphabets
        /// </summary>
        /// <param name="args"></param>
        public static void IsPangram(string args)
        {
            if (args == null || args.Length <= 0)
            {
                Console.WriteLine("not pangram");
                return;
            }
            if (args.Length < 26)
            {
                Console.WriteLine("not pangram");
                return;
            }

            string S = args.ToLower().Replace(" ", "");
            int length = S.Length;
            bool[] map = new bool[26];

            for (int i = 0; i < 26; i++)
                map[i] = false;

            for (int i = 0; i < length; i++)
            {
                if (!map[S[i] - 'a'])
                {
                    map[S[i] - 'a'] = true;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (!map[i])
                {
                    Console.WriteLine("not pangram");
                    return;
                }
            }
            Console.WriteLine("pangram");
        }
    }
}
