using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Abstractions
{
    public abstract class Figure
    {
        private readonly Lazy<double> _area;
        private readonly Lazy<double> _perimeter;

        public double Area => _area.Value;
        public double Perimeter => _perimeter.Value;

        protected Figure()
        {
            _area = new Lazy<double>(CalcArea);
            _perimeter = new Lazy<double>(CalcPerimeter);
        }

        protected abstract double CalcArea();
        protected abstract double CalcPerimeter();

    }
}
