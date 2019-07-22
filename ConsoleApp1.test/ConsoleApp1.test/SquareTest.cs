using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.test
{
    
    [TestClass]
    public class SquareTest
    {
        
        [TestMethod]
        public void TestSquare()
        {
            //Arrange
            Square square;

            //Act
            square = new Square();
            square.SetInput(5);

            //Assert
            Assert.AreEqual(25, square.CalculateArea());
        }

        [TestMethod]
        public void TestZeroForSquare()
        {
            //Arrange
            Square square;

            //Act
            square = new Square();
            square.SetInput(0);

            //Assert
            Assert.AreEqual(0, square.CalculateArea());
        }
    }
}
