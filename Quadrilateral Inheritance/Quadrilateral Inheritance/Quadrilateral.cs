using System;
namespace Quadrilateral_Inheritance
{
    abstract class Quadralilateral
    {
        public Quadralilateral(Coordinate c1, Coordinate c2, Coordinate c3, Coordinate c4)
        {
            coord1 = c1;
            coord2 = c2;
            coord3 = c3;
            coord4 = c4;
        }
        public abstract double getArea();

        //coordinates
        protected Coordinate coord1 { get; private set; }
        protected Coordinate coord2 { get; private set; }
        protected Coordinate coord3 { get; private set; }
        protected Coordinate coord4 { get; private set; }
    }


}
