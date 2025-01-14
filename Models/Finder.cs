using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Finder
    {
        public static int PathFinder(string maze)
        {
            var mazeLines = maze.Split('\n');
            int n = mazeLines.Length;
            var directions = new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            var queue = new Queue<(int x, int y, int steps)>();
            var visited = new bool[n, n];

            queue.Enqueue((0, 0, 0));
            visited[0, 0] = true;

            while (queue.Count > 0)
            {
                var (x, y, steps) = queue.Dequeue();

                if (x == n - 1 && y == n - 1)
                    return steps;

                foreach (var (dx, dy) in directions)
                {
                    int nx = x + dx,
                        ny = y + dy;

                    if (
                        nx >= 0
                        && ny >= 0
                        && nx < n
                        && ny < n
                        && mazeLines[nx][ny] == '.'
                        && !visited[nx, ny]
                    )
                    {
                        queue.Enqueue((nx, ny, steps + 1));
                        visited[nx, ny] = true;
                    }
                }
            }

            return -1;
        }
    }
}
