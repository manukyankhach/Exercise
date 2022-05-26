using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class PolygonPerimeter
    {

    }

    public class Point
    {
        private int _a;
        private int _b;
        private string _c;
        public int A { get; }
        public int B { get; }
        public string C { get; }
        public Point(int a, int b, string c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
    }

    public class Figure
    {
        Point _point1;
        Point _point2;
        Point _point3;
        Point _point4;
        Point _point5;
        public Figure(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point3 = point4;
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            _point4 = point4;
            _point5 = point5;
        }
        public double LengthSide(Point A, Point B)
        {
            return 1.1;
        }
        public void PerimeterCalculator()
        {

        }
    }
}
