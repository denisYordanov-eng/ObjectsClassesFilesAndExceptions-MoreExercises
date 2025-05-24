using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PersonalExeption
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                try
                {
                    if (number < 0)
                    {
                        throw new PersonalExeption();
                    }
                }
                catch (PersonalExeption pe)
                {
                    Console.WriteLine(pe.Message);
                    return;
                }
            }
        }
    }
}
