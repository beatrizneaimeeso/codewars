using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Interfaces
{
    public interface IRockPaperScissorsPlayer
    {
        string Name { get; }
        void SetNewMatch(string opponentName);
        string GetShape();
        void SetOpponentShape(string shape);
    }
}
