using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor
{
    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public byte age;

        public string Informizer()
        {
            return $"{name}\n{breed}\n{age}\n";
        }
    }

}
