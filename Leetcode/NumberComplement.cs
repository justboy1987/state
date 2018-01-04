using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class NumberComplement
    {
        public int FindComplement(int num)
        {
            int mul = 1, result = 0, bit = 0;

            while (num > 0)
            {
                bit = num & 1;
                if (bit == 0)
                    result = result + mul;

                mul = mul * 2;
                num = num >> 1;
            }
            return result;

        }
    }
}
