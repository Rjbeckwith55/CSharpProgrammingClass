using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Square : Rectangle
    {
        public Square(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4) : base(c1, c2, c3, c4)
        {
        }
        public override double getArea()
        {
            return base.getArea();
        }
    }
}
