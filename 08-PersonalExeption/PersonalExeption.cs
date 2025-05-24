using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PersonalExeption
{
    internal class PersonalExeption : Exception
    {
        public PersonalExeption() : base("My first exception is awesome!!!")
        {

        }
    }
}
