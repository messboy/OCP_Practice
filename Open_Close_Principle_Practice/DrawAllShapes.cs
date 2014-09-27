using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_Close_Principle_Practice
{
    class DrawAllShapes
    {
        /// <summary>
        /// 繪出全部圖形
        /// </summary>
        /// <param name="shapes">圖形集合</param>
        public static void DrawAll(IList<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
