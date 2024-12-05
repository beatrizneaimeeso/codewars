using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class MaximumProduct
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            if (array.Length < 2)
            {
                throw new Exception();
            }
            var max = array.Max();
            var index = Array.IndexOf(array, max);
            if (index == 0)
            {
                return max * array[index + 1];
            }

            if (index == array.Length - 1)
            {
                return max * array[index - 1];
            }

            return Math.Max(max * array[index - 1], max * array[index + 1]);
        }
    }
}
