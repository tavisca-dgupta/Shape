using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.test
{
    
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTriangle()
        {
            //Arrange
            Triangle triangle;
            Triangle triangle1;

            //Act
            triangle = new Triangle();
            triangle1 = new Triangle();
            

            //Assert
            triangle.SetInput(4, 6);
            triangle.CalculateArea();
            Assert.AreEqual(12, triangle.CalculateArea());
            triangle1.SetInput(3, 4, 5);
            triangle1.CalculateArea();
            Assert.AreEqual(6, triangle1.CalculateArea());

        }

        [TestMethod]
        public void TestZeroForTriangle()
        {
            //Arrange
            Triangle triangle;
            Triangle triangle1;

            //Act
            triangle = new Triangle();
            triangle1 = new Triangle();

            //Assert
            triangle.SetInput(0, 6);
            Assert.AreEqual(0, triangle.CalculateArea());
            triangle.SetInput(4, 0);
            Assert.AreEqual(0, triangle.CalculateArea());
            triangle1.SetInput(0, 6,9);
            Assert.AreEqual(0, triangle1.CalculateArea());
            triangle1.SetInput(4, 0,5);
            Assert.AreEqual(0, triangle1.CalculateArea());
        }

        [TestMethod]
        public void TestNegetiveForTriangle()
        {
            //Arrange
            Triangle triangle;
            Triangle triangle1;

            //Act
            triangle = new Triangle();
            triangle1 = new Triangle();


            //Assert
            triangle.SetInput(7, -6, 9);
            Assert.AreEqual(0, triangle1.CalculateArea());
            triangle1.SetInput(-4, -2);
            Assert.AreEqual(0, triangle1.CalculateArea());
        }

        [TestMethod]
        public void TestIsTriangle()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle();

            //Assert
            triangle.SetInput(5, 1, 3);
            Assert.AreEqual(0, triangle.CalculateArea());
        }
    }
}
