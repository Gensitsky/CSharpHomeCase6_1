/*
    Разработать абстрактный класс Геометрическая-
    Фигура с полями ПлощадьФигуры и ПериметрФигуры.
    Разработать классы-наследники: Треугольник, Ква-
    драт, Ромб, Прямоугольник, Параллелограмм, Трапеция,
    Круг, Эллипс и реализовать свойства, которые однозначно
    определяют объекты данных классов.
    Реализовать интерфейс ПростойНУгольник, который
    имеет свойства: Высота, Основание, УголМеждуОснова-
    ниемИСмежнойСтороной, КоличествоСторон, Длины-
    Сторон, Площадь, Периметр.
    Реализовать класс СоставнаяФигура который может
    состоять из любого количества ПростыхНУгольников.
    Для данного класса определить метод нахождения пло-
    щади фигуры.
    Предусмотреть варианты невозможности задания
    фигуры (введены отрицательные длины сторон или при
    создании объекта треугольника существует пара сторон,
    сумма длин которых меньше длины третьей стороны и т.п.) 
*/
using System;
using CSharpHomeCase6_1.Entities;
using CSharpHomeCase6_1.Interfaces;

namespace CSharpHomeCase6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 8);
            Point C = new Point(8, 0);
            Point D = new Point(8, 8);
            try
            {
                Ellipse ellips = new Ellipse(A, B, C);
                Console.WriteLine(ellips);

                Circle circle = new Circle(A, C);
                Console.WriteLine(circle);

                Trapezium trapezium = new Trapezium(A, B, C, D);
                Console.WriteLine(trapezium);

                Triangle trianle = new Triangle(A, B, C);
                Console.WriteLine(trianle);

                Parallelogram parallelogram = new Parallelogram(A, B, C, D);
                Console.WriteLine(parallelogram);

                Rectangle rectangle = new Rectangle(A, B, C, D);
                Console.WriteLine(rectangle);

                Rhombus rhombus = new Rhombus(A, B, C, D);
                Console.WriteLine(rhombus);

                Square square = new Square(A, B, C, D);
                Console.WriteLine(square);
            }
            catch (ApplicationException e)
            {
                Console.WriteLine(" {0} ", e.Message);
            }
            finally
            {
                Console.WriteLine("\nBy!\n");
            }

            Console.ReadKey();
        }
    }
}
