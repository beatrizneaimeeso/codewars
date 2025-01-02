using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class TenMinutesWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
            {
                return false;
            }

            var north = walk.Count(x => x == "n");
            var south = walk.Count(x => x == "s");
            var east = walk.Count(x => x == "e");
            var west = walk.Count(x => x == "w");

            if (north == south && east == west)
            {
                return true;
            }

            return false;
        }
    }
}
