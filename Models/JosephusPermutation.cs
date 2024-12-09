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

        //time out - >1200ms
        public static int JosephusSurvivor(int n, int k)
        {
            if (n == k)
            {
                return n;
            }
            var items = new List<object>();
            for (int i = 1; i <= n; i++)
            {
                items.Add(i);
            }

            var perm = GetJosephusPermutation(items, k);
            var survivor = Convert.ToInt32(perm.Last());
            return survivor;
        }
    }
}
