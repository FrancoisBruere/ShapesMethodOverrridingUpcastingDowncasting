﻿namespace UpcastingDowncasting
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public abstract void Draw();// vitrual allows overriding the method in inherited class circle
       
        
    }
}
