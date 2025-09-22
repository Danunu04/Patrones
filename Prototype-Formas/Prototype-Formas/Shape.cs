using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Formas
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public Shape() { }
        public Shape(Shape source)
        {
            if (source != null)
            {
                X = source.X;
                Y = source.Y;
                Color = source.Color;
            }
        }
        public abstract Shape Clone();
    }
}
