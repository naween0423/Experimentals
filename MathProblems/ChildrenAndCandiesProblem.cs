using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.ArrayProblems
{
    /// <summary>
    /// Number of Candies
    /// </summary>
    public static class ChildrenAndCandiesProblem
    {
        /// <summary>
        /// gets sum of n integers
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Count(int n)
        {
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// https://leetcode.com/articles/candy/
        /// gets number of candies in best possible way
        /// Time : O(n)
        /// Space : O(1)
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public static int GetNumberOfCandies(int[] ratings)
        {
            if (ratings.Length == 0)
                return -1;

            int candies = 0;
            int up = 0;
            int down = 0;
            int old_Slope = 0;

            for (int i = 1; i < ratings.Length; i++)
            {
                int new_slope = ratings[i] > ratings[i - 1] ? 1 : ((ratings[i] < ratings[i - 1]) ? -1 : 0);
                //When the slope is 1 -> mving Up
                //When the slope is -1 -> moving down
                //When the slope is 0 -> staying constant
                if ((old_Slope > 0 && new_slope == 0) || old_Slope < 0 && new_slope >= 0)
                {
                    candies += Count(up) + Count(down) + Math.Max(up, down);
                    up = 0;
                    down = 0;
                }

                if (new_slope > 0)
                    up++;
                if (new_slope < 0)
                    down++;
                if (new_slope == 0)
                    candies++;

                old_Slope = new_slope;

                candies += Count(up) + Count(down) + Math.Max(up, down);
            }
            return candies;
        }



        /// <summary>
        /// gets number Candies needed to 
        /// make the order such that current child had 
        /// greater than the neighbours
        /// Time : O(n)
        /// Space : O(n)
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public static int GetNumberCandies(int [] ratings)
        {
            if (ratings.Length == 0)
                return -1;

            int[] candies = new int[ratings.Length];
            //Intially all chindern are given 1 candy
            for (int i = 0; i < candies.Length; i++)
                candies[i] = 1;

            for(int i = 1; i < ratings.Length; i++)
            {
                if(ratings[i] > ratings[i-1])
                {
                    candies[i] = candies[i - 1] + 1;
                }                
            }
            int sum = candies[ratings.Length - 1];
            for(int i = ratings.Length -2; i >= 0; i --)
            {
                if(ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
                sum += candies[i];
            }

            return sum;
        }
    }
}
