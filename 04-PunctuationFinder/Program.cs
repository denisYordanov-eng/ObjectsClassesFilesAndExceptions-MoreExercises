using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PunctuationFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] allLines =  File.ReadAllLines(@"C:\Users\Laptop\Desktop\C#\ObjectsClassesFilesAndExceptions-More Exercises\sample_text.txt");
            List<char> punctuatios = new List<char>();
            char[] punctuatiosToTake = new[] { '.', ',', '!', '?', ':' };    

            foreach(var line in allLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuatiosToTake.Contains(line[i]))
                    {
                        punctuatios.Add(line[i]);
                    }
                }
            }
            Console.WriteLine(String.Join(", ",punctuatios));
        }
    }
}
