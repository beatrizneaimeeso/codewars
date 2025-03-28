using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class Reflection
    {
        public static string ConcatStringMembers(object TestObject)
        {
            Console.WriteLine("ConcatStringMembers");
            string result = "";
            var type = TestObject.GetType();
            var members = type.FindMembers(
                System.Reflection.MemberTypes.Method,
                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance,
                null,
                null
            );
            var considered = new List<string>();

            foreach (var method in type.GetMethods())
            {
                if (
                    method.GetParameters().Length == 0
                    && method.ReturnType == typeof(string)
                    && !considered.Contains(method.Name)
                )
                {
                    result += method.Invoke(TestObject, null);
                    considered.Add(method.Name);
                }
            }

            return "";
        }
    }

    public class ReflectionTest
    {
        public string Output1()
        {
            return "Output";
        }

        public string Output2()
        {
            return "It";
        }
    }
}
