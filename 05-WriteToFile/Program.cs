using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _05_WriteToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allLines = File.ReadAllText
                (@"C:\Users\Laptop\Desktop\C#\ObjectsClassesFilesAndExceptions-More Exercises\sample_text.txt");
            
            char[] chars = new char[] { '.', ',', '!','?',':' };

            string withoutPunctuation = new string(allLines.Where(c => !chars.Contains(c)).ToArray());


            File.WriteAllText("output.txt",withoutPunctuation);
        }
    }
}
