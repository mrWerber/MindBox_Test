using AreaCalculator.Abstractions;

namespace AreaCalculator.Primitives
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightAngled { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0) 
                throw new ArgumentOutOfRangeException("Сторона не может быть меньше 0");

            if (!IsValidTriangle(sideA, sideB, sideC)) 
                throw new ArgumentOutOfRangeException("Треугольник не может быть построен из заданных сторон");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightAngled = CheckIfRightAngled();
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private bool CheckIfRightAngled()
        {
            var maxSide = new[] { SideA, SideB, SideC }.Max();
            var maxSideSqr = Math.Pow(maxSide, 2);

            return maxSideSqr + maxSideSqr == SideA * SideA + SideB * SideB + SideC * SideC;
        }

        protected sealed override double CalcArea()
        {
            var sP = CalcPerimeter() / 2;

            return Math.Sqrt(sP * (sP - SideA) * (sP - SideB) * (sP - SideC));

        }

        protected sealed override double CalcPerimeter()
        {
            return SideA + SideB + SideC;
        }

    }



}
