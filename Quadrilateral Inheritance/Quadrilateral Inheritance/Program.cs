using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadrilateral -> Parallelogram -> Trapezoid
            //Quadrilateral -> Rectangle -> Square
            //(-1,1),(1,1),(-1,1),(-1,-1)
            Rectangle rect = new Rectangle(new Coordinate(0, 0), new Coordinate(4, 0),
                   new Coordinate(0, 2), new Coordinate(4, 2));

            Square square = new Square(new Coordinate(0, 0), new Coordinate(4, 0),
                new Coordinate(0, 4), new Coordinate(4, 4));

            Parallelogram para = new Parallelogram(new Coordinate(0, 0), new Coordinate(4, 0),
                new Coordinate(2, 4), new Coordinate(6, 4));

            Trapezoid trap = new Trapezoid(new Coordinate(-2, 2), new Coordinate(2, 2),
                new Coordinate(-6, 0), new Coordinate(6, 0));

            //output the areas of the 4 different quadrilaterals
            Console.WriteLine("area of the trapezoid: " + trap.getArea());
            Console.WriteLine("area of the parallelogram: " + para.getArea());
            Console.WriteLine("area of the square: " + square.getArea());
            Console.WriteLine("area of the rectangle: " + rect.getArea());
        }
    }
}
