using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class Rectangle
    {
        double _side1;
        double _side2;
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Area { get { return AreaCalculator();}}
        public double Perimeter { get { return PerimeterCalculator();}}

        public double AreaCalculator()
        {
            double res = default(double);
            if (_side1!=0 && _side2!=0)
            {
                double result = _side1 * _side2;
                return result;
            }
            return res;
        }

        public double PerimeterCalculator()
        {
            double res = default(double);
            if (_side1!=0 && _side2!=0)
            {
                double result = 2 * _side1 + 2 * _side2;
                return result;
            }
            return res;
        }
    }
}
