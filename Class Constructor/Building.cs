using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public Building(string name, int height, int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;


        }
        public string PrintInfo()
        {

            return $"{name}\n{height}m height\n{area} m^2 area of the floor";
        }
        public string GetVolume()
        {
            return $"{height * area} m^3 Volume of the building\n";
        }



    }
}
