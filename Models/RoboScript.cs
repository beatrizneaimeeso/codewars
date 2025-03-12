using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars.Models
{
    public class RoboScript
    {
        public static string Execute(string code)
        {
            var directions = new (int dx, int dy)[] { (1, 0), (0, -1), (-1, 0), (0, 1) };
            int dir = 0,
                x = 0,
                y = 0;
            HashSet<(int, int)> path = [(x, y)];

            var matches = Regex.Matches(code, "([FLR])(\\d*)");

            foreach (Match match in matches)
            {
                char command = match.Groups[1].Value[0];
                int repetitions =
                    match.Groups[2].Value == "" ? 1 : int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repetitions; i++)
                {
                    switch (command)
                    {
                        case 'F':
                            x += directions[dir].dx;
                            y += directions[dir].dy;
                            path.Add((x, y));
                            break;
                        case 'L':
                            dir = (dir + 3) % 4;
                            break;
                        case 'R':
                            dir = (dir + 1) % 4;
                            break;
                    }
                }
            }

            int minX = path.Min(p => p.Item1),
                maxX = path.Max(p => p.Item1);
            int minY = path.Min(p => p.Item2),
                maxY = path.Max(p => p.Item2);

            char[,] grid = new char[maxY - minY + 1, maxX - minX + 1];
            for (int i = 0; i < grid.GetLength(0); i++)
            for (int j = 0; j < grid.GetLength(1); j++)
                grid[i, j] = ' ';

            foreach (var (px, py) in path)
                grid[py - minY, px - minX] = '*';

            StringBuilder result = new();
            for (int i = grid.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    result.Append(grid[i, j]);
                }
                if (i > 0)
                {
                    result.Append("\r\n");
                }
            }

            return result.ToString();
        }
    }
}
