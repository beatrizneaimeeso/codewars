using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class TextAlign
    {
        /*
            rules:
            1. Use spaces to fill in the gaps between words.
            2. Each line should contain as many words as possible.
            3. Use '\n' to separate lines.
            4. Gap between words can't differ by more than one space.
            5. Lines should end with a word not a space.
            6. '\n' is not included in the length of a line.
            7. Large gaps go first, then smaller ones ('Lorem--ipsum--dolor--sit-amet,' (2, 2, 2, 1 spaces)).
            8. Last line should not be justified, use only one space between words.
            9. Last line should not contain '\n'
            10. Strings with one word do not need gaps ('somelongword\n')
        */
        public static string Justify(string str, int len)
        {
            var words = str.Split(' ');
            var lines = new List<string>();
            var currentLine = "";
            var currentLength = 0;
            foreach (var word in words)
            {
                if (currentLength + word.Length <= len)
                {
                    currentLine += word + " ";
                    currentLength += word.Length + 1;
                }
                else
                {
                    lines.Add(currentLine.Trim());
                    currentLine = word + " ";
                    currentLength = word.Length + 1;
                }
            }
            lines.Add(currentLine.Trim());
            var justifiedLines = new List<string>();
            for (int i = 0; i < lines.Count - 1; i++)
            {
                var line = lines[i];
                var wordsInLine = line.Split(' ');
                var spaces = len - line.Length;
                var spacesBetweenWords = spaces / (wordsInLine.Length - 1);
                var extraSpaces = spaces % (wordsInLine.Length - 1);
                var justifiedLine = "";
                for (int j = 0; j < wordsInLine.Length - 1; j++)
                {
                    justifiedLine += wordsInLine[j];
                    for (int k = 0; k < spacesBetweenWords; k++)
                    {
                        justifiedLine += " ";
                    }
                    if (j < extraSpaces)
                    {
                        justifiedLine += " ";
                    }
                }
                justifiedLine += wordsInLine[wordsInLine.Length - 1];
                justifiedLines.Add(justifiedLine);
            }
            justifiedLines.Add(lines[lines.Count - 1]);
            return string.Join("\n", justifiedLines);
        }
    }
}
