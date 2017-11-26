using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Trapezoid : Quadralilateral
    {
        public Trapezoid(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4) : base(c1, c2, c3, c4)
        {
        }
        //1/2*height*(base1 + base2)
        public override double getArea()
        {
            Coordinate h = new Coordinate(coord2.x, coord4.y);
            return .5 * (coord2.getDistance(h)) * (coord1.getDistance(coord2) * coord3.getDistance(coord4));
        }
    }
}
