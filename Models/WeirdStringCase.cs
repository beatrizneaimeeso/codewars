using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Models
{
    public class WeirdStringCase
    {
        public string ToWeirdCase(string s)
        {
            if (s != null)
            {
                var words = s.Split(' ');
                var result = new List<string>();
                foreach (var word in words)
                {
                    var weirdWord = "";
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            weirdWord += word[i].ToString().ToUpper();
                        }
                        else
                        {
                            weirdWord += word[i].ToString().ToLower();
                        }
                    }
                    result.Add(weirdWord);
                }
                return string.Join(" ", result);
            }
            return "";
        }
    }
}
