﻿namespace CSharpHomeCase6_1.Entities
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(int a, int b)
        {
            X = a;
            Y = b;
        }
        public Point Duplicate(Point currentPoint)
        {
            Point newPoint = new Point(0, 0);
            newPoint.X = currentPoint.X;
            newPoint.Y = currentPoint.Y;
            return newPoint;
        }
        public override string ToString()
        {
            return string.Format(" ( {0}, {1} ) ", X, Y);
        }
    }
}
