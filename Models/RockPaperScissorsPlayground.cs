using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Interfaces;

namespace CodeWars.Models
{
    public class RockPaperScissorsPlayground
    {
        private List<IRockPaperScissorsPlayer> players;
        private Dictionary<string, Func<string, bool>> rules;

        public RockPaperScissorsPlayground()
        {
            this.rules = new Dictionary<string, Func<string, bool>>
            {
                { "R", shape => shape == "S" },
                { "P", shape => shape == "R" },
                { "S", shape => shape == "P" },
            };
        }

        public bool PlayTournament(IRockPaperScissorsPlayer bot)
        {
            var opponents = new List<IRockPaperScissorsPlayer>();
            this.players = new List<IRockPaperScissorsPlayer> { bot };
            return false;
        }
    }

    public class Player : IRockPaperScissorsPlayer
    {
        private Random random;

        public Player()
        {
            this.random = new Random((int)DateTime.UtcNow.Ticks);
        }

        public string Name
        {
            get { return "My Player"; }
        }

        public string GetShape()
        {
            throw new NotImplementedException();
        }

        public void SetNewMatch(string opponentName)
        {
            throw new NotImplementedException();
        }

        public void SetOpponentShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
}
