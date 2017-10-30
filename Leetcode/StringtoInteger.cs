using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class StringtoInteger
    {
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            { return 0; }
            var array = str.Trim().ToArray();
            var isNeg = false;
            var result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {

                    if (array[i] - '0' > 9 || array[i] - '0' < 0)
                    {
                        return result;
                    }
                    var cur = array[i] - '0';
                    try
                    {
                        result = checked(result * 10 + (isNeg ? -cur : cur));
                    }
                    catch (System.OverflowException e)
                    {
                        return isNeg ? int.MinValue : int.MaxValue;
                    }

                }
                else
                {
                    if (array[i] == '-')
                    {
                        isNeg = true;
                    }
                    else if (array[i] == '+')
                    {
                    }
                    else if (array[i] - '0' > 9 || array[i] - '0' < 0)
                    {
                        return 0;
                    }
                    else
                    {
                        result = array[i] - '0';
                    }
                }
            }
            return result;
        }

       
    }
}
