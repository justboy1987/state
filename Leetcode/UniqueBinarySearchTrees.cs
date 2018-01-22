using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tree
{
    /// <summary>
    /// Unique Binary Search Trees
    /// https://leetcode.com/problems/unique-binary-search-trees/description/
    /// </summary>
    public class UniqueBinarySearchTrees2
    {
        public static int NumTrees(int n)
        {
            int[] G = new int[n + 1];
            G[0] = G[1] = 1;

            for (int i = 2; i <= n; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    G[i] += G[j - 1] * G[i - j];
                }
            }

            return G[n];
        }

        
    }
}
