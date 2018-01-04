using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {

            for(int i = array.Length -1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            //or

            /*
            for (int i = 0; i < array.Length ; i++)
            {
                for(int j = 0 ; j < array.Length - 1 -i; j++)
                {
                    if(array[j] > array[j+1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            */
            return array;
        }
    }
}
