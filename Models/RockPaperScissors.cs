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
        private List<string> opponentShape = new List<string>();
        private int myScore;
        private int opponentScore;
        private bool gameStarted;
        private int round;
        private int match;
        private Dictionary<int, List<string>> matchHistory = new();

        public RockPaperScissors()
        {
            random = (new Random((int)DateTime.UtcNow.Ticks));
        }

        public string Name
        {
            get { return random.NextInt64().ToString(); }
        }

        public void SetNewMatch(string nameOpponent)
        {
            this.match++;
            this.opponentName = nameOpponent;
            this.opponentShape.Clear();
        }

        public string GetShape()
        {
            if (this.opponentShape.Count < 3)
            {
                this.GetRandomShape();
            }

            var predictedShape = this.PredictOpponentMove();
            myScore++;
            return this.CounterMove(predictedShape);
        }

        private string PredictOpponentMove()
        {
            if (opponentShape.Count >= 2 && opponentShape[^1] == opponentShape[^2])
            {
                return opponentShape[^1];
            }
            return opponentShape[^1];
        }

        public void SetOpponentShape(string shape)
        {
            this.opponentShape.Add(shape);
        }

        public string GetRandomShape()
        {
            var shapes = new List<string> { "R", "P", "S" };
            return shapes[random.Next(0, 3)];
        }

        private string CounterMove(string predictedMove)
        {
            return predictedMove switch
            {
                "R" => "P", // Papel vence Pedra
                "P" => "S", // Tesoura vence Papel
                "S" => "R", // Pedra vence Tesoura
                _ => GetRandomShape(),
            };
        }
    }
}
