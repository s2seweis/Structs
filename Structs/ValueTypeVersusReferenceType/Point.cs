using System;

namespace Structs.ValueTypeVersusReferenceType
{
    public struct Point
    {
        public double X { get; set; }  // Add a setter here
        public double Y { get; set; }  // Add a setter here

        public Point(double x, double y)
        {
            X = x; 
            Y = y; 
        }

        //public double DistanceTo(Point other)
        //{
        //    double dx = other.X - X;
        //    double dy = other.Y - Y;    
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
}
