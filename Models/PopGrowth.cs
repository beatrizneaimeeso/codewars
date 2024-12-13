using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class PopGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            var time = 0;
            var sum = p0;

            while (sum < p)
            {
                time++;
                sum += (int)Math.Floor(sum * (percent / 100) + aug);
            }

            return time;
        }
    }
}
