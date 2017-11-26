using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Rectangle : Quadralilateral
    {
        public Rectangle(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4) : base(c1, c2, c3, c4)
        {
        }
        //length * width
        public override double getArea()
        {
            return coord1.getDistance(coord2) * coord2.getDistance(coord4);
        }
    }
}
