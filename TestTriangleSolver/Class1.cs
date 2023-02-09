using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestTriangleSolver
{
    [TestFixture]
    public class Equilateral
    {
        [Test]

        public void AnalyzeTriangle_Input10and10and10_ValidEquilateral()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Isosceles
    {
        [Test]
        public void AnalyzeTriangle_Input10and10and15_ValidEquilateral()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 15;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input15and10and15_ValidEquilateral()
        {
            //Arrange
            int firstSide = 15;
            int secondSide = 10;
            int thirdSide = 15;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input10and20and20_ValidEquilateral()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 20;
            int thirdSide = 20;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Scalene
    {
        [Test]
        public void AnalyzeTriangle_Input10and12and15_ValidEquilateral()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 12;
            int thirdSide = 15;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input11and13and14_ValidEquilateral()
        {
            //Arrange
            int firstSide = 11;
            int secondSide = 13;
            int thirdSide = 14;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input20and21and23_ValidEquilateral()
        {
            //Arrange
            int firstSide = 20;
            int secondSide = 21;
            int thirdSide = 23;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input30and23and24_ValidEquilateral()
        {
            //Arrange
            int firstSide = 30;
            int secondSide = 23;
            int thirdSide = 24;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_Input28and25and23_ValidEquilateral()
        {
            //Arrange
            int firstSide = 28;
            int secondSide = 25;
            int thirdSide = 23;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
