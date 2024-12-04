using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Plugboard
    {
        private readonly string _wires = "";
        private readonly Dictionary<char, char> _mapping = new Dictionary<char, char>();

        public Plugboard(String wires = "")
        {
            if (wires.Length / 2 > 10 || wires.Length % 2 != 0)
            {
                throw new Exception();
            }
            _wires = wires;
            for (int i = 0; i < _wires.Length; i += 2)
            {
                if (_mapping.ContainsKey(_wires[i]) || _mapping.ContainsValue(_wires[i]))
                {
                    throw new ArgumentException();
                }
                _mapping.Add(_wires[i], _wires[i + 1]);
                _mapping.Add(_wires[i + 1], _wires[i]);
            }
        }

        public char Process(char c)
        {
            return _mapping.ContainsKey(c) ? _mapping[c] : c;
        }
    }
}
