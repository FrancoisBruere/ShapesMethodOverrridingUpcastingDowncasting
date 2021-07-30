using System;
using System.Collections.Generic;

namespace UpcastingDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            //var text = new Text();

            //Shape shape = text;

            //var shape = new Text();

            //Text text = (Text)shape;




            //text.Width = 200;
            //shape.Width = 100;


            //Console.WriteLine("Width of text obj:" + text.Width); // value will be 100 as text and shape ref same object last value is 100


            //var list = new List<Shape>();

            //list.Add(new Shape());

            var shapes = new List<Shape>();

            shapes.Add(new Circle { Width = 100, Height = 100 });
            shapes.Add(new Rectangle { Height = 100, Width = 30 });
            shapes.Add(new Triangle {rightHeight = 100, LeftHeight = 100, Width = 50 });

            var canvas = new Canvas();
            canvas.DrawShape(shapes);

        }
    }
}
