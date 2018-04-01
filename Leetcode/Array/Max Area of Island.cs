using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/max-area-of-island/description/
    /// </summary>
    class Max_Area_of_Island
    {
        public int MaxAreaOfIsland(int[,] grid)
        {
            var result = new int[grid.GetLength(0), grid.GetLength(1)];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        if (i == 0 && j == 0)
                        {
                            result[i, j] = 1;
                        }
                    }
                }
            }
        }
    }
}
