using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class JosephusPermutation
    {
        public static List<object> GetJosephusPermutation(List<object> items, int k)
        {
            var result = new List<object>();
            var i = 1;
            var count = 1;

            while (result.Count < items.Count)
            {
                int circularIndex = (i - 1) % items.Count;
                var current = items[circularIndex];
                i++;

                if (current == null)
                {
                    continue;
                }

                if (count % k == 0)
                {
                    result.Add(current);
                    items[circularIndex] = null; 
                    count = 1;
                    continue;
                }

                count++;
            }
            return result;
        }
    }
}
