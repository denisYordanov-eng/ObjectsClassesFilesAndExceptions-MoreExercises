using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    internal class Torso
    {
        public long Energy { get; set; }
        public double ProcesorSize { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            result += String.Format("#Torso:\r\n");
            result += String.Format($"###Energy consumption: {Energy}\r\n");
            result += String.Format($"###Processor size: {ProcesorSize:F1}\r\n");
            result += String.Format($"###Corpus material: {Material}\r\n");

            return result;
        }
    }
}
