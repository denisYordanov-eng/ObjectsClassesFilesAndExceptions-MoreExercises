using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OrderByAge
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var input = ReadInput();
           PrintOutput(input);
        }

        private static void PrintOutput(List<Person> input)
        {
            foreach (var person in input)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.",
                    person.Name,person.Id,person.Age);
            }
        }

        private static List<Person> ReadInput()
        {
            List<Person> people = new List<Person>();
            
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    break;
                }
                string[] input = inputLine.Split(' ').ToArray();

                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };
                people.Add(person); 
            }
            var filterByAgePeople = people.OrderBy(a => a.Age);
            return filterByAgePeople.ToList();
        }
    }
}
