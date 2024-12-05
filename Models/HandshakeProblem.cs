using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class HandshakeProblem
    {
        public static int GetParticipants(int handshakes)
        {
            if (handshakes == 0)
            {
                return 0;
            }

            if (handshakes == 1)
            {
                return 2;
            }

            var sqrtDelta = Math.Sqrt(1 + (8 * handshakes));
            return (int)Math.Ceiling((1 + sqrtDelta) / 2);
        }
    }
}
