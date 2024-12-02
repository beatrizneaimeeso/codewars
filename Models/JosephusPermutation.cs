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
                // Circular index não chega ao último elemento do array
                int circularIndex = i % items.Count;
                var current = items[circularIndex - 1 <= 0 ? 0 : circularIndex - 1];
                i++;

                if (current == null)
                {
                    continue;
                }

                if (count % k == 0)
                {
                    result.Add(current);
                    items[circularIndex - 1] = null;
                    count = 1;
                    continue;
                }

                if (circularIndex == items.Count)
                {
                    i++;
                }

                if (result.Count == items.Count)
                {
                    break;
                }
                count++;
            }
            return result;
        }
    }
}
