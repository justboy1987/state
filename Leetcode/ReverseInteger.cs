using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseInteger
    {
        /**
         * Reverse digits of an integer.
         * Example1: x = 123, return 321
         * Example2: x = -123, return -321
         */ 
        public static int Reverse(int x)
        {
            var isNeg = x < 0 ;
            if (isNeg)
            {
                x = -x;
            }
            var result = 0;
            while (x > 0)
            {
                try
                {
                    var last = x % 10;
                    x = x / 10;
                    result = checked(result * 10 + last);
                }
                catch (System.OverflowException e)
                {
                    return 0;
                }
            }
            return isNeg ? -result : result;
        }
    }
}
