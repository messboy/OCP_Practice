using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_Close_Principle_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Square();
            Shape c1 = new Circle();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(s1);
            shapes.Add(c1);
            shapes.Add(c1);
            shapes.Add(c1);

            DrawAllShapes.DrawAll(shapes);
        }
    }
}
