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
     public class LeftTriangleTests
     {
          private IGrid _grid;

          [TestInitialize]
          public void Init()
          {
               _grid = new Grid();
          }
          [TestMethod]
          public void Test_EnumA()
          {
               var column = (int)GridColumn.A;
               var expectedColumnNumber = 1;
               Assert.AreEqual(column, expectedColumnNumber);
          }

          [TestMethod]
          public void Test_EnumB()
          {
               var column = (int)GridColumn.B;
               var expectedColumnNumber = 2;
               Assert.AreEqual(column, expectedColumnNumber);
          }

          [TestMethod]
          public void Test_ColumnA()
          {
               var input = "A";
               var result = _grid.GetRowNumber(input);
               var expected = 1;
               Assert.AreEqual(expected, result);
          }

          [TestMethod]
          public void Test_ColumnD()
          {
               var input = "d";
               var result = _grid.GetRowNumber(input);
               var expected = 4;
               Assert.AreEqual(expected, result);
          }



          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A1()
          {
               var row = "A";
               var column = 1;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, 0);
               var expectedBottomRight = new Coordinate(10, -10);
               var expectedBottomLeft = new Coordinate(0, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_A3()
          {
               var row = "A";
               var column = 3;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, 0);
               var expectedBottomRight = new Coordinate(20, -10);
               var expectedBottomLeft = new Coordinate(10, -10);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B1()
          {
               var row = "B";
               var column = 1;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(0, -10);
               var expectedBottomRight = new Coordinate(10, -20);
               var expectedBottomLeft = new Coordinate(0, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_B3()
          {
               var row = "B";
               var column = 3;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(10, -10);
               var expectedBottomRight = new Coordinate(20, -20);
               var expectedBottomLeft = new Coordinate(10, -20);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_F11()
          {
               var row = "F";
               var column = 11;

               var resultsTuple = _grid.GetTriangle(row, column);
               var actualTopLeft = resultsTuple.Item1;
               var actualBottomRight = resultsTuple.Item2;
               var actualBottomLeft = resultsTuple.Item3;

               var expectedTopLeft = new Coordinate(50, -50);
               var expectedBottomRight = new Coordinate(60, -60);
               var expectedBottomLeft = new Coordinate(50, -60);

               Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_CheckAllTriangleCoordinates_F22()
          {
               var row = "F";
               var column = 22;

               var resultsTuple = _grid.GetTriangle(row, column);
               Assert.AreEqual(resultsTuple, null);
               //var actualTopLeft = resultsTuple.Item1;
               //var actualBottomRight = resultsTuple.Item2;
               //var actualBottomLeft = resultsTuple.Item3;

               //var expectedTopLeft = new Coordinate(50, -50);
               //var expectedBottomRight = new Coordinate(60, -60);
               //var expectedBottomLeft = new Coordinate(50, -60);

               //Assert.AreEqual(expectedTopLeft.X, actualTopLeft.X);
               //Assert.AreEqual(expectedTopLeft.Y, actualTopLeft.Y);

               //Assert.AreEqual(expectedBottomRight.X, actualBottomRight.X);
               //Assert.AreEqual(expectedBottomRight.Y, actualBottomRight.Y);

               //Assert.AreEqual(expectedBottomLeft.X, actualBottomLeft.X);
               //Assert.AreEqual(expectedBottomLeft.Y, actualBottomLeft.Y);
          }

          [TestMethod]
          public void Test_LeftTriangle_TopLeftXCoordinate()
          {
               var row = "A";
               var column = 1;

               var expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.X, 0);

               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.X, 10);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_XCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.X, 0);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.X, 0);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomLeft_YCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item3;
               Assert.AreEqual(expectedResult.Y, -20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightYCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item2;

               Assert.AreEqual(expectedResult.Y, -10);

               row = "A";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "B";
               column = 1;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -20);

               row = "B";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.Y, -20);
          }

          [TestMethod]
          public void Test_LeftTriangle_BottomRightXCoordinate()
          {
               var row = "A";
               var column = 1;
               var expectedResult = _grid.GetTriangle(row, column).Item2;

               Assert.AreEqual(expectedResult.X, 10);

               row = "A";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 20);

               row = "B";
               column = 1;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 10);

               row = "B";
               column = 3;
               expectedResult = _grid.GetTriangle(row, column).Item2;
               Assert.AreEqual(expectedResult.X, 20);
          }

          [TestMethod]
          public void Test_LeftTriangle_TopLeftYCoordinate()
          {
               var row = "A";
               var column = 1;

               var expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, 0);

               row = "B";
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, -10);

               row = "D";
               expectedResult = _grid.GetTriangle(row, column).Item1;
               Assert.AreEqual(expectedResult.Y, -30);
          }

          [TestMethod]
          public void TestRemainder()
          {
               var input = 3;
               var expectedRemainder = 1;
               var result = input % 2;

               var evenInput = 4;
               var expectedRemainderEven = 0;
               var evenResult = evenInput % 2;

               var edge1 = 1;
               var expectedEdgeRemainder = 1;
               var edgeResult = edge1 % 2;

               Assert.AreEqual(result, expectedRemainder);
               Assert.AreEqual(evenResult, expectedRemainderEven);
               Assert.AreEqual(edgeResult, expectedEdgeRemainder);
          }
     }
}
