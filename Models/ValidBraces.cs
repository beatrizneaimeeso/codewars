using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class ValidBraces
    {
        public static bool FindValidBraces(String braces)
        {
            if (braces.Length % 2 != 0)
            {
                return false;
            }

            var dictionary = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };

            var stack = new Stack<char>();
            braces
                .ToList()
                .ForEach(b =>
                {
                    if (dictionary.ContainsKey(b))
                    {
                        stack.Push(b);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            return;
                        }

                        var last = stack.Pop();
                        if (dictionary[last] != b)
                        {
                            stack.Push(last);
                        }
                    }
                });
            return stack.Count == 0;
        }
    }
}
