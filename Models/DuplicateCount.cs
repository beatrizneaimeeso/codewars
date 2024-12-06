using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class DuplicateCount
    {
        public static int CountDuplicates(string str)
        {
            var s = str.ToLower().ToList();
            var duplicates = s.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToList();
            return duplicates.Count;            
        }
    }
}
