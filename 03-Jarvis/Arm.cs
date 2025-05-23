using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    internal class Arm
    {
        public long Energy { get; set; }
        public int Reach { get; set; }
        public int Fingers { get; set; }

        public override string ToString()
        {
            string result = String.Empty;

            result += String.Format($"#Arm:\r\n");
            result += string.Format($"###Energy consumption: {Energy}\r\n");
            result += string.Format($"###Reach: {Reach}\r\n");
            result += string.Format($"###Fingers: {Fingers}\r\n");

            return result;
        }
    }
}
