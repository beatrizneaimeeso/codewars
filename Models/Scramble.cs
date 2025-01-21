using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Scramble
    {
        public static bool ScrambleCheck(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return false;
            }

            if (str1.Length == str2.Length)
            {
                str1 = string.Concat(str1.OrderBy(c => c));
                str2 = string.Concat(str2.OrderBy(c => c));

                return str1 == str2;
            }

            var results = new List<bool>();

            foreach (var c in str2)
            {
                if (str1.Contains(c))
                {
                    results.Add(true);
                    str1 = str1.Remove(str1.IndexOf(c), 1);
                }
            }

            return results.Count == str2.Length;
        }
    }
}
