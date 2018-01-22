using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.BinarySearch;
using Leetcode.Tree;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Find_Minimum_in_Rotated_Sorted_Array.FindMin2(new[] {3, 3, 3,1,3});
            Console.WriteLine(a);
        }
    }
}
