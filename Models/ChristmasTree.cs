using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class ChristmasTree
    {
        public static string CustomChristmasTree(string chars, int n)
        {
            StringBuilder tree = new StringBuilder();
            int charLength = chars.Length;

            for (int i = 1; i <= n; i++)
            {
                tree.Append(new string(' ', n - i));

                for (int j = 0; j < i; j++)
                {
                    if (j > 0)
                    {
                        tree.Append(' ');
                    }
                    tree.Append(chars[(j + (i - 1) * i / 2) % charLength]);
                }

                if (i != n)
                    tree.AppendLine();
            }

            int trunkHeight = (int)n / 3;
            string trunk = new string(' ', n - 1) + "|";

            for (int i = 0; i < trunkHeight; i++)
            {
                tree.Append('\n').Append(trunk);
            }

            return tree.ToString();
        }
    }
}
