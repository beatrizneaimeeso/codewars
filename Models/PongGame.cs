using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Pong
    {
        private int maxScore;
        private int round;
        private int p1Score;
        private int p2Score;

        public Pong(int maxScore)
        {
            this.maxScore = maxScore;
            this.round = 1;
            this.p1Score = 0;
            this.p2Score = 0;
        }

        public string play(int ballPos, int playerPos)
        {
            var distance = Math.Abs(ballPos - playerPos);
            Console.WriteLine($"Ball: {ballPos} - Player: {playerPos} - Distance: {distance}");
            if (distance < 3.5)
            {
                if (round % 2 == 0)
                {
                    if (p2Score + 1 >= maxScore)
                    {
                        round = 0;
                        return "Player 2 has won the game!";
                    }

                    p2Score++;
                    round++;
                    Console.WriteLine($"Round {round} - Player 1: {p1Score} - Player 2: {p2Score}");
                    return "Player 1 has missed the ball!";
                }
                else
                {
                    if (p1Score + 1 >= maxScore)
                    {
                        round = 0;
                        Console.WriteLine(
                            $"Round {round} - Player 1: {p1Score} - Player 2: {p2Score}"
                        );
                        return "Player 1 has won the game!";
                    }

                    p1Score++;
                    round++;
                    Console.WriteLine($"Round {round} - Player 1: {p1Score} - Player 2: {p2Score}");
                    return "Player 2 has missed the ball!";
                }
            }
            else
            {
                if (round % 2 == 0)
                {
                    round++;
                    Console.WriteLine($"Round {round} - Player 1: {p1Score} - Player 2: {p2Score}");
                    return "Player 2 has missed the ball!";
                }
                else
                {
                    round++;
                    Console.WriteLine($"Round {round} - Player 1: {p1Score} - Player 2: {p2Score}");
                    return "Player 1 has missed the ball!";
                }
            }
        }
    }
}
