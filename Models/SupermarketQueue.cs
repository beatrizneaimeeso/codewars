using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class SupermarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (customers.Length == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return customers.Sum();
            }
            else if (n > customers.Length)
            {
                return customers.Max();
            }
            else
            {
                var tills = new int[n];
                foreach (var customer in customers)
                {
                    tills[0] += customer;
                    Array.Sort(tills);
                }
                return tills.Max();
            }
        }
    }
}
