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
            var n = maze.Length;
            var visited = new bool[n, n];
            var target = (n - 1, n - 1);
            var queue = new Queue<(int x, int y, int steps)>();

            queue.Enqueue((0, 0, 0));
            visited[0, 0] = true;

            Console.WriteLine(queue.Count);

            return -1;
        }
    }
}
