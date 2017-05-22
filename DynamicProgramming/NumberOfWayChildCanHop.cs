using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimental.BaseObjects;

namespace Experimental.DynamicProgramming
{
    /// <summary>
    /// NumberOfWays
    /// </summary>
    public static class NumberOfWays
    {
        /// <summary>
        /// GetNumberOfWays a Chile can hope and 
        /// climb N steps in 1, 2 and 3 hops
        /// </summary>
        /// <param name="N"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static int GetNumberOfWays(int N, int[] map)
        {
            if (N < 0)
                return 0;
            if (N == 0)
                return 1;
            else if(map[N] > 0)
            {
                return map[N];
            }
            else
            {
                map[N] = GetNumberOfWays(N - 1, map) + 
                         GetNumberOfWays(N - 2, map) + 
                         GetNumberOfWays(N - 3, map);
            }
            return map[N];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Maze"></param>
        /// <returns></returns>
        public static List<Point> GetPath(int[,] Maze)
        {
            if (Maze == null || Maze.GetLength(0) == 0)
                return null;

            List<Point> path = new List<Point>();
            Dictionary<Point, bool> cache = new Dictionary<Point, bool>();

            int lastRow = Maze.GetLength(0);
            int lastCol = Maze.GetLength(1);

            if (GetPathInternal(Maze, lastRow, lastCol, path, cache))
                return path;

            return null;
        }

        /// <summary>
        /// Gets if there is a from TopLeft to bottomRight of a maze
        /// uses DP and Memoization.
        /// </summary>
        /// <param name="Maze"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="path"></param>
        /// <param name="cache"></param>
        /// <returns></returns>
        public static bool GetPathInternal(int[,] Maze, int row, int col, List<Point> path, Dictionary<Point, bool> cache)
        {
            if (col < 0 || row < 0 || Maze[row, col] == 0)
                return false;

            Point p = new Point(row, col);

            if(cache.ContainsKey(p))
            {
                return cache[p];
            }
            bool isOrigin = row == 0 && col == 0;
            bool success = false;

            if(isOrigin || GetPathInternal(Maze, row, col-1, path, cache) ||
                GetPathInternal(Maze, row-1, col, path, cache))
            {
                path.Add(p);
                success = true;
            }

            cache.Add(p, success);
            return success;
        }
    }

    
}
