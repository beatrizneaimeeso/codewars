using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Interfaces;

namespace CodeWars.Models
{
    public class RockPaperScissors : IRockPaperScissorsPlayer
    {
        private Random random = new();
        private string myShape = "";
        private string opponentName = "";
        private List<string> opponentShape = [];
        private int myScore;
        private int opponentScore;
        private bool gameStarted;
        private int round;
        private int match;
        private Dictionary<int, List<string>> matchHistory = new();

        public void Player()
        {
            random = new Random((int)DateTime.UtcNow.Ticks);
            return;
        }

        public string Name
        {
            get { return "MyPlayer"; }
        }

        public void SetNewMatch(string nameOpponent)
        {
            myScore = 0;
            opponentScore = 0;
            gameStarted = true;
            round = 0;
            opponentName = nameOpponent;
            opponentShape.Clear();
        }

        public string GetShape()
        {
            if (opponentShape.Count < 3)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        return "P";
                    case 2:
                        return "R";
                    default:
                        return "S";
                }
            } else {
                return "";
            }
        }

        public void SetOpponentShape(string shape)
        {
            opponentShape.Add(shape);
        }
    }
}
