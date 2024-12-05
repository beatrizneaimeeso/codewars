using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Models
{
    public class Cryptography
    {
        public static string EncryptThis(string input)
        {
            var words = input.Split(' ');
            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.Length == 0)
                {
                    result.Add("");
                    continue;
                }

                if (word.Length == 1)
                {
                    result.Add(((int)word[0]).ToString());
                    continue;
                }

                var firstLetter = (int)word[0];
                var secondLetter = "";
                var lastLetter = "";
                var middle = "";

                if (word.Length >= 2)
                {
                    secondLetter = word[1].ToString();
                }

                if (word.Length >= 3)
                {
                    lastLetter = word[word.Length - 1].ToString();
                }

                if (word.Length >= 4)
                {
                    middle = word.Substring(2, word.Length - 3);
                }

                result.Add($"{firstLetter}{lastLetter}{middle}{secondLetter}");
            }

            return string.Join(" ", result);
        }

        public static int ExtractIntUsingRegex(string input)
        {
            var number = Regex.Match(input, @"d+").Value;
            return int.Parse(number);
        }

        public static string DecryptThis(string s)
        {
            var words = s.Split(' ');
            var result = new List<string>();

            foreach (var word in words)
            {
                if (word.Length == 0)
                {
                    result.Add("");
                    continue;
                }

                if (word.Length == 2)
                {
                    result.Add(((char)int.Parse(word)).ToString());
                    continue;
                }

                string numbers = new string(word.Where(char.IsDigit).ToArray());
                Console.WriteLine(numbers);
                var firstLetter = (char)int.Parse(numbers);
                var lastLetter = "";
                var middle = "";
                var secondLetter = "";

                if (word.Length - numbers.Length >= 1)
                {
                    secondLetter = word[numbers.Length].ToString();
                }

                if (word.Length - numbers.Length >= 2)
                {
                    lastLetter = word[^1].ToString();
                }

                if (word.Length - numbers.Length >= 2)
                {
                    middle = word.Substring(numbers.Length + 1, word.Length - numbers.Length - 2);
                }

                result.Add($"{firstLetter}{lastLetter}{middle}{secondLetter}");
            }

            return string.Join(" ", result);
        }
    }

    public class EncryptThisRequest
    {
        public string Input { get; set; }
    }
}
