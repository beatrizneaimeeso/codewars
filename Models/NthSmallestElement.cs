using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class NthSmallestElement
    {
        public static int NthSmallest(int[] arr, int pos)
        {
            var arranged = arr.OrderBy(x => x).ToArray();
            if (pos > arranged.Length)
            {
                throw new Exception();
            }
            return arranged[pos - 1];
        }
    }
}
