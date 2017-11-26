using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Coordinate
    {
        public double x { get; private set; }
        public double y { get; private set; }

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //distance formula
        public double getDistance(Coordinate other)
        {
            return Math.Sqrt(((other.x - x) * (other.x - x))
                + ((other.y - y) * (other.y - y)));
        }

        //string coordinate looks like (x,y)
        public override string ToString()
        {
            string str = "(" + x + "," + y + ")";
            return str;
        }
    }
}
