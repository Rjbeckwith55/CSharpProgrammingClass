using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Parallelogram : Quadralilateral
    {
        public Parallelogram(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4) : base(c1, c2, c3, c4)
        {
        }
        //base *height
        public override double getArea()
        {
            //calculate the area of a parallelogram
            Coordinate h = new Coordinate(coord2.x, coord4.y);
            return coord1.getDistance(coord2) * coord2.getDistance(h);
        }
    }
}
