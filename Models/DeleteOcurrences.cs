using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Models
{
    public class DeleteOccurrencesClass
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var dictionary = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var item in arr)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 1);
                    result.Add(item);
                }
                else if (dictionary[item] < x)
                {
                    dictionary[item]++;
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
