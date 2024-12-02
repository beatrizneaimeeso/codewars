using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class StockList
    {
        public String stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            if (
                lstOfArt == null
                || lstOf1stLetter == null
                || lstOfArt.Length == 0
                || lstOf1stLetter.Length == 0
            )
            {
                return "";
            }

            Dictionary<string, int> categoryTotals = lstOf1stLetter.ToDictionary(c => c, c => 0);

            foreach (string art in lstOfArt)
            {
                string[] parts = art.Split(' ');
                string code = parts[0];
                int quantity = int.Parse(parts[1]);

                string category = code[0].ToString();

                if (categoryTotals.ContainsKey(category))
                {
                    categoryTotals[category] += quantity;
                }
            }

            return string.Join(" - ", categoryTotals.Select(kvp => $"({kvp.Key} : {kvp.Value})"));
        }
    }
}
