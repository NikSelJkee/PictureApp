using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    class Point
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }

        public Point()
        {
            
        }
    }

    class Line : Point
    {
        public Line() : base()
        {

        }
    }

    class Circle : Point
    {
        public Circle() : base()
        {

        }
    }

    class Square : Point
    {
       public Square() : base()
        {

        }
    }

    class Triangle : Point
    {
        public Triangle() : base()
        {

        }
    }
}
