using System;
using System.Collections.Generic;

namespace UpcastingDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
          

            var shapes = new List<Shape>();

            shapes.Add(new Circle { Width = 100, Height = 100 });
            shapes.Add(new Rectangle { Height = 100, Width = 30 });
            shapes.Add(new Triangle {rightHeight = 100, LeftHeight = 100, Width = 50 });

            var canvas = new Canvas();
            canvas.DrawShape(shapes);

        }
    }
}
