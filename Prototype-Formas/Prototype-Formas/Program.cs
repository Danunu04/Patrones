using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Circle circle = new Circle { X = 10, Y = 10, Radius = 20, Color = "Red" };
            shapes.Add(circle);

            Circle anotherCircle = (Circle)circle.Clone();
            shapes.Add(anotherCircle);

            Rectangle rectangle = new Rectangle { X = 5, Y = 5, Width = 10, Height = 20, Color = "Blue" };
            shapes.Add(rectangle);

            List<Shape> shapesCopy = new List<Shape>();

            foreach (Shape s in shapes)
            {
                shapesCopy.Add(s.Clone());
            }

            Console.WriteLine("=== Originales ===");
            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n=== Copias ===");
            foreach (var s in shapesCopy)
            {
                Console.WriteLine(s);
            }
        }
    }
   
}

