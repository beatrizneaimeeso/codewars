using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class DirectionsReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            Dictionary<string, string> opposites = new Dictionary<string, string>
            {
                { "NORTH", "SOUTH" },
                { "SOUTH", "NORTH" },
                { "EAST", "WEST" },
                { "WEST", "EAST" },
            };

            List<string> directions = new List<string>();

            foreach (var item in arr)
            {
                if (directions.LastOrDefault() == opposites[item])
                {
                    directions.RemoveAt(directions.Count - 1);
                }
                else
                {
                    directions.Add(item);
                }
            }

            return directions.ToArray();
        }
    }
}
