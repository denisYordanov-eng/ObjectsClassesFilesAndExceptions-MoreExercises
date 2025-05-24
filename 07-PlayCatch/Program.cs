using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();
            int exetionCounter = 0;

            while (true)
            {
                if (exetionCounter == 3)
                {
                    break;
                }
                string[] token = Console.ReadLine().Split(' ');

                string command = token[0];
               

                    if (command == "Replace")
                    {
                    try
                    {
                        int index = int.Parse(token[1]);
                        int element = int.Parse(token[2]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exetionCounter++;
                        continue;
                    }
                        try
                        {
                            int index = int.Parse(token[1]);
                            int element = int.Parse(token[2]);
                            number[index] = element;
                        }
                        catch
                        {
                            Console.WriteLine("The index does not exist!");
                            exetionCounter++;                          
                        }
                    }

                else if (command == "Print")
                {
                    try
                    {
                        int startIndex = int.Parse(token[1]);
                        int endIndex = int.Parse(token[2]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exetionCounter++;
                        continue;
                    }
                    try
                    {
                        int startIndex = int.Parse(token[1]);
                        int endIndex = int.Parse(token[2]);
                        List<int> numbers = new List<int>();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            numbers.Add(number[i]);
                        }
                        Console.WriteLine(String.Join(", ", numbers));
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        exetionCounter++;
                    }
                }
                
                else if (command == "Show")
                    {
                    try
                    {
                        int index = int.Parse(token[1]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exetionCounter++; 
                        continue;
                    }
                        try
                        {
                            int index = int.Parse(token[1]);
                            Console.WriteLine(number[index]);
                        }
                        catch
                        {
                            Console.WriteLine("The index does not exist!");
                            exetionCounter++;
                        }
                    }
            }
            Console.WriteLine(String.Join(", ", number));
        }
    }
}
