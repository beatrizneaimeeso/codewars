using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class SpinningWords
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            var res = new List<string>();
            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    var reversed = ReverseWord(word);
                    res.Add(reversed);
                }
                else
                {
                    res.Add(word);
                }
            }
            return string.Join(" ", res);
        }

        public static string ReverseWord(string word)
        {
            var c = word.ToCharArray();
            var aux = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                aux += c[word.Length - i - 1];
            }

            return aux;
        }
    }
}
