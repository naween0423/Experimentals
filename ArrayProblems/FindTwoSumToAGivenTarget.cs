using System.Collections.Generic;

namespace Experimental
{
    /// <summary>
    /// FindTwoSumToAGivenTarget
    /// </summary>
    public static class FindTwoSumToAGivenTarget
    {
        /// <summary>
        /// InPlacefindTargetSum
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool InPlacefindTargetSum(int[] numbers, int target)
        {
            if (numbers.Length <= 0)
                return false;
            
            for(int i = 0; i < numbers.Length; i++)
            {
                int j = i + 1;
                while (j < numbers.Length)
                {
                    if (target - numbers[i] == numbers[j])
                    {
                        return true;
                    }
                    j++;
                }                
            }
            return false;

        }


        /// <summary>
        /// FindTargetSum
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] FindTargetSum(int[] numbers, int target)
        {
            var result = new int[2];

            var map = new Dictionary<int, int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                if (map.ContainsKey(target - numbers[i]))
                {
                    result[1] = i + 1;
                    result[0] = map[target - numbers[i]];
                    return result;
                }

                if (map.ContainsKey(numbers[i]))
                {
                    continue;
                }
                map.Add(numbers[i], i);
            }
            return result;
        }
    }
}
