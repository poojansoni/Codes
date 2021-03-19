using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 2, 3, 4, 6, 7, 8, 12, 23, 45 };

            IEnumerable<int> result = from alies in Numbers
                                      select alies;

            foreach (int val in result)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
