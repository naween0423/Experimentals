using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimental.BaseObjects;

namespace Experimental.ArrayProblems
{
    
    /// <summary>
    /// Find Right Range interval
    /// https://leetcode.com/articles/find-right-interval/
    /// </summary>
    public static class FindRightRangeIntercept
    {

        /// <summary>
        /// returns an array of indices where the 
        /// right range has been found
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[] FindRightIntervalUsingBinarySearch(Interval[] intervals)
        {
            if (intervals.Length == 0)
                return null;

            int[] res = new int[intervals.Length];
            Dictionary<Interval, int> hash = new Dictionary<Interval, int>();
            for (int i = 0; i < intervals.Length; i++)
                hash.Add(intervals[i], i);

            Array.Sort(intervals);

            for(int i = 0; i < intervals.Length; i++)
            {
                Interval interval = BinarySearch(intervals, intervals[i].end, 0, intervals.Length);
            }
            return res;                
        }

        /// <summary>
        /// does binary search
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="target"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static Interval BinarySearch(Interval[] intervals, int target, int start, int end)
        {
            if(start > end)
            {
                if(intervals[start].start == target)
                {
                    return intervals[start];
                }
                return null;
            }

            int mid = start + end / 2;

            if(intervals[mid].start > target)
            {
                return BinarySearch(intervals, target, start, mid - 1);
            }
            else
            {
                return BinarySearch(intervals, target, mid + 1, end);
            }
        }


        /// <summary>
        /// Finds the right intervel from the list of intervals
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[] FindRightIntervelUsingHashMap(Interval[] intervals)
        {
            if (intervals.Length == 0)
                return null;
            
            Dictionary<Interval, int> hash = new Dictionary<Interval, int>();
            int[] res = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
                hash.Add(intervals[i], i);

            Array.Sort(intervals);

            //From first interval
            for(int i = 0; i < intervals.Length; i ++)
            {
                int min = int.MaxValue;
                int minIndex = -1;
                //From second interval
                for(int j =1; j < intervals.Length; j++)
                {
                    if(intervals[i].end <= intervals[j].start && intervals[j].start < min)
                    {
                        min = intervals[j].start;
                        minIndex = hash[intervals[j]];
                    }
                }
                res[hash[intervals[i]]] = minIndex;                
            }
            return res;
        }

        /// <summary>
        /// Find right intervals
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[] FindRightInterval(Interval[] intervals)
        {
            int length = intervals.Length;
            if (length == 0)
                return null;
            Dictionary<int, int> starts = new Dictionary<int, int>();
            Dictionary<int, int> ends = new Dictionary<int, int>();
           
            int[] res = new int[length];

            for(int i = 0; i < length; i++)
            {
                starts.Add(i + 1, intervals[i].start);
                ends.Add(i + 1, intervals[i].end);
            }
            for (int j = 0; j < length; j++)
            {
                res[j] = starts.FirstOrDefault(d => d.Value >= ends[j + 1]).Key -1;
            }
            return res;
        }
    }
}
