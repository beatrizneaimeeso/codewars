using System;
using System.Collections.Generic;

namespace CodeWars.Models
{
    public class TextAlign
    {
        public static string Justify(string str, int len)
        {
            var words = str.Split(' ');
            var lines = new List<string>();
            var currentLine = new List<string>();
            var currentLength = 0;

            foreach (var word in words)
            {
                if (currentLength + word.Length + currentLine.Count <= len)
                {
                    currentLine.Add(word);
                    currentLength += word.Length;
                }
                else
                {
                    lines.Add(string.Join(" ", currentLine));
                    currentLine.Clear();
                    currentLine.Add(word);
                    currentLength = word.Length;
                }
            }

            if (currentLine.Count > 0)
            {
                lines.Add(string.Join(" ", currentLine));
            }

            for (int i = 0; i < lines.Count - 1; i++)
            {
                var line = lines[i];
                var wordsInLine = line.Split(' ');
                var totalSpaces = len - line.Replace(" ", "").Length;
                var gaps = wordsInLine.Length - 1;

                if (gaps > 0)
                {
                    var spacePerGap = totalSpaces / gaps;
                    var extraSpaces = totalSpaces % gaps;

                    var justifiedLine = "";
                    for (int j = 0; j < gaps; j++)
                    {
                        justifiedLine += wordsInLine[j];
                        justifiedLine += new string(' ', spacePerGap + (j < extraSpaces ? 1 : 0));
                    }
                    justifiedLine += wordsInLine[^1];
                    lines[i] = justifiedLine;
                }
            }

            return string.Join("\n", lines);
        }
    }
}
