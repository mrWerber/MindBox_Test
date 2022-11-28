using AreaCalculator.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleConstructor_WhenRadiusIsBelowZero_ReturnArgumentOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-20));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-30));

        }

        [Fact]
        public void CalcArea_WhenRadiusIsValid_ReturnsExpectedArea()
        {

            //Arrange
            var circle = new Circle(5);

            //Act
            var area = circle.Area;

            //Assert
            Assert.Equal(78.539816339744831, area);
        }

        [Fact]
        public void CalcPerimeter_WhenRadiusIsValid_ReturnsExpectedPerimeter()
        {
            var circle = new Circle(5);

            //Act
            var perimeter = circle.Perimeter;

            //Assert
            Assert.Equal(31.415926535897931, perimeter);
        }
    }
}
