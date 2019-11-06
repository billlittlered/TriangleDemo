using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using GridLibrary;
using GridLibrary.Implementations;
using GridLibrary.Interfaces;

namespace UnitTestProject1
{
     [TestClass]
     public class RightTriangleTests
     {
          private IGrid _grid;

          [TestInitialize]
          public void Init()
          {
               _grid = new Grid();
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A2()
          {
               var row = "A";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, 0);
               var expectedTopRight = new Coordinate(10, 0);
               var expectedBottomLeft = new Coordinate(10, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A4()
          {
               var row = "A";
               var column = 4;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, 0);
               var expectedTopRight = new Coordinate(20, 0);
               var expectedBottomLeft = new Coordinate(20, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B2()
          {
               var row = "B";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -10);
               var expectedTopRight = new Coordinate(10, -10);
               var expectedBottomLeft = new Coordinate(10, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_C2()
          {
               var row = "C";
               var column = 2;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -20);
               var expectedTopRight = new Coordinate(10, -20);
               var expectedBottomLeft = new Coordinate(10, -30);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B4()
          {
               var row = "B";
               var column = 4;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, -10);
               var expectedTopRight = new Coordinate(20, -10);
               var expectedBottomLeft = new Coordinate(20, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_F12()
          {
               var row = "F";
               var column = 12;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(50, -50);
               var expectedTopRight = new Coordinate(60, -50);
               var expectedBottomLeft = new Coordinate(60, -60);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedTopRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedTopRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }
     }
}
