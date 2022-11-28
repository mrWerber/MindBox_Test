using AreaCalculator.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleConstructor_WhenOneSideIsNegative_ReturnsArgementOutOfRange()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 20, 30));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(20, -10, 30));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(30, 20, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
        }

        [Fact]
        public void TriangleConstructor_WhenSumOfTwoSidesLengthIsLessThanThirdSide_ReturnsArgementException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, 8));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 5, 9));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(15, 6, 30));
        }

        [Fact]
        public void CalcArea_WhenAllSidesAreValid_ReturnsExpectedArea()
        {

            //Arrange
            var triangle = new Triangle(5, 5, 6);

            //Act
            var area = triangle.Area;

            //Assert
            Assert.Equal(12, area);

        }

        [Fact]
        public void IsRightAngled_WithValidAngles_ReturnsTrue()
        {

            //Arrange
            var triangle = new Triangle(8, 6, 10);

            //Act
            var isRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.True(isRightAngled);

        }

        [Fact]
        public void IsRightAngled_WithInvalidAngles_ReturnsFalse()
        {

            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.False(isRightAngled);

        }
        [Fact]
        public void CalcPerimeter_WhenAllSidesAreValid_ReturnsExpectedPerimeter()
        {

            //Arrange
            var triangle = new Triangle(5, 5, 6);

            //Act
            var area = triangle.Perimeter;

            //Assert
            Assert.Equal(16, area);
        }

    }
}
