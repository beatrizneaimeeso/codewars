using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class ClimbersRankings
    {
        public static Dictionary<string, int> GetRankings(
            Dictionary<string, IEnumerable<int>> pointsByClimber
        )
        {
            var result = new Dictionary<string, int>();

            foreach (var item in pointsByClimber)
            {
                if (item.Value.Count() > 6)
                {
                    var sorted = item.Value.OrderByDescending(x => x).Take(6);
                    var sum = sorted.Sum();
                    var name = item.Key;
                    result.Add(name, sum);
                }
                else
                {
                    var sum = item.Value.Sum();
                    var name = item.Key;
                    result.Add(name, sum);
                }
            }

            return result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
