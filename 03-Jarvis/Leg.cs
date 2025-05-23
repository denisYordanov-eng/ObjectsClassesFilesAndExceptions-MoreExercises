using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    internal class Leg
    {
        public long Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            string result = "";
            result += "#Leg:\r\n";
            result += "###Energy consumption: " + Energy + "\r\n";
            result += "Strength: " + Strength + "\r\n"; ;
            result += "###Speed: " + Speed + "\r\n"; ;

            return result;
        }
    }
}
