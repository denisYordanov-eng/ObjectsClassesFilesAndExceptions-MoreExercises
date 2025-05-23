using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    internal class Head
    {
        public long Energy { get; set; }
        public int Iq { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
           string result = string.Empty;

            result += string.Format("#Head:\r\n");

            result += String.Format($"###Energy consumption: {Energy}\r\n");
            result += String.Format($"###IQ: {Iq}\r\n");
            result += String.Format($"###Skin material: {Material}\r\n");

            return result;
        }
    }
}
