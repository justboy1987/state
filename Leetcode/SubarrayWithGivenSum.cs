using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class SubarrayWithGivenSum
    {
        public static void MainZ()
        {
            var T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var fl = Console.ReadLine().Split(new[] {' '});
                var len = int.Parse(fl[0]);
                var s = int.Parse(fl[1]);

                var sl = Console.ReadLine().Split(new[] { ' ' });
                var vals = new int[len];
                for (int i = 0; i < sl.Length; i++)
                {
                    vals[i] = int.Parse(sl[i]);
                }
                int l = 0;
                int r = 0;
                int cur = 0;
                for (; r < len & l <len;)
                {
                    if (cur < s)
                    {
                        cur += vals[r++];
                    }else if (cur == s)
                    {
                        Console.WriteLine("{0} {1}", l +1, r +1);
                    }
                    else
                    {
                        cur -= vals[l++];
                    }
                }
            }
        }
    }
}
