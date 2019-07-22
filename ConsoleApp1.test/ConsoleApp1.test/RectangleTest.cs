using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.test
{

    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestRectangle()
        {
            //Arrange
            Rectangle rectangle;

            //Act
            rectangle = new Rectangle();
            rectangle.SetInput(5, 7);

            //Assert
            Assert.AreEqual(35, rectangle.CalculateArea());
        }

        [TestMethod]
        public void TestZeroForRectangle()
        {
            //Arrange
            Rectangle rectangle;

            //Act
            rectangle = new Rectangle();

            //Assert
            rectangle.SetInput(0, 2);
            Assert.AreEqual(0.0, rectangle.CalculateArea());
            rectangle.SetInput(5, 0);
            Assert.AreEqual(0.0, rectangle.CalculateArea());
        }

        [TestMethod]
        public void TestNegetiveForRectangle()
        {
            //Arrange
            Rectangle rectangle;

            //Act
            rectangle = new Rectangle();

            //Assert
            rectangle.SetInput(7, -2);
            Assert.AreEqual(0.0, rectangle.CalculateArea());
            
        }
    }
}
