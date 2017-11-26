﻿namespace CSharpHomeCase6_1.Entities
{
    class Square : Rectangle
    {
        //--- protected ----------------------------------
        protected override void ValidatePoints()
        {
            if (isParallel() == false)
            {
                throw new MyExceptions.NotParallelSidesException("It is not a Square!!! There is no pair of parallel sides.\n\n");
            }
            if (isRightAngle() == false)
            {
                throw new MyExceptions.NoRightAngleException("It is not a Square!!! There is no right angle\n\n");
            }
            if (Basis1 != Side1)
            {
                throw new MyExceptions.NotEqualSidesException("It is not a Square!!! The sides are not equal.\n\n");
            }
            if (Basis1 == 0 || Basis2 == 0 || Side1 == 0 || Side2 == 0)
            {
                throw new MyExceptions.PointCoincidenceException("It is not a Square!!! There is a Point Coincidence.\n\n");
            }
        }

        //--- public -------------------------------------
        public Square(Point first, Point second, Point third, Point fourth) : base(first, second, third, fourth) { }

        public override string ToString()
        {
            return string.Format(
                "\n ____________ SQUARE ____________ \n" +
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
