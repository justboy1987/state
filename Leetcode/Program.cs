using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.BinarySearch;
using Leetcode.Dynamic_Programming;
using Leetcode.Tree;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Longest_Increasing_Subsequence.lengthOfLIS4(new[] {10, 9, 2, 5, 3, 7, 101, 18});
            Console.WriteLine(a);
        }
    }
}
