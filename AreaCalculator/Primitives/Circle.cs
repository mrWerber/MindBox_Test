using AreaCalculator.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Primitives
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public double Diameter { get; }

        public Circle(double radius)
        {
            if (radius < 0) 
                throw new ArgumentOutOfRangeException("Радиус круга не может быть меньше");

            Radius = radius;
            Diameter = radius * 2;
        }

        protected sealed override double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        protected sealed override double CalcPerimeter()
        {
            return Diameter * Math.PI;
        }
    }
}
