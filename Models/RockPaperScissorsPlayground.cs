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

        public RockPaperScissorsPlayground()
        {
            this.players = new List<IRockPaperScissorsPlayer>();
        }

        public bool PlayTournament(IRockPaperScissorsPlayer bot)
        {
            var opponents = new List<IRockPaperScissorsPlayer>();
            this.players = new List<IRockPaperScissorsPlayer> { bot };
            return false;
        }

        public string[] GetMatchResults()
        {
            return ["Match results"];
        }

        public string GetLastOpponent()
        {
            return players.Select(p => p.Name).Last();
        }
    }

    public class Player : IRockPaperScissorsPlayer
    {
        private Random random;
        private string opponent = null;
        private int i = 0;
        private List<string> moves = new List<string>();

        public Player()
        {
            this.random = new Random((int)DateTime.UtcNow.Ticks);
        }

        public string Name
        {
            get { return "My Player"; }
        }

        static string opposite(string a)
        {
            return a == "S" ? "R"
                : a == "R" ? "P"
                : "S";
        }

        public string GetShape()
        {
            if (opponent == "Vitraj Bachchan")
            {
                return moves.Count == 0 ? "P" : opposite(moves.Last());
            }
            if (opponent == "Jonathan Hughes")
            {
                return moves.Count == 0 ? "P" : opposite(moves.Last());
            }
            if (opponent == "Sven Johanson")
            {
                return "RRSPPR"[i % 6].ToString();
            }
            if (opponent == "Max Janssen")
            {
                return "PSSP"[i % 4].ToString();
            }
            return "RPRSPS"[i % 6].ToString();
        }

        public void SetNewMatch(string nameOpponent)
        {
            opponent = nameOpponent;
            i = 0;
            moves.Clear();
        }

        public void SetOpponentShape(string shape)
        {
            moves.Add(shape);
            i++;
        }
    }
}
