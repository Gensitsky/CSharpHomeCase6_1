﻿namespace CSharpHomeCase6_1.Entities
{
    class Rectangle : Parallelogram
    {
        //--- protected ----------------------------------
        protected override void ValidatePoints()
        {
            if (isParallel() == false)
            {
                throw new MyExceptions.NotParallelSidesException("It is not a Rectangle!!! There is no pair of parallel sides.\n\n");
            }
            if (isRightAngle() == false)
            {
                throw new MyExceptions.NoRightAngleException("It is not a Rectangle!!! There is no right angle\n\n");
            }
            if (Basis1 == 0 || Basis2 == 0 || Side1 == 0 || Side2 == 0)
            {
                throw new MyExceptions.PointCoincidenceException("It is not a Rectangle!!! There is a Point Coincidence.\n\n");
            }
        }

        protected bool isRightAngle()
        {
            bool flag = false;

            if ((first.Y - second.Y) * (first.Y - third.Y) == (-1) * (first.X - third.X) * (first.X - second.X) ||
                (first.Y - second.Y) * (first.Y - fourth.Y) == (-1) * (first.X - fourth.X) * (first.X - second.X) ||
                (first.Y - third.Y) * (first.Y - fourth.Y) == (-1) * (first.X - third.X) * (first.X - fourth.X)) flag = true;

            return flag;
        }

        //--- public -------------------------------------
        public Rectangle(Point first, Point second,
            Point third, Point fourth) : 
            base(first, second, third, fourth) { }

        public override string ToString()
        {
            return string.Format(
                "\n ____________ RECTANGLE ____________ \n" +
                " Four points : \n" +
                " A{0} B{1} C{2} D{3} \n\n" +
                " Side 1 = {4};\n Side 2 = {5}; \n" +
                " Side 3 = {6};\n Side 4 = {7};  \n\n" +
                " AREA = {8};\n PERIMETER = {9};",
                first, second, third, fourth, Basis1, Basis2, Side1,
                Side2, Area, Perimeter);
        }
    }
}
