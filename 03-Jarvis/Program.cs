using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jarvisEnergy = int.Parse(Console.ReadLine());

            Jarvis jarvis = new Jarvis();
            jarvis.Energy = jarvisEnergy;

            while (true)
            {
                string[] token = Console.ReadLine().Split(' ');
                if (token[0] == "Assemble!")
                {
                    break;
                }
                switch (token[0])
                {
                    case "Head":
                        Head head = new Head()
                        {
                            Energy = int.Parse(token[1]),
                            Iq = int.Parse(token[2]),
                            Material = token[3]
                        };
                        jarvis.AddHead(head);
                            break;
                    case "Torso":
                        Torso torso = new Torso()
                        {
                            Energy = int.Parse(token[1]),
                            ProcesorSize = double.Parse(token[2]),
                            Material = token[3]
                        };
                        jarvis.AddTorso(torso);
                        break;
                    case "Arm":
                        Arm arm = new Arm()
                        {
                            Energy = int.Parse(token[1]),
                            Reach = int.Parse(token[2]),    
                            Fingers = int.Parse(token[3])
                        };
                        jarvis.AddArms(arm);
                        break;

                    case "Leg":
                        Leg leg = new Leg()
                        {
                            Energy = int.Parse(token[1]),
                            Strength = int.Parse(token[2]),
                            Speed = int.Parse(token[3])
                        };
                        jarvis.AddLeg(leg);
                        break;
                }
               
            }
            Console.WriteLine(jarvis.ToString());
        }
    }
}
