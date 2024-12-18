using System;
using System.Collections.Generic;
using System.Linq;

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
            if (p1Score >= maxScore || p2Score >= maxScore)
            {
                return "Game Over!";
            }
            else
            {
                var distance = Math.Abs(ballPos - playerPos);
                if (round % 2 == 0)
                {
                    round++;
                    if (distance <= 3)
                    {
                        return "Player 2 has hit the ball!";
                    }
                    else
                    {
                        p1Score++;
                        if (p1Score >= maxScore)
                        {
                            return "Player 1 has won the game!";
                        }
                        return "Player 2 has missed the ball!";
                    }
                }
                else
                {
                    round++;
                    if (distance <= 3)
                    {
                        return "Player 1 has hit the ball!";
                    }
                    else
                    {
                        p2Score++;
                        if (p2Score >= maxScore)
                        {
                            return "Player 2 has won the game!";
                        }
                        return "Player 1 has missed the ball!";
                    }
                }
            }
        }
    }
}
