using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Backspaces
    {
        public static string CleanString(string s)
        {
            var erase = s.ToCharArray().Count(x => x == '#');
            var result = new List<char>();

            if (erase >= s.Length)
            {
                return "";
            }

            s.ToList()
                .ForEach(x =>
                {
                    if (x == '#')
                    {
                        if (result.Count > 0)
                        {
                            result.RemoveAt(result.Count - 1);
                        }
                    }
                    else
                    {
                        result.Add(x);
                    }
                });

            return result.Count == 0 ? "" : string.Join("", result);
        }
    }
}
