using System;
using System.Collections;
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

            ArrayList shapes = new ArrayList();
            shapes.Add(s1);
            shapes.Add(c1);
            shapes.Add(c1);
            shapes.Add(c1);

            /*
             *新需求 提供先繪畫圓形的功能
             *如此，open for extension close for modification 就會被破壞
             *允許被打一槍，但之後就要再遵守
             */

            DrawAllShapes.DrawAll(shapes);
        }
    }
}
