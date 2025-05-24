using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PlayCatch_betterVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();

            int exeptionCounter = 0;
            while (exeptionCounter < 3)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                if()
            }
            
        }
    }
}
