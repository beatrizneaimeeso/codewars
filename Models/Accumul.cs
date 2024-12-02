using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Accumul
    {
        private readonly string _wires = "";

        public Accumul(String wires = "")
        {
            _wires = wires;
        }

        public string Accum()
        {
            var result = "";
            for (int i = 0; i < _wires.Length; i++)
            {
                result += char.ToUpper(_wires[i]);
                for (int j = 0; j < i; j++)
                {
                    result += char.ToLower(_wires[i]);
                }
                if (i < _wires.Length - 1)
                {
                    result += "-";
                }
            }
            return result;
        }
    }
}
