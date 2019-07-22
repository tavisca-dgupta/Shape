using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestCircle()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle();
            circle.SetInput(5);

            //Assert
            Assert.AreEqual(78.5, circle.CalculateArea());
        }

        [TestMethod]
        public void TestZeroForCircle()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle();
            circle.SetInput(0);

            //Assert
            Assert.AreEqual(0.0, circle.CalculateArea());
        }

        [TestMethod]
        public void TestNegetiveForCircle()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle();
            circle.SetInput(-6);

            //Assert
            Assert.AreEqual(0.0, circle.CalculateArea());
        }
    }
}
