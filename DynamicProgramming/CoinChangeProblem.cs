using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.DynamicProgramming
{
    /// <summary>
    /// Coin change Problem
    /// </summary>
    public static class CoinChangeProblem
    {
        /// <summary>
        /// minCount
        /// </summary>
        public static int minCount = int.MaxValue;

        /// <summary>
        /// coin Change
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static int coinChange(int[] coins, int amount)
        {
            Array.Sort(coins);
            Count(amount, coins.Length - 1, coins, 0);
            return minCount == int.MaxValue ? -1 : minCount;
        }

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="index"></param>
        /// <param name="coins"></param>
        /// <param name="count"></param>
        public static void Count(int amount, int index, int[] coins, int count)
        {
            if(amount % coins[index] == 0)
            {
                int newCount = count + amount / coins[index];
                if (newCount < minCount)
                    minCount = newCount;
            }

            //if all coins are done
            if (index == 0)
                return;

            // i : number of coins[index] 
            // newAmount : difference amount after amount-coint[index]
            // newCount : new count of coins
            // nextCoin : next index coin
            for(int i= amount/coins[index]; i >= 0; i--)
            {
                int newAmount = amount - i * coins[index];
                int newCount = count + i;

                int nextCoin = coins[index - 1];
                if (newCount + (newAmount + nextCoin - 1) / nextCoin >= minCount)
                    break;

                Count(newAmount, index - 1, coins, newCount);
            }
        }
    }
}
